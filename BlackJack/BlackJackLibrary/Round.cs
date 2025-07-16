using System.Reflection.Metadata.Ecma335;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Text;
using BlackJackLibrary.Cards;

namespace BlackJackLibrary;

public class Round
{
    public readonly Player Player;
    public readonly Dealer Dealer;

    public readonly Shoe Shoe;
    
    public PlayerState PlayerState { get; private set; }

    public Round(Player player, Shoe shoe, Dealer dealer)
    {
        Player = player;
        Dealer = dealer;
        
        Shoe = shoe;
        Shoe.Fill();
        Shoe.Shuffle();
    }

    public void Play()
    {
        NewRound();
        PlaceBet();
        DealCards();
        ViewResult();
        if (!BlackJack())
        {
            Turns();
            Evaluate();
        }
        CollectPlayedCards();
    }

    private void NewRound()
    {
        Console.WriteLine("\nNew Round");
        Console.WriteLine("===============");
        Player.ShowSaldo();
    }

    private void PlaceBet()
    {
        Player.Hand.Bet();
    }
 
    private void DealCards()
    {
        var PlayerCard1 = Shoe.Draw();
        Player.Hand.AddCard(PlayerCard1);
        var PlayerCard2 = Shoe.Draw();
        Player.Hand.AddCard(PlayerCard2);

        var DealerCard1 = Shoe.Draw();
        Dealer.Hand.AddCard(DealerCard1);
        var DealerCard2 = Shoe.Draw();
        DealerCard2.Flip();
        Dealer.Hand.AddCard(DealerCard2);
    }

    private void ViewResult()
    {
        Console.WriteLine(Dealer.Hand);
        Console.WriteLine(Player.Hand);
    }

    private bool BlackJack()
    {
        var message = string.Empty;
        if (Player.Hand.IsBlackJack() && Dealer.Hand.IsBlackJack())
        {
            Console.WriteLine("Both Player and Dealer have BlackJack");
            PlayerState = PlayerState.Tie;
            return true;
        }
        else if (Player.Hand.IsBlackJack())
        {
            Console.WriteLine("Player has BlackJack");
            PlayerState = PlayerState.BlackJack;
            return true;
        }
        else if (Dealer.Hand.IsBlackJack())
        {
            Console.WriteLine("Dealer has BlackJack");
            PlayerState = PlayerState.Loser;
            return true;
        }
        return false;
    }

    private void Turns()
    {
        PlayersTurn();

        if (!Player.Hand.IsBusted())
        {
            DealersTurn();
        }
        else
        {
            ViewPlayerIsBusted();
        }
    }

    private void Evaluate()
    {
        var message = string.Empty;
        if (Player.Hand.IsBusted())
        {
            message = $"Dealer won this round with a value of {Dealer.Hand.CalculateSum()}";
            PlayerState = PlayerState.Loser;
        }
        else if (Dealer.Hand.IsBusted())
        {
            message = $"Player won this round with a value of {Player.Hand.CalculateSum()}";
            PlayerState = PlayerState.Winner;
        }
        else if (Player.Hand.CalculateSum() > Dealer.Hand.CalculateSum())
        {
            message = $"Player won this round with a value of {Player.Hand.CalculateSum()}";
            PlayerState = PlayerState.Winner;
        }
        else if (Player.Hand.CalculateSum() == Dealer.Hand.CalculateSum())
        {
            message = $"It is a draw";
            PlayerState = PlayerState.Tie;
        }
        else
        {
            message = $"Dealer won this round with a value of {Dealer.Hand.CalculateSum()}";
            PlayerState = PlayerState.Loser;
        }
        Console.WriteLine(message);
    }

    private void CollectPlayedCards()
    {
        Player.Hand.Cards.Clear();
        Dealer.Hand.Cards.Clear();
    }

    private void ViewPlayerIsBusted()
    {
        Console.WriteLine($"\t({Player.Hand.ShowValue()} -> Player has Busted)");
    }

    private void PlayersTurn()
    {
        while (true)
        {
            Console.Write("(H)it or (S)tand? ");
            string input = Console.ReadLine() ?? "";

            if (input == "H" || input == "h")
            {
                Console.WriteLine();
                var card = Shoe.Draw();
                Player.Hand.AddCard(card);
                ViewResult();
                if (Player.Hand.IsBusted())
                {
                    break;
                }
            }
            else if (input == "S" || input == "s")
            {
                Console.WriteLine();
                break;
            }
            else
            {
                Console.WriteLine("Wrong input, please try again\n");
            }
        }
    }

    private void DealersTurn()
    {
        Dealer.Hand.Cards[1].Flip();
        ViewResult();
        while (Dealer.Hand.CalculateSum() < Dealer.MaxValue)
        {
            var card = Shoe.Draw();
            Dealer.Hand.AddCard(card);
            ViewResult();
            if (Dealer.Hand.IsBusted())
            {
                break;
            }
        }
    }
}

