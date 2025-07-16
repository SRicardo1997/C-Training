namespace BlackJackLibrary;

public class Dealer
{
    public DealerHand Hand { get; set; }

    public const int MaxValue = 17;

    public Dealer()
    {
        Hand = new DealerHand();
    }
}
