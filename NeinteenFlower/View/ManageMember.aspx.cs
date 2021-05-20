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
    public partial class ManageMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<MsMember> memberlist = MemberRepository.getListMembers();
            Members.DataSource = memberlist;
            Members.DataBind();
        }

        protected void Members_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = Members.Rows[e.NewEditIndex];
            int id = MemberRepository.getMemberId(row.Cells[0].Text.ToString());
            Response.Redirect("~/View/UpdateMember.aspx?id=" + id);
        }

        protected void Members_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = Members.Rows[e.RowIndex];
            int id = MemberRepository.getMemberId(row.Cells[0].Text.ToString());
            MemberRepository.DeleteMember(id);
        }
    }
}