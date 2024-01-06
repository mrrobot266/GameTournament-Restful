<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Proj3TryItPage.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #TextArea1 {
            height: 107px;
            width: 576px;
        }
        #txtAreaFilter {
            width: 455px;
            height: 45px;
            margin-left: 119px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            <br />
            URL of service: <a href="http://webstrar75.fulton.asu.edu/page0/Service.svc">http://webstrar75.fulton.asu.edu/page0/Service.svc</a><br />
            <br />
            URL Back to Main Page: <a href="http://webstrar75.fulton.asu.edu/index.html">http://webstrar75.fulton.asu.edu/index.html</a><br />
        </div>
        Service 1: WebDownloading:&nbsp;&nbsp;&nbsp; string WebDownload(string url);<p>
            Input a URL string and it will return the content at the given URL.</p>
        Enter URL String:<asp:TextBox ID="txtURL" runat="server" Height="16px" style="margin-left: 12px" Width="473px"></asp:TextBox>
        <asp:Button ID="btnURL" runat="server" style="margin-left: 14px" Text="Invoke" Width="98px" OnClick="btnURL_Click" />
        <p>
            Output at URL:
            <asp:TextBox ID="txtUrlOutput" runat="server" style="margin-left: 23px" Width="1345px" Height="102px" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Service 2: WordFilter:&nbsp;&nbsp; string WordFilter(string str);</p>
        <p>
            Input a string of words and it will filter out function words and XML element tag names and attribute names. Stopword: &quot;a|an|in|on|the|is|are|am|i|my|it|be|was|and&quot;</p>
        Enter Words String:
        <asp:TextBox ID="txtFilterInput" runat="server" style="margin-left: 3px" Width="457px"></asp:TextBox>
        <asp:Button ID="btnFilter" runat="server" style="margin-left: 27px" Text="Invoke" Width="98px" OnClick="btnFilter_Click" />
        <p>
            Filtered String:
            <asp:TextBox ID="txtFilterOutput" runat="server" style="margin-left: 35px" Width="456px" Height="72px" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Service 3: RandomNameGenerator:&nbsp;&nbsp; string RandomUserNameGenerator(int num)</p>
        <p>
            Press the button below to generate a random username string. </p>
        <p>
            Enter 3 numbers<asp:TextBox ID="txtNumbers" runat="server" style="margin-left: 54px"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="RandomNameGenerator" />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        Service 4: Registration:&nbsp;&nbsp; public string Registration(string teamName, string email, string usernames)<br />
        <br />
        Input a teamname, an email for each player, and a username for each player.<br />
        <br />
        Enter Information<br />
        <br />
        Team name<br />
        <asp:TextBox ID="txtTeamName" runat="server"></asp:TextBox>
        <br />
        <br />
        Player 1<br />
        Enter username&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter Email<br />
        <asp:TextBox ID="txtUser1" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtEmail1" runat="server" style="margin-left: 42px" Width="126px"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Submit your registration" />
        <br />
        <br />
        <asp:TextBox ID="txtRegMsg" runat="server" Height="73px" Width="847px"></asp:TextBox>
        <br />
        <br />
        <br />
        Service 5: Seeding:&nbsp; string Seeding(string team1, string team2, string team3, string team4);<br />
        <br />
        Input 4 teams and they will be seeded into different groups and put against eachother.<br />
        <br />
        Enter Teams<br />
        <br />
        Team 1&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Team 2<br />
        <asp:TextBox ID="txtTeam1" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtTeam2" runat="server" style="margin-left: 28px" Width="135px"></asp:TextBox>
        <br />
        <br />
        Team 3&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Team 4<br />
        <asp:TextBox ID="txtTeam3" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtTeam4" runat="server" style="margin-left: 34px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnCreate" runat="server" OnClick="btnCreate_Click" Text="Create Games" />
        <br />
        <br />
        Resulting Games after seeding
        <br />
        <asp:TextBox ID="txtGameResult" runat="server" Height="50px" Width="583px"></asp:TextBox>
    </form>
</body>
</html>
