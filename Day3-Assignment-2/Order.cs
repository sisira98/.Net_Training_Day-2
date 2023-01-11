
using System;

public class Order
{
    List<ShoppingCartEntry> orderList = new List<ShoppingCartEntry>
    {
    };
    public double _tax;
    public void setsalary()
    {
        _tax = 20.00;
    }
    public Order(List<ShoppingCartEntry> list)
    {
        this.orderList = list;
    }
    public void GetTotalPrice()
    {
        double total = 0;
        foreach (ShoppingCartEntry item in orderList)
        {

           total += (item.Price * item.Quantity);
        }
        Console.WriteLine($"Total price of your orders is : {_tax + total}");


    }
    
   
}

