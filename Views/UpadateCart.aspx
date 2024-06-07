<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpadateCart.aspx.cs" Inherits="WebApplication1.Views.UpadateCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Update Cart</h1>
            <asp:Label ID="lblName" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="lblPrice" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity:"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
