<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Preorder.aspx.cs" Inherits="NeinteenFlower.View.Preorder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Preorder</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblPreorder" runat="server" Text="Preorder" Font-Bold="true"></asp:Label>
        </div>

        <div>
            <asp:Label ID="lblErrorMsg" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server" TextMode="Number"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="btnPreorder" runat="server" Text="Pre Order" OnClick="btnPreorder_Click" />
        </div>
    </form>
    </form>
</body>
</html>
