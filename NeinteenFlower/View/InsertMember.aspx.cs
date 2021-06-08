using NeinteenFlower.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View
{
    public partial class InsertMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null || Session["role"] == null)
            {
                Response.Redirect("~/View/Login.aspx");
                return;
            }

            if (!Session["role"].Equals("Admin"))
            {
                Response.Redirect("~/View/Home.aspx");
            }
        }

        protected void InsertBtn_Click(object sender, EventArgs e)
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

            string result = MemberController.register(email, password, name, DOB, gender, phoneNumber, address);

            if (result.Equals("Success"))
            {
                SuccessPopup.Visible = true;
                BackBtn.Visible = true;

            }
            else
            {
                lblErrMsg.Text = result;
                lblErrMsg.Visible = true;
                return;
            }
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageMember.aspx");
        }

        protected void tbDOB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}