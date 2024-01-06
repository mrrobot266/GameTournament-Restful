<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="Proj3TryItPage.Member" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-size: 30px; background-color: #000080; color: #FFFFFF;">
            <strong>Member</strong></div>
        <p style="font-size: 16px; font-style: normal; font-family: 'Dubai Medium'; background-color: #00FFFF;">
            Hello, this is the Tournament central. Available to all members. You can register for any of the open game tournaments you see below.
        </p>
        <p>
            &nbsp;</p>
        <p>
            <strong style="font-size: 20px">Tournaments: </strong>
        </p>
        <p style="margin-left: 240px">
            *Tournament Closed*</p>
        <asp:Button ID="Button1" runat="server" BackColor="#CCFFFF" Font-Bold="True" Height="33px" OnClick="Button1_Click" Text="Fifa 23" Width="167px" />
        <asp:Button ID="Button2" runat="server" Height="36px" style="margin-left: 56px" Text="Rocket League" Width="168px" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <p style="font-weight: 700">
            <asp:Label ID="Label6" runat="server" Text="Tournament Info: "></asp:Label>
            <asp:Label ID="Label7" runat="server" Font-Bold="False" Text="8 players, Single Elimination"></asp:Label>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
