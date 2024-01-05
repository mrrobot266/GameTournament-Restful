<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Proj3TryItPage.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong style="font-size: 40px">This is the Default Web Page</strong></div>
        <p style="margin-left: 120px">
            <asp:Button ID="memberBtn" runat="server" BackColor="#CCFFFF" Font-Bold="True" ForeColor="Black" OnClick="memberBtn_Click" style="margin-left: 25px" Text=" Member Page" Width="156px" />
            <asp:Button ID="staffBtn" runat="server" BackColor="#CCFFFF" Font-Bold="True" OnClick="staffBtn_Click" style="margin-left: 44px" Text="Staff Page" Width="96px" />
            <asp:Button ID="Button1" runat="server" BackColor="#CCFFFF" Font-Bold="True" OnClick="Button1_Click" style="margin-left: 42px" Text="Service Directory" />
        </p>
        <asp:Button ID="regBtn" runat="server" OnClick="regBtn_Click" style="margin-left: 158px" Text="Member Registration" Width="133px" />
        <asp:Button ID="staffloginBtn" runat="server" OnClick="staffloginBtn_Click" style="margin-left: 62px" Text="Staff Login" Width="88px" />
        <p>
            <asp:Button ID="loginBtn" runat="server" OnClick="loginBtn_Click" style="margin-left: 166px" Text="Member Login" Width="116px" />
        </p>
    </form>
    <p>
        Click on each button to direct to whichever page you want to go to. You must sign up and login before directing to the members page.</p>
</body>
</html>
