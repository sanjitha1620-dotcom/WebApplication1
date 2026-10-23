<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>
<html>
<body>
    <form id="form2" runat="server">
        <h2>Login Page</h2>

        Username:
        <asp:TextBox ID="txtUsername" runat="server" />
        <br /><br />

        Password:
        <asp:TextBox ID="txtPassword" runat="server"
            TextMode="Password" />
        <br /><br />

        <asp:Button ID="btnLogin" runat="server"
            Text="Login" OnClick="btnLogin_Click" />
        <br /><br />

        <asp:Label ID="lblMessage" runat="server" />
    </form>
</body>
</html>

