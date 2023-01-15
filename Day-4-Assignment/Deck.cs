

public class Deck 
{
    private List<Card> _deck = new List<Card>(52);
    private static readonly Random Random = new Random();

    static Deck()
    {
        Ranks = Enumerable.Range(2, 9)
            .Select(n => n.ToString())
            .ToList();
        Ranks.AddRange(new[] { "J", "Q", "K", "A" });
    }
    public Deck()
    {
        var suites = Enum.GetValues<Suite>();
        

        foreach (var t in suites)
        {
            foreach (var r in Ranks)
            {
                _deck.Add(new Card(r, t));
            }
        }

    }
    public void PrintCards()
    {
        foreach(Card card in _deck)
        {
            Console.WriteLine(card.ToString());
        }

    }
    public List<Card> Cards => _deck;
    public static List<string> Ranks { get; }
    public Card PickRandomCard()
    {

        return _deck[Random.Next(_deck.Count)];
    }
    public void ShuffleDuck()
    {
        // Fischer-Yates shuffle algorithm
        var n = _deck.Count;
        while (n > 1)
        {
            n--;
            var k = Random.Next(n + 1);
            (_deck[k], _deck[n]) = (_deck[n], _deck[k]);
        }

    }
    public void SortDeck()
    {
        _deck.Sort(new CardComparator());
    }

}

