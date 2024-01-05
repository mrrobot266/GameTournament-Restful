<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberRegistration.aspx.cs" Inherits="Proj3TryItPage.Account.MemberRegistration" %>
<%@ Register src="ImageVerifierUserControl1.ascx" tagname="ImageVerifierUserControl1" tagprefix="uc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Password1 {
            width: 158px;
            margin-left: 25px;
        }
        #mempass {
            width: 156px;
            margin-left: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-size: x-large">
            <strong>Register a New Member Below</strong></div>
        <p>
            Username:
            <asp:TextBox ID="memuserTextBox" runat="server" style="margin-left: 25px" Width="168px"></asp:TextBox>
            <asp:Label ID="errorUser" runat="server" ForeColor="#FF5050" Text="*errorUser" Visible="False"></asp:Label>
        </p>
        <p>
            Password:&nbsp;
            <input id="mempass" type="password" runat ="server" /></p>
        <uc1:ImageVerifierUserControl1 ID="ImageVerifierUserControl11" runat="server" />
        <asp:TextBox ID="imgText" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="memberRegBtn" runat="server" OnClick="memberRegBtn_Click" Text="Register" Width="84px" />
        <asp:Label ID="errorLbl" runat="server" ForeColor="#FF5050" Text=" *Text does not match image" Visible="False"></asp:Label>
        <asp:Button ID="loginBtn" runat="server" OnClick="loginBtn_Click" style="margin-left: 56px" Text="Login" Width="55px" />
        <asp:Button ID="homeBtn" runat="server" OnClick="homeBtn_Click" style="margin-left: 17px" Text="Home" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
