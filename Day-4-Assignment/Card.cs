public enum Rank
{
    Ace,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King
}public enum Suit
{
    Spades,
    Diamonds,
    Clubs,
    Hearts,
    
}
public record Card
    {
    private Rank _rank;
    private Suit _suit;

    public Suit Suit { get; }

    public Rank Rank { get; }
    public Rank GetRank() { return _rank; }
    public Suit GetSuit() { return _suit; }

    public Card(Rank rank, Suit suit)
        {
           this. _rank = rank;
           this. _suit = suit;
        }
}

