
Deck deck= new Deck();
Console.WriteLine("Print a deck");
deck.GetDeck();
Console.WriteLine("Print a card");
deck.PrintCard();
Console.WriteLine("Pick  a card, Enter Y for yes / N for No:");
string choice = Console.ReadLine();
if(choice == "Y")
{
    deck.PickRandomCard();
}
Console.WriteLine("Shuffle  deck, Enter Y for yes / N for No:");
string choice1 = Console.ReadLine();
if(choice1 == "Y")
{
    deck.ShuffleDuck();
}




