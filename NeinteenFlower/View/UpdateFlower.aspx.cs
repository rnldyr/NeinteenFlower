using NeinteenFlower.Controller;
using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower
{
    public partial class UpdateFlower : System.Web.UI.Page
    {
        static MsFlower mf;
        string flowerid;
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                flowerid = Request.QueryString["id"];
                id = int.Parse(flowerid);
                mf = FlowerController.GetFlower(id);

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

            string res = FlowerController.update(id, name, file, desc, type, price);
        }
    }
}