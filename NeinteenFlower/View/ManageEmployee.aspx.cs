using NeinteenFlower.Model;
using NeinteenFlower.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NeinteenFlower.View
{
    public partial class ManageEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<MsEmployee> employeelist = EmployeeRepository.getListEmployee();
            Employees.DataSource = employeelist;
            Employees.DataBind();
        }

        protected void Employees_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = Employees.Rows[e.NewEditIndex];
            int id = EmployeeController.getEmployeeId(row.Cells[0].Text.ToString());
            Response.Redirect("~/View/UpdateEmployee.aspx?id=" + id);
        }

        protected void Employees_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = Employees.Rows[e.RowIndex];
            int id = EmployeeController.getEmployeeId(row.Cells[0].Text.ToString());
            EmployeeController.DeleteEmployee(id);
        }
    }
}