<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StationeryDetail.aspx.cs" Inherits="WebApplication1.Views.StationeryDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red"></asp:Label>
            <asp:GridView ID="gvCart" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="StationeryID" HeaderText="ID" />
                    <asp:BoundField DataField="StationeryName" HeaderText="Name" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                    <asp:BoundField DataField="Price" HeaderText="Price" DataFormatString="{0:C}" />
                </Columns>
            </asp:GridView>
            <asp:Panel ID="pnlAddToCart" runat="server" Visible="false">
                <asp:Label ID="lblStationeryName" runat="server" Text="Stationery Name"></asp:Label>
                <asp:Label ID="lblStationeryPrice" runat="server" Text="Stationery Price"></asp:Label>
                <br />
                <asp:DropDownList ID="ddlStationery" runat="server"></asp:DropDownList>
                <br />
                <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
                <asp:Button ID="btnAddToCart" runat="server" Text="Add to Cart" OnClick="btnAddToCart_Click" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>