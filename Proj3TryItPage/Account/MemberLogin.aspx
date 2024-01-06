<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberLogin.aspx.cs" Inherits="Proj3TryItPage.Account.MemberLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Password1 {
            width: 167px;
            margin-left: 31px;
        }
        #memlogPassword {
            width: 170px;
            margin-left: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong style="font-size: 30px">Member Login<br />
            <asp:Label ID="invalidLbl" runat="server" Font-Size="Medium" ForeColor="#FF5050" Text="*Invalid credentials" Visible="False"></asp:Label>
            </strong>
        </div>
        <p>
            Username:
            <asp:TextBox ID="memlogText" runat="server" style="margin-left: 29px" Width="172px"></asp:TextBox>
        </p>
        <p>
            Password:
            <input id="memlogPassword" type="password" runat ="server" /></p>
        <p>
            <asp:Button ID="loginBtn" runat="server" OnClick="loginBtn_Click" Text="Login" Width="68px" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            New user? Please register.</p>
        <asp:Button ID="regBtn" runat="server" OnClick="regBtn_Click" Text="Register" />
        <asp:Button ID="homeBtn" runat="server" OnClick="homeBtn_Click" style="margin-left: 41px" Text="Back Home" />
    </form>
    <p>
        Use:&nbsp;&nbsp;&nbsp;&nbsp; Tim 123&nbsp;&nbsp;&nbsp;&nbsp; for testing purposes.</p>
</body>
</html>
