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
        <div>
            <asp:Button ID="btnViewTr" runat="server" Text="View Transaction History" Visible="False" OnClick="btnViewTr_Click" />
            <asp:Button ID="btnMngFlower" runat="server" Text="Manage Flower" Visible="False" OnClick="btnMngFlower_Click" />
            <asp:Button ID="btnMngMem" runat="server" Text="Manage Member" Visible="False" OnClick="btnMngMem_Click" />
            <asp:Button ID="btnMngEmp" runat="server" Text="Manage Employee" Visible="False" OnClick="btnMngEmp_Click" />
        </div>
        <br />
        <asp:GridView ID="gvFlowers" runat="server" AutoGenerateColumns="False" Visible="False" OnSelectedIndexChanged="gvFlowers_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="FlowerName" HeaderText="Name" />
                <asp:ImageField DataImageUrlField="FlowerImage" HeaderText="Image" />
                <asp:BoundField DataField="FlowerDescription" HeaderText="Description" />
                <asp:BoundField DataField="MsFlowerType.FlowerTypeName" HeaderText="Flower Type" />
                <asp:BoundField DataField="FlowerPrice" HeaderText="Price" />
                <asp:CommandField SelectText="Pre Order" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
