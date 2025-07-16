namespace BlackJackLibrary;

using System;
using BlackJackLibrary.Cards;

public class PlayerHand : Hand
{
    public decimal BetAmount { get; private set; }

    public void Bet ()
    {
        while (true)
        {
            Console.Write("Pace your bet (1-10): ");
            string? input = Console.ReadLine();
            decimal.TryParse(input, out decimal betamount);
            if (betamount >= 1 && betamount <= 10)
            {
                BetAmount = betamount;
                break;
            }
            else
            {
                Console.WriteLine("\nWrong input for bet, please try again");
            }
        }
    }

    public override string ToString()
    {
        var message = "\nPlayer has\n";

        foreach (var card in Cards)
        {
            message += $"\t{card}\n";
        }

        message += $"\t({ShowValue()})\n";
        message += $"\t(Bet: {BetAmount})\n";

        return message;
    }
}
