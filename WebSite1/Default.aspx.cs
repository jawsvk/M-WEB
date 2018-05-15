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
        BusinessLogic.AddOrder(newOrder);
        BindGrid();
                
    }

    private void BindGrid()
    {
        List<FoodOrder> allOrders = context.FoodOrders.ToList();
        GridView1.DataSource = allOrders;
        GridView1.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        BindGrid();
       
    }
    protected void OnRowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        BindGrid();
    }

    protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = GridView1.Rows[e.RowIndex];
        int order_toUpdate = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
        string name = (row.FindControl("Textbox1") as TextBox).Text;
        string dish = (row.FindControl("Textbox2") as TextBox).Text;
        string size = (row.FindControl("Textbox3") as TextBox).Text;
        bool chilli = (row.FindControl("Checkbox1") as CheckBox).Checked;
        bool salt = (row.FindControl("Checkbox2") as CheckBox).Checked;
        bool pepper = (row.FindControl("Checkbox3") as CheckBox).Checked;
        BusinessLogic.UpdateOrder(order_toUpdate, name, dish, size, chilli, salt, pepper);
        BindGrid();

    }

    protected void OnRowCancelingEdit(object sender, EventArgs e)
    {
        GridView1.EditIndex = -1;
        BindGrid();
    }

    protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridViewRow  row = GridView1.Rows[e.RowIndex];
        int order_toDelete = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
        BusinessLogic.DeleteOrder(order_toDelete);

    }

    
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}