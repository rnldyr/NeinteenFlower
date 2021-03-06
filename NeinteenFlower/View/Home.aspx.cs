using NeinteenFlower.Model;
using NeinteenFlower.Repository;
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
                btnMngMem.Visible = true;
                btnMngEmp.Visible = true;
            }
            else if (role.Equals("Employee"))
            {
                MsEmployee user = new MsEmployee();
                user = (MsEmployee)Session["user"];
                lblWelcomeMsg.Text = "Welcome, " + user.EmployeeName;
                btnMngFlower.Visible = true;
            }
            else if (role.Equals("Member"))
            {
                MsMember user = new MsMember();
                user = (MsMember)Session["user"];
                lblWelcomeMsg.Text = "Welcome, " + user.MemberName;
                btnViewTr.Visible = true;

                gvFlowers.Visible = true;
                List<MsFlower> flowerList = FlowerRepository.FlowerList();
                gvFlowers.DataSource = flowerList;
                gvFlowers.DataBind();
            }
        }

        protected void gvFlowers_RowPreorder(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = gvFlowers.Rows[e.NewEditIndex];
            int flowerID = FlowerRepository.getFlowerId(row.Cells[0].Text.ToString());
            Response.Redirect("~/View/Preorder.aspx?id=" + flowerID);
        }

        protected void btnViewTr_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/TransactionHistory.aspx");
        }

        protected void btnMngFlower_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageFlower.aspx");
        }

        protected void btnMngMem_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageMember.aspx");
        }

        protected void btnMngEmp_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageEmployee.aspx");
        }

        protected void gvFlowers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}