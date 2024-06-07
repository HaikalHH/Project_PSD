<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="WebApplication1.Views.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RegisterPage</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Register</h1>
        <div style="margin-bottom: 10px;>
            <asp:Label ID="LBLName" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="TXTUsername" runat="server" ></asp:TextBox>
        </div>
        <div style="margin-bottom: 10px;>
            <asp:Label ID="LBLDOB" runat="server" Text="DOB"></asp:Label>
            <asp:TextBox ID="TXTDOB" runat="server" TextMode="Date"></asp:TextBox>
        </div>
        <div style="margin-bottom: 10px;>
            <asp:Label ID="LBLGENDER" runat="server" Text="Gender"></asp:Label>
            <asp:DropDownList ID="DDLGender" runat="server">
                <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div style="margin-bottom: 10px;>
            <asp:Label ID="LBLAddress" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="TXTAddress" runat="server"></asp:TextBox>
        </div>
        <div style="margin-bottom: 10px;>
            <asp:Label ID="LBLPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TXTPassword" runat="server"></asp:TextBox>
        </div>
        <div style="margin-bottom: 10px;>
            <asp:Label ID="LBLPhone" runat="server" Text="Phone"></asp:Label>
            <asp:TextBox ID="TXTPhone" runat="server"></asp:TextBox>
        </div>
        <div style="margin-bottom: 10px;>
            <asp:Label ID="LBLERROR" runat="server" Text=""></asp:Label>
            <asp:Button ID="RegistBTN" runat="server" Text="Register" OnClick="RegistBTN_Click"/>
        </div>
    </form>
</body>
</html>
