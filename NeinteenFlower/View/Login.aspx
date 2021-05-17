<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="NeinteenFlower.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="txtTitle" runat="server" Text="Login" Font-Bold="true"></asp:Label>
        </div>

        <div>
            <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
            <input id="txtEmail" type="text" type="email"/>
        </div>

        <div>
            <asp:Label ID="lblPassword" runat="server" Text="Password: "></asp:Label>
            <input id="txtPassword" type="password" />
        </div>

        <div>
            <asp:Label ID="lblRememberMe" runat="server" Text="Remember Me"></asp:Label>
            <input id="cbRememberMe" type="checkbox" />
        </div>

        <div>
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
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
