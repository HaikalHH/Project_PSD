<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertStationery.aspx.cs" Inherits="WebApplication1.Views.InsertStationery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Insert Stationery</h2>
            <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="Name is required." Display="Dynamic"></asp:RequiredFieldValidator>
     
            <br />
            <asp:Label ID="lblPrice" runat="server" Text="Price:"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPrice" runat="server" ControlToValidate="txtPrice" ErrorMessage="Price is required." Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="rvPrice" runat="server" ControlToValidate="txtPrice" MinimumValue="2000" MaximumValue="1000000" Type="Integer" ErrorMessage="Price must be at least 2000." Display="Dynamic"></asp:RangeValidator>
            <br />
            <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
