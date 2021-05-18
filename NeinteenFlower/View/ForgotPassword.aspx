<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="NeinteenFlower.View.ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Forgot Password</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitle" runat="server" Text="Forgot Password" Font-Bold="true"></asp:Label>
        </div>

        <div>
            <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="tbEmail" runat="server" TextMode="Email"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblCaptcha" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Label ID="lblPassword" runat="server" Text="New Password: "></asp:Label>
            <asp:TextBox ID="tbNewPassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblErrorMsg" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
        </div>

        <div>
            <asp:Button ID="btnConfirm" runat="server" Text="Confirm" OnClick="btnConfirm_Click" />
        </div>
    </form>
</body>
</html>
