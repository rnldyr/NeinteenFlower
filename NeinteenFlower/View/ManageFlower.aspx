<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageFlower.aspx.cs" Inherits="NeinteenFlower.View.ManageFlower" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manage Flower</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/View/InsertFlower.aspx">Insert Flower</asp:HyperLink>
        </div>
        <asp:GridView ID="gvFlowers" runat="server" AutoGenerateColumns="False" OnRowEditing ="gvFlowers_RowEditing" OnRowDeleting="gvFlowers_RowDeleting" OnSelectedIndexChanged="gvFlowers_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="FlowerName" HeaderText="Name" />
                <asp:ImageField DataImageUrlField="FlowerImage" HeaderText="Image" />
                <asp:BoundField DataField="FlowerDescription" HeaderText="Description" />
                <asp:BoundField DataField="MsFlowerType.FlowerTypeName" HeaderText="Flower Type" />
                <asp:BoundField DataField="FlowerPrice" HeaderText="Price" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" EditText="Update" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
