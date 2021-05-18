using NeinteenFlower.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null || Session["role"] == null)
            {
                Response.Redirect("~/View/Login.aspx");
                return;
            }

            string role = (string)Session["role"];
            if (role.Equals("Admin"))
            {
                string user = Session["user"].ToString();
                lblWelcomeMsg.Text = "Welcome, " + user;
            }
            else if (role.Equals("Employee"))
            {
                MsEmployee user = new MsEmployee();
                user = (MsEmployee)Session["user"];
                lblWelcomeMsg.Text = "Welcome, " + user.EmployeeName;
            }
            else if (role.Equals("Member"))
            {
                MsMember user = new MsMember();
                user = (MsMember)Session["user"];
                lblWelcomeMsg.Text = "Welcome, " + user.MemberName;
            }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Home.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Cookies["user"].Expires = DateTime.Now.AddDays(-1);
            Session.Clear();
            Response.Redirect("~/View/Login.aspx");
        }
    }
}