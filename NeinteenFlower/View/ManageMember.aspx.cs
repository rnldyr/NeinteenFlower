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
    public partial class ManageMember : System.Web.UI.Page
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
            else
            {
                List<MsMember> memberlist = MemberController.getListMembers();
                Members.DataSource = memberlist;
                Members.DataBind();
            }
        }

        protected void Members_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = Members.Rows[e.NewEditIndex];
            int id = MemberController.getMemberId(row.Cells[0].Text.ToString());
            Response.Redirect("~/View/UpdateMember.aspx?id=" + id);
        }

        protected void Members_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = Members.Rows[e.RowIndex];
            int id = MemberController.getMemberId(row.Cells[0].Text.ToString());
            MemberController.DeleteMember(id);
            Response.Redirect("~/View/ManageMember.aspx");
        }
    }
}