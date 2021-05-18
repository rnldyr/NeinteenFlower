using NeinteenFlower.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] != null)
            {
                Response.Redirect("~/View/Home.aspx");
                return;
            }
            if (!IsPostBack)
            {
                Random random = new Random();
                const string alphabets = "abcdefghijklmnopqrstuvwxyz";
                const string numerics = "1234567890";
                string alpha = new string(Enumerable.Repeat(alphabets, 3).Select(a => a[random.Next(a.Length)]).ToArray());
                string num = new string(Enumerable.Repeat(numerics, 3).Select(n => n[random.Next(n.Length)]).ToArray());
                lblCaptcha.Text = "Captcha: " + alpha + num;
            }
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.ToString();
            string captcha = lblCaptcha.Text.ToString().Split(' ')[1];
            string newPassword = tbNewPassword.Text.ToString();
            string result = AuthController.changePassword(email, captcha, newPassword);

            if (result.Equals("Fail"))
            {
                lblErrorMsg.Text = "Incorrect email or new password is different with captcha!";
                lblErrorMsg.Visible = true;
                return;
            }

            lblErrorMsg.Visible = false;
            Response.Redirect("~/View/Login.aspx");
        }
    }
}