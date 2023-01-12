
string name = string.Empty;
int quantity = 0;
int price = 0;
bool stopFlag = false;
ShoppingCart shoppingCart = new ShoppingCart();
{
    for (int i = 0; i <= 3; i++)
    {
        if (i == 3)
        {
            Console.WriteLine("Order limit reached !");
            break;
        }
        Console.Write("Please enter product name : ");
        name = Console.ReadLine();
        Console.Write("Please enter product quantity :  ");
        quantity = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter product price :  ");
        price = Convert.ToInt32(Console.ReadLine());
        ShoppingCartEntry shoppingCartEntry = new ShoppingCartEntry(name, quantity, price);
        shoppingCart.ShoppingCartList(name, quantity, price);

        Console.WriteLine("Enter E to stop and enter any key  to continue");
        if (Console.ReadLine() == "E")
        {
            stopFlag = true;
            break;
        }

    }
    Console.WriteLine("Your order list is");
        shoppingCart.ViewOrderList();
}



