
    public class ShoppingCartEntry
    {
    public ShoppingCartEntry(string name, int quantity, int price)
    {
        Name = name;
        Quantity= quantity;
        Price= price;
    }
    public string Name { get; }
    public int Quantity { get; }
    public int Price { get; }
}
