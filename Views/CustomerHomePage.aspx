<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerHomePage.aspx.cs" Inherits="WebApplication1.Views.CustomerHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <a href="#" id="Button2"><asp:Button ID="StationeryBtn" runat="server" Text="Stationeries" OnClick="StationeryBtn_Click"/></a>
        <a href="#" id="Button3"><asp:Button ID="CartBtn" runat="server" Text="Cart" OnClick="CartBtn_Click"/></a>
        <a href="#" id="Button4"><asp:Button ID="ProfileBtn" runat="server" Text="Profile" OnClick="ProfileBtn_Click"/></a>
        <a href="#" id="Button5"><asp:Button ID="TransactionBtn" runat="server" Text="Transaction" OnClick="TransactionBtn_Click" /></a>
        <a href="#" id="Button6"><asp:Button ID="LogOutBtn" runat="server" Text="LogOut" OnClick="LogOutBtn_Click" /></a>
    </form>
</body>
</html>
