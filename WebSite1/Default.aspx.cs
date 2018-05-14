using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    FoodStallEntities context = new FoodStallEntities();

    protected void Page_Load(object sender, EventArgs e)
    {
               
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        FoodOrder newOrder = new FoodOrder();
        newOrder.CustomerName = TextBox1.Text;
        newOrder.Dish = DropDownList1.SelectedValue;
        newOrder.Size = RadioButtonList1.SelectedItem.ToString();
        newOrder.Chilli = CheckBoxList1.Items[0].Selected;
        newOrder.Pepper = CheckBoxList1.Items[1].Selected;
        newOrder.Salt = CheckBoxList1.Items[2].Selected;
        context.FoodOrders.Add(newOrder);
        context.SaveChanges();
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        List<FoodOrder> allOrders = context.FoodOrders.ToList();
        GridView1.DataSource = allOrders;
        GridView1.DataBind();

    }
}