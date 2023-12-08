<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoleManagement.aspx.cs" Inherits="Practical5.RoleManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Role:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnInsertRole" runat="server" OnClick="Button1_Click" Text="Insert Role" />
            <br />
            <br />
            Role List:<br />
            <asp:ListBox ID="lstRoles" runat="server"></asp:ListBox>
            <br />
            <br />
            User List:<br />
            <asp:ListBox ID="lstUsers" runat="server"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="btnAssignRoleToUser" runat="server" OnClick="btnAssignRoleToUser_Click" Text="Assign Role to User" />
            <br />
            <br />
            User-Role List:<br />
            <asp:ListBox ID="lstUserRole" runat="server"></asp:ListBox>
        </div>
    </form>
</body>
</html>
