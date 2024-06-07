<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StationeryList.aspx.cs" Inherits="WebApplication1.Views.StationeryList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Stationery List</h2>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="StationeryID">
                <Columns>
                    <asp:BoundField DataField="StationeryID" HeaderText="ID" ReadOnly="True" />
                    <asp:BoundField DataField="StationeryName" HeaderText="Name" />
                    <asp:BoundField DataField="StationeryPrice" HeaderText="Price" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
