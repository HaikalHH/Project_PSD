<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionDetail.aspx.cs" Inherits="WebApplication1.Views.TransactionDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red" Visible="False"></asp:Label>
            <asp:GridView ID="gvTransactionDetail" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="StationeryName" HeaderText="Stationery Name" />
                    <asp:BoundField DataField="StationeryPrice" HeaderText="Price" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
