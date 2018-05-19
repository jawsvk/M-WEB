<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <% =DateTime.Now %>
            <br />
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />

        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button" />
            </p>
        <asp:UpdatePanel ID="UpdatePanel1" updatemode ="Conditional" runat="server">
            <ContentTemplate>
                 <% =DateTime.Now %>
                <br />
                <asp:Button ID="Button2" runat="server" Text="Button" />
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdatePanel ID="UpdatePanel2" UpdateMode="Conditional " runat="server">
            <ContentTemplate>
                 <% =DateTime.Now %>
                <br />
                <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click" />
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:UpdateProgress ID="UpdateProgress1" runat="server">
            <ProgressTemplate>
                Updating...
            </ProgressTemplate>
        </asp:UpdateProgress>
    </form>
</body>
</html>
