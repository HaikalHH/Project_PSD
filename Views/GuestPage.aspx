<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GuestPage.aspx.cs" Inherits="WebApplication1.Views.GuestPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Guest-RAiso</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>WELCOME TO RAISO</h1>

        <div class="navbar">
            <a href="#" id="loginBtn"><asp:Button ID="Button1" runat="server" Text="Login" OnClick="LoginBTN_Click"/></a>
            <a href="#" id="registBtn"><asp:Button ID="Button2" runat="server" Text="Register" OnClick="RegistBTN_Click"/></a>
            <a href="#" id="stationeryListBtn"><asp:Button ID="Button3" runat="server" Text="Stationery List" OnClick="StationeryListBTN_Click" /></a>
        </div>

    </form>
</body>
</html>
