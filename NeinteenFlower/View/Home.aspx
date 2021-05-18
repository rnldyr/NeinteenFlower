<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="NeinteenFlower.View.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblWelcomeMsg" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" />
            <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click"/>
        </div>
    </form>
</body>
</html>
