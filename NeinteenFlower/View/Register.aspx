<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="NeinteenFlower.View.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitle" runat="server" Text="Register" Font-Bold="true"></asp:Label>
        </div>
        <div>
            <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="tbEmail" runat="server" TextMode="Email"></asp:TextBox>
            <asp:Label ID="lblEmailErr" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Label ID="lblPassword" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="tbPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Label ID="LblPasswordErr" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Label ID="lblName" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
            <asp:Label ID="lblNameErr" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Label ID="lblDOB" runat="server" Text="Date of Birth: "></asp:Label>
            <asp:TextBox ID="tbDOB" runat="server" TextMode="Date"></asp:TextBox>
            <asp:Label ID="lblDOBErr" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Label ID="lblGender" runat="server" Text="Gender: "></asp:Label>
            <asp:RadioButtonList ID="rblGender" runat="server">
                <asp:ListItem Text="Male"></asp:ListItem>
                <asp:ListItem Text="Female"></asp:ListItem>
            </asp:RadioButtonList>
            <asp:Label ID="lblGenderErr" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number: "></asp:Label>
            <asp:TextBox ID="tbPhoneNumber" runat="server" TextMode="Phone"></asp:TextBox>
            <asp:Label ID="lblPhoneNumberErr" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Label ID="lblAddress" runat="server" Text="Address: "></asp:Label>
            <asp:TextBox ID="tbAddress" runat="server"></asp:TextBox>
            <asp:Label ID="lblAddressErr" runat="server" Text=""></asp:Label>
        </div>

        <div>
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
        </div>
    </form>
</body>
</html>
