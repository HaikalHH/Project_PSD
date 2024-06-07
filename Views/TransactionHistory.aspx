<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="WebApplication1.Views.TransactionHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Transaction History</h1>
            <asp:GridView ID="gvTransactionHistory" runat="server" AutoGenerateColumns="false" OnRowCommand="gvTransactionHistory_RowCommand">
                <Columns>
                    <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" />
                    <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date" />
                    <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnDetail" runat="server" Text="Detail" CommandName="Detail" CommandArgument='<%# Eval("TransactionID") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
