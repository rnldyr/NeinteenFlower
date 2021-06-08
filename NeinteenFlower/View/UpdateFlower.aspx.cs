using NeinteenFlower.Controller;
using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View
{
    public partial class UpdateFlower : System.Web.UI.Page
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

            if (!Page.IsPostBack)
            {
                var flowerid = Request["id"];
                int id = int.Parse(flowerid);
                MsFlower mf = FlowerController.GetFlower(id);

                if (mf != null)
                {
                    txtbxFlowerName.Text = mf.FlowerName;
                    txtbxFlowerDesc.Text = mf.FlowerDescription;
                    txtbxFlowerTyp.Text = mf.MsFlowerType.FlowerTypeName;
                    txtbxFlowerPrice.Text = mf.FlowerPrice.ToString();
                }
            }
        }

        protected void btnUpdateFlower_Click(object sender, EventArgs e)
        {
            string name = txtbxFlowerName.Text;
            HttpPostedFile file = fupFlowerImg.PostedFile;
            string desc = txtbxFlowerDesc.Text;
            string type = txtbxFlowerTyp.Text;
            int price = int.Parse(txtbxFlowerPrice.Text);
            int id = int.Parse(Request["id"]);

            string res = FlowerController.update(id, name, file, desc, type, price);
            if (res != "invalid data")
            {
                file.SaveAs(Server.MapPath("~/FlowerImages/" + name + ".jpg"));
                Response.Redirect("~/View/ManageFlower.aspx");
            }
            else
            {
                file.SaveAs(Server.MapPath("~/FlowerImages/" + name + ".jpg"));
                lblRes.Text = res;
            }
        }
    }
}