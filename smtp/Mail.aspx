<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mail.aspx.cs" Inherits="T8SMTP.Mail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        To Email:
        <asp:TextBox ID="txtTo" runat="server" />
        <br />

        Subject:
        <asp:TextBox ID="txtSub" runat="server" />
        <br />

        Body:
        <asp:TextBox ID="txtBody" runat="server" Height="132px" TextMode="MultiLine" Width="276px" />
        <br />

        <asp:Button ID="sendBtn" runat="server" Text="Send Mail" OnClick="sendBtn_Click" />

        <br />
        <asp:Label ID="lbl" runat="server" />
    </form>
</body>
</html>
