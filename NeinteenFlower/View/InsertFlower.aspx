<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertFlower.aspx.cs" Inherits="NeinteenFlower.InsertFlower" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Insert Flower</title>
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
            <asp:Button ID="btnInsertFlower" runat="server" Text="Insert" OnClick="btnInsertFlower_Click"/>
            <asp:Label ID="lblRes" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
