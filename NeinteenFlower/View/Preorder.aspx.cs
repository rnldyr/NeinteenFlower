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
    public partial class Preorder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null || Session["role"] == null)
            {
                Response.Redirect("~/View/Login.aspx");
                return;
            }

            if (!Session["role"].Equals("Member"))
            {
                Response.Redirect("~/View/Home.aspx");
            }
            else
            {
                lblErrorMsg.Visible = false;
            }
        }

        protected void btnPreorder_Click(object sender, EventArgs e)
        {
            int quantity = int.Parse(txtQuantity.Text);

            MsMember member = (MsMember)Session["user"];
            int memberId = member.MemberID;

            int flowerId = int.Parse(Request["id"]);
            DateTime curr = DateTime.Now;

            Random discRand = new Random();
            double discount = discRand.NextDouble() * 49 + 1;

            string result = TransactionController.preorder(memberId, curr, discount, flowerId, quantity);

            if (result.Equals("Success"))
            {
                Response.Redirect("~/View/Home.aspx");
            }
            else
            {
                lblErrorMsg.Text = result;
                lblErrorMsg.Visible = true;
                return;
            }
        }
    }
}