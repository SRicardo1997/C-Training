namespace BlackJackLibrary;
using BlackJackLibrary.Cards;

public class Player
{
    public PlayerHand Hand { get; set; }
    public decimal Saldo { get; private set; }

    public Player()
    {
        Hand = new PlayerHand();
        Saldo = 20;
    }

    public bool ValidSaldo()
    {
        if (Saldo < 1)
        {
            Console.WriteLine("Player does not have enough money");
            return false;
        }
        return true;
    }

    public void ShowSaldo()
    {
        Console.WriteLine($"Player has {Saldo} money");
    }

    public void UpdateSaldo(PlayerState state)
    {
        switch (state)
        {
            case PlayerState.BlackJack:
                Saldo += Hand.BetAmount*1.5m;
                break;
            case PlayerState.Winner:
                Saldo += Hand.BetAmount;
                break;
            case PlayerState.Loser:
                Saldo -= Hand.BetAmount; 
                break;
        }
    }  
}
