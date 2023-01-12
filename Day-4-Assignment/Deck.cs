
public class Deck 
{
    private List<Card> _deck;
    //private List<string> _deckList;
    string suits = string.Empty;
    string ranks = string.Empty;
    
     List<string> _deckList = new List<string>();
    public void GetDeck()
    {
        List<Card> _deck = new List<Card>();



        foreach (var suit in Enum.GetValues(typeof(Suit)).Cast<Suit>())
            {
            suits = suit.ToString();
                foreach (var rank in Enum.GetValues(typeof(Rank)).Cast<Rank>())
                {
                ranks = rank.ToString();
                 _deck.Add(new Card(rank, suit));
                _deckList.Add($"{suits + " of " + ranks}");
                Console.WriteLine($"{suits + " of " + ranks}");

            }
            }

    }
    public void PrintCard()
    {
        foreach (string card in _deckList)
        {
            Console.WriteLine(card);
            break;
        }
    }
    public void PickRandomCard()
    {
        var random = new Random();
        int index = random.Next(_deckList.Count);
        Console.WriteLine(_deckList[index]);
    }public void ShuffleDuck()
    {
        List<string> suffliedList = new List<string>();
        for (int i = 0; i < _deckList.Count; i++)
        {
            var random = new Random();
            int index = random.Next(_deckList.Count);
            suffliedList.Add(_deckList[index]);
            foreach (string card in suffliedList)
            {
                Console.WriteLine(card);

            }
        }

    }
    
}

