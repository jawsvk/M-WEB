<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Food Ordering Form"></asp:Label>
            <br />
            <br />
        </div>
        <asp:Label ID="Label2" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="15px" Width="331px"></asp:TextBox>
        <br />
        <br />
        Food Dish:
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Chicken Rice</asp:ListItem>
            <asp:ListItem>Dumpling Noodles</asp:ListItem>
            <asp:ListItem>Fish and Chips</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        Portion Size:
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Small</asp:ListItem>
            <asp:ListItem>Regular</asp:ListItem>
            <asp:ListItem>Large</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        Spices:<asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>Chili</asp:ListItem>
            <asp:ListItem>Pepper</asp:ListItem>
            <asp:ListItem>Salt</asp:ListItem>
        </asp:CheckBoxList>
        <asp:Button ID="Button1" runat="server" Text="Submit Order" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="margin-bottom: 0px" Text="All Orders" />
        <br />
        <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <br />
    </form>
</body>
</html>
