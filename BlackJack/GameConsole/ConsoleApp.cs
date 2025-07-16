using System;
using BlackJackLibrary;
using BlackJackLibrary.Cards;
namespace GameConsole;

public class ConsoleApp
{
    public void PlayGame()
    {
        var game1 = new BlackJackGame();
        game1.Start();

    }
}
