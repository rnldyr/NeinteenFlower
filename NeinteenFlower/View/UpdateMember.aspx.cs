using NeinteenFlower.Controller;
using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View
{
	public partial class UpdateMember : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            if (!IsPostBack)
            {
                int memberId = int.Parse(Request["id"]);
                MsMember member = MemberController.getMember(memberId);
                tbEmail.Text = member.MemberEmail;
                tbPassword.Attributes.Add("value", member.MemberPassword);
                tbName.Text = member.MemberName;
                tbDOB.Text = member.MemberDOB.ToString("yyyy-MM-dd");
                if (member.MemberGender.Equals("Male"))
                {
                    rblGender.SelectedIndex = 0;
                }
                else
                {
                    rblGender.SelectedIndex = 1;
                }
                tbPhoneNumber.Text = member.MemberPhone;
                tbAddress.Text = member.MemberAddress;
            }
		}

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageMember.aspx");
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            int memberId = int.Parse(Request["id"]);
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

            string result = MemberController.updateMember(memberId, email, password, name, DOB, gender, phoneNumber, address);

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

        protected void tbDOB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}