using NeinteenFlower.Controller;
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
            if (!IsPostBack)
            {
                lblErrMsg.Visible = false;
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.ToString();
            string password = tbPassword.Text.ToString();
            string name = tbName.Text.ToString();
            string DOB = tbDOB.Text.ToString();
            string gender = null;

            if (rblGender.SelectedIndex > -1) 
            {
                gender = rblGender.SelectedItem.Text.ToString();
            }
            
            string phoneNumber = tbPhoneNumber.Text.ToString();
            string address = tbAddress.Text.ToString();

            string result = AuthController.register(email, password, name, DOB, gender, phoneNumber, address);

            if (result.Equals("Success"))
            {

            }
            else
            {
                lblErrMsg.Text = result;
                lblErrMsg.Visible = true;
                return;
            }
        }
    }
}