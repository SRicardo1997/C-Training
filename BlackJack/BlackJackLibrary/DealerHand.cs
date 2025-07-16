namespace BlackJackLibrary;

using System;
using BlackJackLibrary.Cards;

public class DealerHand : Hand
{

    public override string ToString()
    {
        var message = "\nDealer has\n";

        foreach (var card in Cards)
        {
            message += $"\t{card}\n";
        }

        if (!Cards[1].FaceDown)
        {
            message += $"\t({ShowValue()})\n";
        }

        return message;

    }


}
