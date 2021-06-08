<%@ Page Title="Home" Language="C#" MasterPageFile="~/View/Header.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="NeinteenFlower.View.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label runat="server" Text="Label"></asp:Label>
    </div>
    <div>
        <asp:Label ID="lblWelcomeMsg" runat="server" Text=""></asp:Label>
    </div>

    <div>
        <asp:Button ID="btnViewTr" runat="server" Text="View Transaction History" Visible="False" OnClick="btnViewTr_Click" />
        <asp:Button ID="btnMngFlower" runat="server" Text="Manage Flower" Visible="False" OnClick="btnMngFlower_Click" />
        <asp:Button ID="btnMngMem" runat="server" Text="Manage Member" Visible="False" OnClick="btnMngMem_Click" />
        <asp:Button ID="btnMngEmp" runat="server" Text="Manage Employee" Visible="False" OnClick="btnMngEmp_Click" />
    </div>
    <br />
    <asp:GridView ID="gvFlowers" runat="server" AutoGenerateColumns="False" Visible="False" OnSelectedIndexChanged="gvFlowers_SelectedIndexChanged" OnRowEditing="gvFlowers_RowPreorder">
        <Columns>
            <asp:BoundField DataField="FlowerName" HeaderText="Name" />
            <asp:ImageField DataImageUrlField="FlowerImage" HeaderText="Image" />
            <asp:BoundField DataField="FlowerDescription" HeaderText="Description" />
            <asp:BoundField DataField="MsFlowerType.FlowerTypeName" HeaderText="Flower Type" />
            <asp:BoundField DataField="FlowerPrice" HeaderText="Price" />
            <asp:CommandField ButtonType="Button" EditText="Pre Order" ShowEditButton="true"/>
        </Columns>
    </asp:GridView>
</asp:Content>
