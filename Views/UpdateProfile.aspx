<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="WebApplication1.Views.UpdateProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Update Profile</h1>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
            <asp:Label ID="lblMessage" runat="server" ForeColor="Green" Visible="false" />
            <div>
                <asp:Label ID="lblName" runat="server" Text="Name: " />
                <asp:TextBox ID="txtName" runat="server" />
                <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="Name is required" />
                <asp:RegularExpressionValidator ID="revName" runat="server" ControlToValidate="txtName" ErrorMessage="Name must be between 5 and 50 characters" ValidationExpression="^.{5,50}$" />
                <asp:CustomValidator ID="cvNameUnique" runat="server" ControlToValidate="txtName" OnServerValidate="cvNameUnique_ServerValidate" ErrorMessage="Name must be unique" />
            </div>
            <div>
                <asp:Label ID="lblDOB" runat="server" Text="Date of Birth: " />
                <asp:TextBox ID="txtDOB" runat="server" />
                <asp:RequiredFieldValidator ID="rfvDOB" runat="server" ControlToValidate="txtDOB" ErrorMessage="Date of Birth is required" />
                <asp:CustomValidator ID="cvDOB" runat="server" ControlToValidate="txtDOB" OnServerValidate="cvDOB_ServerValidate" ErrorMessage="You must be at least 1 year old" />
            </div>
            <div>
                <asp:Label ID="lblGender" runat="server" Text="Gender: " />
                <asp:DropDownList ID="ddlGender" runat="server">
                    <asp:ListItem Text="Select Gender" Value="" />
                    <asp:ListItem Text="Male" Value="Male" />
                    <asp:ListItem Text="Female" Value="Female" />
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvGender" runat="server" ControlToValidate="ddlGender" InitialValue="" ErrorMessage="Gender is required" />
            </div>
            <div>
                <asp:Label ID="lblAddress" runat="server" Text="Address: " />
                <asp:TextBox ID="txtAddress" runat="server" />
                <asp:RequiredFieldValidator ID="rfvAddress" runat="server" ControlToValidate="txtAddress" ErrorMessage="Address is required" />
            </div>
            <div>
                <asp:Label ID="lblPassword" runat="server" Text="Password: " />
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
                <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is required" />
                <asp:RegularExpressionValidator ID="revPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password must be alphanumeric" ValidationExpression="^[a-zA-Z0-9]*$" />
            </div>
            <div>
                <asp:Label ID="lblPhone" runat="server" Text="Phone: " />
                <asp:TextBox ID="txtPhone" runat="server" />
                <asp:RequiredFieldValidator ID="rfvPhone" runat="server" ControlToValidate="txtPhone" ErrorMessage="Phone is required" />
            </div>
            <div>
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            </div>
        </div>
    </form>
</body>
</html>
