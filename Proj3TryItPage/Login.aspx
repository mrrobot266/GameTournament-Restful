<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Proj3TryItPage.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Password1 {
            margin-left: 37px;
        }
        #stafflogPassword {
            margin-left: 12px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-size: xx-large">
            <strong>Staff&nbsp; Login</strong></div>
        <p>
            User Name:
            <asp:TextBox ID="staffUser" runat="server"></asp:TextBox>
        </p>
        <p>
            Password:
            <input id="stafflogPassword" type="password" runat ="server"/></p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
        </p>
    <p>
        To test this page: User Name: TA </p>
    <p>
        Password: Cse44598!</p>
        <p>
            <asp:Label ID="invalidLbl" runat="server" Font-Size="Large" style="font-weight: 700" Text="Invalid Login" Visible="False"></asp:Label>
        </p>
    </form>
    </body>
</html>
