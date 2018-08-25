<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StringManipulation.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="textTxt" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="okBtn" runat="server" OnClick="okBtn_Click" Text="Ok" />
            <br />
            <br />
            <asp:Label ID="resultLbl" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
