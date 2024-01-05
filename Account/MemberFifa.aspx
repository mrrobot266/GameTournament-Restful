<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberFifa.aspx.cs" Inherits="Proj3TryItPage.Account.MemberFifa" %>

<%@ Register src="TournRegUC.ascx" tagname="TournRegUC" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#333399" ForeColor="White" Height="58px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Member<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Fifa 23 Tournament<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; *click each button below for each process*<br /> </strong>
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Height="53px">
            <asp:Button ID="RegistrationBtn" runat="server" BackColor="White" Height="53px" OnClick="RegistrationBtn_Click" Text="Registration" Width="153px" />
            <asp:Button ID="Button3" runat="server" BackColor="White" Height="53px" OnClick="Button3_Click" Text="Participants" Width="153px" />
            <asp:Button ID="seedBtn" runat="server" BackColor="White" Height="53px" Text="Tournament Seeding" Width="153px" />
            <br />
            <br />
        </asp:Panel>
        <uc1:TournRegUC ID="TournRegUC1" runat="server" />
        <p>
            <asp:Label ID="Label6" runat="server" style="font-weight: 700" Text="Tournament Info: "></asp:Label>
            <asp:Label ID="Label7" runat="server" Font-Bold="False" Text="8 players, Single Elimination"></asp:Label>
        </p>
        <asp:Label ID="partLbl" runat="server" style="font-weight: 700" Text="Participants" Visible="False"></asp:Label>
&nbsp;*saved in xml file*
        <p>
            <asp:TextBox ID="partTxt" runat="server" Font-Size="Large" Height="155px" ReadOnly="True" TextMode="MultiLine" Visible="False" Width="462px" Wrap="False"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="seedLbl" runat="server" style="font-weight: 700" Text="Tournament Seeding: " Visible="False"></asp:Label>
            <asp:Label ID="partLbl0" runat="server" Text="Participants will be seeded into matches against eachother here." Visible="False"></asp:Label>
        </p>
        <p>
            <asp:Button ID="startBtn" runat="server" OnClick="startBtn_Click" Text="Start Tournament" />
&nbsp;*click here when there are 8 participants registered to display matches*
        </p>
        <p style="margin-left: 40px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>Playoff Matches&nbsp;&nbsp;&nbsp;&nbsp; </strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            <asp:TextBox ID="matchesTxt" runat="server" Font-Size="Large" Height="154px" ReadOnly="True" TextMode="MultiLine" Width="466px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
