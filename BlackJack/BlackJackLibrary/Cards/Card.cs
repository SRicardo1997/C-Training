namespace BlackJackLibrary.Cards;

public class Card
{
    public Rank Rank { get;}
    public Suit Suit { get; }
    
    public bool FaceDown { get; private set; }

    public Card(Rank rank, Suit suit)
    {
        Rank = rank;
        Suit = suit;
    }

    public int RankValue()
    {
        return Rank.GetRankValue();
    }

    public void Flip()
    {
        FaceDown = !FaceDown;
    }

    public override string ToString()
    {
        return FaceDown 
            ? $"## Face Down ##"
            : $"{Rank} of {Suit}";
    }
}