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
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
            OnRowEditing ="OnRowEditing"
            OnRowUpdating ="OnRowUpdating"
            OnRowCancelingEdit ="OnRowCancelingEdit"
            OnRowDeleting ="OnRowDeleting"
            DataKeyNames="OrderID" 
            >
             
         <Columns>
                    <asp:TemplateField HeaderText="OrderID">
         <ItemTemplate>
                 <asp:Label ID="OrderID" runat="server" Text='<%# Bind("OrderID") %>' />                              
         </ItemTemplate>
                     </asp:TemplateField>  
                    <asp:TemplateField HeaderText="CustomerName">
         <ItemTemplate>
                 <asp:Label ID="CustomerName" runat="server" Text='<%# Bind("CustomerName") %>' />                              
         </ItemTemplate>
          <EditItemTemplate>
                  <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("CustomerName") %>'></asp:TextBox>
          </EditItemTemplate>
          </asp:TemplateField>  
                    <asp:TemplateField HeaderText="Dish">
         <ItemTemplate>
                 <asp:Label ID="Dish" runat="server" Text='<%# Bind("Dish") %>' />                              
         </ItemTemplate>
         <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Dish") %>'></asp:TextBox>
          </EditItemTemplate>
                     </asp:TemplateField>  
         <asp:TemplateField HeaderText="Size">
         <ItemTemplate>
                 <asp:Label ID="Size" runat="server" Text='<%# Bind("Size") %>' />                              
         </ItemTemplate>
             <EditItemTemplate>
             <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Size") %>'></asp:TextBox>
             </EditItemTemplate>
                     </asp:TemplateField>  
             <asp:TemplateField HeaderText="Chilli">
         <ItemTemplate>
                 <asp:Checkbox ID="Chilli" runat="server"  checked='<%# Bind("Chilli") %>' Enabled ="false" />                              
         </ItemTemplate>
          <EditItemTemplate>
                 <asp:Checkbox ID="Checkbox1" runat="server" checked='<%# Bind("Chilli") %>'></asp:Checkbox>
          </EditItemTemplate>
                     </asp:TemplateField>  
            <asp:TemplateField HeaderText="Salt">
         <ItemTemplate>
                 <asp:Checkbox ID="Salt" runat="server"  checked='<%# Bind("Salt") %>' Enabled ="false" />                              
         </ItemTemplate>
          <EditItemTemplate>
                 <asp:Checkbox ID="Checkbox2" runat="server" checked='<%# Bind("Salt") %>'></asp:Checkbox>
          </EditItemTemplate>
                     </asp:TemplateField>  
          <asp:TemplateField HeaderText="Pepper">
         <ItemTemplate>
                 <asp:Checkbox ID="Pepper" runat="server" checked='<%# Bind("Pepper") %>' Enabled ="false" />                              
         </ItemTemplate>
          <EditItemTemplate>
                 <asp:Checkbox ID="Checkbox3" runat="server" checked='<%# Bind("Pepper") %>'></asp:Checkbox>
          </EditItemTemplate>
         </asp:TemplateField>  
       
         <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True" />
       
            </Columns> 
         
        </asp:GridView>
      
        <br />
    </form>
</body>
</html>
