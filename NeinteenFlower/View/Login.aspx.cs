using NeinteenFlower.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.ToString();
            string password = tbPassword.Text.ToString();
            string result =  AuthController.getLoginInfo(email, password);
            if (result.Equals("Fail"))
            {
                lblErrorMsg.Visible = true;
                return;
            }
            //lblErrorMsg.Visible = false;
            var user = result.Split('-');
            string role = user[0];
            int userId = int.Parse(user[1]);
            string userName = user[2];
            lblEmail.Text = "";
            lblPassword.Text = "";
            Response.Redirect("~/View/Home.aspx?userName=" + userName);
        }
    }
}