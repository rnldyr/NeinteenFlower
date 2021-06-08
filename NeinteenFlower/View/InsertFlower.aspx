<%@ Page Title="Insert Flower" Language="C#" MasterPageFile="~/View/Header.Master" AutoEventWireup="true" CodeBehind="InsertFlower.aspx.cs" Inherits="NeinteenFlower.View.InsertFlower" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
</asp:Content>
