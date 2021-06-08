<%@ Page Title="Manage Member" Language="C#" MasterPageFile="~/View/Header.Master" AutoEventWireup="true" CodeBehind="ManageMember.aspx.cs" Inherits="NeinteenFlower.View.ManageMember" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:HyperLink ID="InsertHyperlink" NavigateUrl="~/View/InsertMember.aspx" runat="server">Insert Member</asp:HyperLink>
    </div>
    <br />
    <div>
        <asp:GridView ID="Members" runat="server" AutoGenerateColumns="False" OnRowEditing="Members_RowEditing" OnRowDeleting="Members_RowDeleting">
            <Columns>
                <asp:BoundField DataField="MemberName" HeaderText="Name" />
                <asp:BoundField DataField="MemberDOB" HeaderText="Date of Birth" />
                <asp:BoundField DataField="MemberGender" HeaderText="Gender" />
                <asp:BoundField DataField="MemberAddress" HeaderText="Address" />
                <asp:BoundField DataField="MemberPhone" HeaderText="Phone" />
                <asp:BoundField DataField="MemberEmail" HeaderText="Email" />
                <asp:CommandField ButtonType="Button" ShowEditButton="true" EditText="Update" ShowDeleteButton="true"/>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
