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
            <asp:TextBox ID="txtRole" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnInsertRole" runat="server" OnClick="btnInsertRole_Click" Text="Insert Role" />
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
            <asp:Button ID="btnAssignRole" runat="server" OnClick="btnAssignRole_Click" Text="Assign Role to User" />
            <br />
            <br />
            Role :
            <asp:DropDownList ID="ddlRole" runat="server">
            </asp:DropDownList>
&nbsp;
            <asp:Button ID="btnGetRoleUsers" runat="server" Text="Get User" OnClick="btnGetRoleUsers_Click"  />
            <br />
            User-Role List:<br/>
            <asp:ListBox ID="lstUserRole" runat="server"></asp:ListBox>
        </div>
    </form>
</body>
</html>
