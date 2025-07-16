namespace BlackJackLibrary;

using System;
using BlackJackLibrary.Cards;

public class Hand
{
    public List<Card> Cards { get; private set; } = new();

    public void AddCard(Card card)
    {
        Cards.Add(card);
    }

    public string ShowValue()
    {
        return $"Hand Value is {CalculateSum()}";
    }

    public int CalculateSum()
    {
        int sum = Cards.Select(card => card.RankValue()).Sum();
        int NumberOfAces = AcesInHand();

        while (NumberOfAces > 0 && sum > 21)
        {
            sum -= 10;
            NumberOfAces--;
        }
        return sum;
    }

    public int AcesInHand()
    {
        int AcesInHand = Cards.Count(card => card.Rank == Rank.Ace);
        return AcesInHand;
    }

    public bool IsBusted()
    {
        return CalculateSum() > 21;
    }

    public bool IsBlackJack()
    {
        if (Cards.Count == 2)
        {
            return (CalculateSum() == 21) ? true : false;
        }
        return false;
    }
}
