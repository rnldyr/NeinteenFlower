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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["user"] != null)
                {
                    switch (Request.Cookies["user"]["role"])
                    {
                        case "Admin":
                            tbEmail.Text = "admin";
                            tbPassword.Attributes.Add("value", "admin");
                            break;
                        case "Employee":
                            MsEmployee employee = new MsEmployee();
                            employee = AuthController.getEmployee(int.Parse(Request.Cookies["user"]["userId"]));
                            tbEmail.Text = employee.EmployeeEmail;
                            tbPassword.Attributes.Add("value", employee.EmployeePassword);
                            break;
                        case "Member":
                            MsMember member = new MsMember();
                            member = AuthController.GetMember(int.Parse(Request.Cookies["user"]["userId"]));
                            tbEmail.Text = member.MemberEmail;
                            tbPassword.Attributes.Add("value", member.MemberPassword);
                            break;
                    }

                }
            }
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

            // Login Succeed
            lblErrorMsg.Visible = false;
            var roleAndId = result.Split('-');
            string role = roleAndId[0];
            int userId = int.Parse(roleAndId[1]);

            if (role.Equals("Admin"))
            {
                string user = "admin";
                Session["user"] = user;
            }
            else if (role.Equals("Employee"))
            {
                MsEmployee user = new MsEmployee();
                user = AuthController.getEmployee(userId);
                Session["user"] = user;
            }
            else if (role.Equals("Member"))
            {
                MsMember user = new MsMember();
                user = AuthController.GetMember(userId);
                Session["user"] = user;
            }

            Session["role"] = role;

            // Check Remember Me
            if (cbRememberMe.Checked)
            {
                HttpCookie cookie = new HttpCookie("user");
                cookie.Values.Add("userId", userId.ToString());
                cookie.Values.Add("role", role);
                cookie.Expires = DateTime.Now.AddDays(1);
                Response.SetCookie(cookie);
            }

            tbEmail.Text = "";
            tbPassword.Text = "";
            Response.Redirect("~/View/Home.aspx");
        }
    }
}