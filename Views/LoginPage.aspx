<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="WebApplication1.Views.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LoginPage</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>LOGIN</h1>
        <div style="margin-bottom: 10px;>
            <asp:Label ID="LBLUserName" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="TXTUsername" runat="server"></asp:TextBox>
        </div>
        <div style="margin-bottom: 10px;>
            <asp:Label ID="LBLPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TXTPassword" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:CheckBox ID="CBRememberME" runat="server" Text="Remember Me"/>
        </div>
        <div>
            <asp:Label ID="LBLERROR" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="LoginBTN" runat="server" Text="Login" OnClick="LoginBTN_Click"/>
        </div>
    </form>
</body>
</html>
