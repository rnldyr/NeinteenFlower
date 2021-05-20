using NeinteenFlower.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View
{
    public partial class Preorder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null || Session["role"] == null)
            {
                Response.Redirect("~/View/Login.aspx");
                return;
            }
            if(!IsPostBack)
            {
                lblQtyError.Visible = false;
            }
        }

        protected void btnPreorder_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtQuantity.Text);
            int flowerID = int.Parse(Request["id"]);
            string result = AuthController.preorder(quantity);

            if(result.Equals("Success"))
            {
                Response.Redirect("~/View/Home.aspx");
            }
            else
            {
                lblQtyError.Text = result;
                lblQtyError.Visible = true;
                return;
            }
        }
    }
}