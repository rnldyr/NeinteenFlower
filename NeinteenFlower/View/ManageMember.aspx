<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageMember.aspx.cs" Inherits="NeinteenFlower.View.ManageMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server"  OnItemCommand="Repeater1_ItemCommand">
        <div>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <asp:Label ID="NameDisplay" runat="server" Text='<%# Eval("MemberName") %>'></asp:Label>
                    <asp:Label Text="       |       " runat="server" />
                    <asp:Label ID="DateOfBirthDisplay" runat="server" Text='<%# Eval("MemberDOB") %>'></asp:Label>
                    <asp:Label Text="       |       " runat="server" />
                    <asp:Label ID="GenderDisplay" runat="server" Text='<%# Eval("MemberGender") %>'></asp:Label>
                    <asp:Label Text="       |       " runat="server" />
                    <asp:Label ID="AddressDisplay" runat="server" Text='<%# Eval("MemberAddress") %>'></asp:Label>
                    <asp:Label Text="       |       " runat="server" />
                    <asp:Label ID="PhoneDisplay" runat="server" Text='<%# Eval("MemberPhone") %>'></asp:Label>
                    <asp:Label Text="       |       " runat="server" />
                    <asp:Label ID="EmailDisplay" runat="server" Text='<%# Eval("MemberEmail") %>'></asp:Label>
                    <asp:Label Text="       |       " runat="server" />
                    <asp:Label ID="PasswordDisplay" runat="server" Text='<%# Eval("MemberPassword") %>'></asp:Label>
                    <br />
                    <asp:Button ID="UpdateBtn" runat="server" Text="Update" />
                    <asp:Button ID="DeleteBtn" Text="Delete" runat="server" />
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
