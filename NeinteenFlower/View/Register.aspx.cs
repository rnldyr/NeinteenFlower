using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("~/View/Home.aspx");
                return;
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.ToString();
            string password = tbPassword.Text.ToString();
            string name = tbName.Text.ToString();
            DateTime DOB = tbDOB.Text.ToString();
        }
    }
}