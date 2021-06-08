using NeinteenFlower.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View
{
    public partial class InsertFlower : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null || Session["role"] == null)
            {
                Response.Redirect("~/View/Login.aspx");
                return;
            }

            if (!Session["role"].Equals("Employee"))
            {
                Response.Redirect("~/View/Home.aspx");
            }
        }

        protected void btnInsertFlower_Click(object sender, EventArgs e)
        {
            string name = txtbxFlowerName.Text;
            HttpPostedFile file = fupFlowerImg.PostedFile;
            string desc = txtbxFlowerDesc.Text;
            string type = txtbxFlowerTyp.Text;
            int price;

            try
            {
                price = int.Parse(txtbxFlowerPrice.Text);
            }
            catch
            {
                price = 0;
            }

            string res = FlowerController.insert(name, file, desc, type, price);
            if (res != "invalid data")
            {
                file.SaveAs(Server.MapPath("~/FlowerImages/" + name + ".jpg"));
                Response.Redirect("~/View/ManageFlower.aspx");
            }
            else
            {
                lblRes.Text = res;
            }
        }
    }
}