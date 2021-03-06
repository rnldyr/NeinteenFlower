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
    public partial class ManageFlower : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null || Session["role"] == null)
            {
                Response.Redirect("~/View/Login.aspx");
                return;
            }

            if (!Session["role"].Equals("Employee"))
            {
                Response.Redirect("~/View/Home.aspx");
            }
            else
            {
                List<MsFlower> flowerList = FlowerRepository.FlowerList();
                gvFlowers.DataSource = flowerList;
                gvFlowers.DataBind();
            }
        }

        protected void gvFlowers_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = gvFlowers.Rows[e.NewEditIndex];
            string name = row.Cells[0].Text;
            MsFlower mf = FlowerRepository.GetFlowerbyName(name);

            Response.Redirect("~/View/UpdateFlower.aspx?id=" + mf.FlowerID);
        }

        protected void gvFlowers_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = gvFlowers.Rows[e.RowIndex];
            string name = row.Cells[0].Text;
            MsFlower mf = FlowerRepository.GetFlowerbyName(name);

            FlowerRepository.delete(mf.FlowerID);
            Response.Redirect("~/View/ManageFlower.aspx");
        }

        protected void gvFlowers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}