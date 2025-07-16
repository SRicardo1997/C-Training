namespace BlackJackLibrary;

using System;
using System.Numerics;
using BlackJackLibrary.Cards;

public class BlackJackGame
{
    public bool Endgame { get; private set; } = false;

    public void Start()
    {
        var shoe = new Shoe();
        var player = new Player();
        var dealer = new Dealer();

        while (!Endgame && player.ValidSaldo())
        {
            var Round = new Round(player, shoe, dealer);
            Round.Play();
            player.UpdateSaldo(Round.PlayerState);
            player.ShowSaldo();
            AskForAnotherRound();
        }
    }

    private void AskForAnotherRound()
    {
        while (true)
        {
            Console.Write("\nDo you want to keep playing (Y)es of (N)o? ");
            string? KeepPlaying = Console.ReadLine();
            if (KeepPlaying == "N" || KeepPlaying == "n")
            {
                Endgame = true;
                break;
            }
            else if (KeepPlaying == "Y" || KeepPlaying == "y")
            {
                Endgame = false;
                break;
            }
            else
            {
                Console.WriteLine("Wrong input, please try again\n");
            }
        }
    }
}



