<%@ Page Title="Manage Flower" Language="C#" MasterPageFile="~/View/Header.Master" AutoEventWireup="true" CodeBehind="ManageFlower.aspx.cs" Inherits="NeinteenFlower.View.ManageFlower" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
</asp:Content>
