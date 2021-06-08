<%@ Page Title="Manage Employee" Language="C#" MasterPageFile="~/View/Header.Master" AutoEventWireup="true" CodeBehind="ManageEmployee.aspx.cs" Inherits="NeinteenFlower.View.ManageEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:HyperLink ID="InsertHyperlink" NavigateUrl="~/View/InsertEmployee.aspx" runat="server">Insert Employee</asp:HyperLink>
    </div>
    <br />
    <div>
        <asp:GridView ID="Employees" runat="server" AutoGenerateColumns="False" OnRowEditing="Employees_RowEditing" OnRowDeleting="Employees_RowDeleting">
            <Columns>
                <asp:BoundField DataField="EmployeeName" HeaderText="Name" />
                <asp:BoundField DataField="EmployeeDOB" HeaderText="Date of Birth" />
                <asp:BoundField DataField="EmployeeGender" HeaderText="Gender" />
                <asp:BoundField DataField="EmployeeAddress" HeaderText="Address" />
                <asp:BoundField DataField="EmployeePhone" HeaderText="Phone" />
                <asp:BoundField DataField="EmployeeEmail" HeaderText="Email" />
                <asp:BoundField DataField="EmployeeSalary" HeaderText="Salary" />
                <asp:CommandField ButtonType="Button" ShowEditButton="true" EditText="Update" ShowDeleteButton="true"/>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
