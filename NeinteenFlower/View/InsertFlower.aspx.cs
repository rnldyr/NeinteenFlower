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
            price = int.Parse(txtbxFlowerPrice.Text);

            string res = FlowerController.insert(name, file, desc, type, price);
        }
    }
}