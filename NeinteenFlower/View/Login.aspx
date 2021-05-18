<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NeinteenFlower.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitle" runat="server" Text="Login" Font-Bold="true"></asp:Label>
        </div>

        <div>
            <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="tbEmail" runat="server" TextMode="Email"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblPassword" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblRememberMe" runat="server" Text="Remember Me"></asp:Label>
            <asp:CheckBox ID="cbRememberMe" runat="server" />
        </div>

        <div>
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </div>

        <div>
            <asp:Label ID="lblErrorMsg" runat="server" Text="Incorrect email or password!" Visible="false" ForeColor="Red"></asp:Label>
        </div>

        <br /><br />

        <div>
            <asp:HyperLink ID="hlRegister" runat="server" NavigateUrl="~/View/Register.aspx" Font-Underline="false">Register</asp:HyperLink>
        </div>

        <div>
            <asp:HyperLink ID="hlForgotPassword" runat="server" NavigateUrl="~/View/ForgotPassword.aspx" Font-Underline="false">Forgot Password</asp:HyperLink>
        </div>
    </form>
</body>
</html>
