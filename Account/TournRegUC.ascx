<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="TournRegUC.ascx.cs" Inherits="Proj3TryItPage.Account.TournRegUC" %>
<p>
    <asp:Label ID="Label1" runat="server" Font-Size="Large" style="font-weight: 700" Text="Tournament Registration:"></asp:Label>
</p>
<p>
    &nbsp;<asp:Label ID="Label3" runat="server" Text="Player username"></asp:Label>
</p>
<p>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label4" runat="server" Text="Player email"></asp:Label>
</p>
<p>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Submit registration" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label5" runat="server" ForeColor="#009900" Text="*Registration Succesful*" Visible="False"></asp:Label>
</p>

