

var deck= new Deck();
Console.WriteLine("Print a deck");
deck.PrintCards();
Console.WriteLine("Pick  a card, Enter Y for yes / N for No:");
string choice = Console.ReadLine();
if(choice == "Y")
{

  var card =   deck.PickRandomCard();
    Console.WriteLine(card);
}
Console.WriteLine("Shuffle  deck, Enter Y for yes / N for No:");
string choice1 = Console.ReadLine();
if(choice1 == "Y")
{
    deck.ShuffleDuck();
    deck.PrintCards();
}
Console.WriteLine("Sort  deck, Enter Y for yes / N for No:");
string choice2 = Console.ReadLine();
if(choice2 == "Y")
{
    deck.SortDeck();
    deck.PrintCards();
}




