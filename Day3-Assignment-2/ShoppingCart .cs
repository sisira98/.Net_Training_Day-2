
using System.Collections.Generic;

public class ShoppingCart
    {
        List<ShoppingCartEntry> cartList = new List<ShoppingCartEntry>
        {
        };
    public void ShoppingCartList(string name, int quantity, int price)
    {
        cartList.Add(new ShoppingCartEntry(name, quantity, price));
        
    }
    public void ViewOrderList()
    {

        foreach (ShoppingCartEntry shopping in cartList)
        {
            Console.WriteLine($"Order Deatils: Name :  {shopping.Name}, Quantity : {shopping.Quantity}, Price : ${shopping.Price}");
        }
        Order r = new Order(cartList);
        r.GetTotalPrice();

    }
}

