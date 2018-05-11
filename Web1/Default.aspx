<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
        </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
    <p>
        <input id="Text1" type="text" /></p>
    <p>
        <input id="Button2" " type="button" value="button" /></p>
</body>
</html>
