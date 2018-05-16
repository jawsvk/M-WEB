using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Business logi behind the UI
/// </summary>
public class BusinessLogic
{
    

    public static void AddOrder(FoodOrder order)
    {
        using (FoodStallEntities context = new FoodStallEntities())
        {
            context.FoodOrders.Add(order);
            context.SaveChanges();
        }
    }

    public static void UpdateOrder(int order_toUpdate,string name, string dish, string size,bool chilli, bool salt, bool pepper)
    {
        FoodStallEntities context = new FoodStallEntities();
        FoodOrder order = context.FoodOrders.Where(y => y.OrderID == order_toUpdate).First();

        order.CustomerName = name;
        order.Dish = dish;
        order.Size = size;
        order.Chilli = chilli;
        order.Salt = salt;
        order.Pepper = pepper;
        

        context.SaveChanges();        

    }

    public static void DeleteOrder(int orderID)
    {
        using (FoodStallEntities context = new FoodStallEntities())
        {
            FoodOrder order = context.FoodOrders.Where(y => y.OrderID == orderID).First();
            context.FoodOrders.Remove(order);
            context.SaveChanges();
        }
    }
  
   

}