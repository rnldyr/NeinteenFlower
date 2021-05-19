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
            Repeater1.DataSource = memberlist;
            Repeater1.DataBind();
        }
    }
}