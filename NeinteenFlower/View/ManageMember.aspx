<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageMember.aspx.cs" Inherits="NeinteenFlower.View.ManageMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manage Member</title>
</head>
<body>
    <form id="form1" runat="server"  OnItemCommand="Repeater1_ItemCommand">
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
    </form>
</body>
</html>
