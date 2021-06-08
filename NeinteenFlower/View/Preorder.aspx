<%@ Page Title="Preorder" Language="C#" MasterPageFile="~/View/Header.Master" AutoEventWireup="true" CodeBehind="Preorder.aspx.cs" Inherits="NeinteenFlower.View.Preorder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
</asp:Content>
