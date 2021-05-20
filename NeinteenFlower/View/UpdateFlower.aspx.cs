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
                    lblFlowerName.Text = mf.FlowerName;
                    lblFlowerImg.Text = mf.FlowerImage;
                    lblFlowerDesc.Text = mf.FlowerDescription;
                    lblFlowerTyp.Text = mf.MsFlowerType.FlowerTypeName;
                    lblFlowerPrice.Text = mf.FlowerPrice.ToString();
                }
                else
                {
                    //error
                }
            }
        }

        protected void btnUpdateFlower_Click(object sender, EventArgs e)
        {
            string name = lblFlowerName.Text;
            var file = fupFlowerImg.PostedFile;
            string desc = lblFlowerDesc.Text;
            string type = lblFlowerTyp.Text;
            int price = int.Parse(lblFlowerPrice.Text);

            string res = FlowerController.update(name, file, desc, type, price);
        }
    }
}