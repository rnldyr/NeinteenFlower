using NeinteenFlower.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower
{
    public partial class InsertFlower : System.Web.UI.Page
    {
        string name, desc, type;
        HttpPostedFile file;
        int price;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertFlower_Click(object sender, EventArgs e)
        {
            name = txtbxFlowerName.Text;
            file = fupFlowerImg.PostedFile;
            desc = txtbxFlowerDesc.Text;
            type = txtbxFlowerTyp.Text;
            try
            {
                price = int.Parse(txtbxFlowerPrice.Text);
            }
            catch
            {
                price = 0;
            }

            string res = FlowerController.insert(name, file, desc, type, price);
            if(res != "invalid data")
            {
                Response.Redirect("~/View/ManageFlower.aspx");
            }
            else
            {
                lblRes.Text = res;
            }
        }
    }
}