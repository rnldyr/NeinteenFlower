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
        var file;
        int price;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInsertFlower_Click(object sender, EventArgs e)
        {
            string name = lblFlowerName.Text;
            var file = fupFlowerImg.PostedFile;
            string desc = lblFlowerDesc.Text;
            string type = lblFlowerTyp.Text;
            int price = int.Parse(lblFlowerPrice.Text);

            string res = FlowerController.insert(name, file, desc, type, price);
        }
    }
}