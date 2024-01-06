<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ImageVerifierUserControl1.ascx.cs" Inherits="Proj3TryItPage.ImageVerifierUserControl1" %>
<p>
    <asp:Image ID="Image1" runat="server" Height="68px" Width="147px" />
    <asp:Button ID="imgBtn" runat="server" OnClick="imgBtn_Click" style="margin-left: 25px" Text="Get New Image" />
</p>
<p>
    <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Please enter the text above into the following textbox<asp:Label ID="errorLbl" runat="server" ForeColor="#FF3300" Text=" *Text does not match image" Visible="False"></asp:Label>
    </span>
</p>
<p>
    &nbsp;</p>

