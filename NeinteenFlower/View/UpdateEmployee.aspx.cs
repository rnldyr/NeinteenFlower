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
    public partial class UpdateEmployee : System.Web.UI.Page
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

            if (!IsPostBack)
            {
                int employeeId = int.Parse(Request["id"]);
                MsEmployee employee = EmployeeController.getEmployee(employeeId);
                tbEmail.Text = employee.EmployeeEmail;
                tbPassword.Attributes.Add("value", employee.EmployeePassword);
                tbName.Text = employee.EmployeeName;
                tbDOB.Text = employee.EmployeeDOB.ToString("yyyy-MM-dd");
                if (employee.EmployeeGender.Equals("Male"))
                {
                    rblGender.SelectedIndex = 0;
                }
                else
                {
                    rblGender.SelectedIndex = 1;
                }
                tbPhoneNumber.Text = employee.EmployeePhone;
                tbAddress.Text = employee.EmployeeAddress;
                tbSalary.Text = employee.EmployeeSalary.ToString();
            }
        }

        protected void BackBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageEmployee.aspx");
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            int employeeId = int.Parse(Request["id"]);
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
            int salary = int.Parse(tbSalary.Text);

            string result = EmployeeController.updateEmployee(employeeId, email, password, name, DOB, gender, phoneNumber, address, salary);

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