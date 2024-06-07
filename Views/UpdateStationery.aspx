<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateStationery.aspx.cs" Inherits="WebApplication1.Views.UpdateStationery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Update Stationery</h1>
            <asp:Label ID="lblError" runat="server" ForeColor="Red" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="StationeryID" OnRowEditing="GridView1_RowEditing" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdating="GridView1_RowUpdating">
                <Columns>
                    <asp:BoundField DataField="StationeryID" HeaderText="StationeryID" ReadOnly="True" InsertVisible="False" />
                    <asp:BoundField DataField="StationeryName" HeaderText="StationeryName" />
                    <asp:BoundField DataField="StationeryPrice" HeaderText="StationeryPrice" />
                    <asp:CommandField ShowEditButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>