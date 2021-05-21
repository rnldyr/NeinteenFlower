<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateMember.aspx.cs" Inherits="NeinteenFlower.View.UpdateMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Member</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitle" runat="server" Text="Update Member" Font-Bold="true"></asp:Label>
        </div>
        <div>
            <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label> <br />
            <asp:TextBox ID="tbEmail" runat="server" TextMode="Email"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblPassword" runat="server" Text="Password: "></asp:Label> <br />
            <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblName" runat="server" Text="Name: "></asp:Label> <br />
            <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblDOB" runat="server" Text="Date of Birth: "></asp:Label> <br />
            <asp:TextBox ID="tbDOB" runat="server" TextMode="Date" OnTextChanged="tbDOB_TextChanged"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblGender" runat="server" Text="Gender: "></asp:Label>
            <asp:RadioButtonList ID="rblGender" runat="server">
                <asp:ListItem Text="Male"></asp:ListItem>
                <asp:ListItem Text="Female"></asp:ListItem>
            </asp:RadioButtonList>
        </div>

        <div>
            <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number: "></asp:Label> <br />
            <asp:TextBox ID="tbPhoneNumber" runat="server" TextMode="Phone"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblAddress" runat="server" Text="Address: "></asp:Label> <br />
            <asp:TextBox ID="tbAddress" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblErrMsg" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>

        <div>
            <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click"/>
            <asp:Button ID="BackBtn" runat="server" Text="Back" OnClick="BackBtn_Click" Visible="false" />
            <br />
            <asp:Label ID="SuccessPopup" Text="Success!" Visible="false" runat="server" ForeColor="Blue" />
        </div>
    </form>
</body>
</html>
