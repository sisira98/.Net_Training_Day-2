public class CardComparator : Comparer<Card>
{
    public override int Compare(Card? c1, Card? c2)
    {
        // ranking cards by rank (with aces being highest),
        // then by suit in the order of spades (highest), hearts, diamonds, and clubs (lowest)
        // eg. 0 for the 2 of clubs and 51 for the ace of spades
        int r1 = 0, r2 = 0;
        if (c1 != null)
        {
            r1 = Deck.Ranks.IndexOf(c1.Rank) * 4 + (int)c1.Suite;
        }
        if (c2 != null)
        {
            r2 = Deck.Ranks.IndexOf(c2.Rank) * 4 + (int)c2.Suite;
        }

        return r1 - r2;
    }
}