<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHomePage.aspx.cs" Inherits="WebApplication1.Views.AdminHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar">
            <a href="#" id="Button1"><asp:Button ID="StationeryInsertBtn" runat="server" Text="Insert Stationery" OnClick="StationeryInsertBtn_Click"/></a>
            <a href="#" id="Button1"><asp:Button ID="StationeryUpdateBtn" runat="server" Text="Update Stationery" OnClick="StationeryUpdateBtn_Click"/></a>
            <a href="#" id="Button2"><asp:Button ID="ProfileBtn" runat="server" Text="Profile" OnClick="ProfileBtn_Click"/></a>
            <a href="#" id="Button3"><asp:Button ID="TransactionReportBtn" runat="server" Text="Transaction Report" OnClick="TransactionReportBtn_Click"/></a>
            <a href="#" id="Button4"><asp:Button ID="LogOutBtn" runat="server" Text="LogOut" OnClick="LogOutBtn_Click"/></a>
           </div>
    </form>
</body>
</html>
