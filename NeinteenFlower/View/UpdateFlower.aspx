<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateFlower.aspx.cs" Inherits="NeinteenFlower.UpdateFlower" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update Flower</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblFlowerName" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtbxFlowerName" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="lblFlowerImg" runat="server" Text="Image"></asp:Label>
            <asp:FileUpload ID="fupFlowerImg" runat="server" />
            <br />

            <asp:Label ID="lblFlowerDesc" runat="server" Text="Description"></asp:Label>
            <asp:TextBox ID="txtbxFlowerDesc" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="lblFlowerTyp" runat="server" Text="Flower Type"></asp:Label>
            <asp:TextBox ID="txtbxFlowerTyp" runat="server"></asp:TextBox>
            <br />

            <asp:Label ID="lblFlowerPrice" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="txtbxFlowerPrice" runat="server"></asp:TextBox>
            <br />

            <br />
            <br />
            <asp:Button ID="btnUpdateFlower" runat="server" Text="Update" OnClick="btnUpdateFlower_Click"/>
        </div>
    </form>
</body>
</html>
