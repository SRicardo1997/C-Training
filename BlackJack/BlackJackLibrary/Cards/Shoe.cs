namespace BlackJackLibrary.Cards;

public class Shoe
{
    public List<Card> Cards { get; private set; } = [];

    public void Fill()
    {
        for (int i = 0; i < 6; i++)
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    Cards.Add(new Card(rank, suit));
                }
            }
        }
    }

    public void Shuffle()
    {
        Random rnd = new Random();
        for (int i = Cards.Count - 1; i > 1; i--)
        {
            int j = rnd.Next(maxValue: i);
            (Cards[i], Cards[j]) = (Cards[j], Cards[i]);
        }
    }
    public Card Draw()
    {
        var DrawedCard = Cards.ElementAt(0);
        Cards.RemoveAt(0);
        return DrawedCard;
    }
}
