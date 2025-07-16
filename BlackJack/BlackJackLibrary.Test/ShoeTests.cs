using System.Data;
using BlackJackLibrary.Cards;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;

namespace BlackJackLibrary.Test;

[TestClass]
public class ShoeTests
{
    [TestMethod]
    public void FirstCard_GenerateObjects_CorrectAmountOfObjects()
    {
        // Arrange
        var _sut = new Shoe();

        // Act
        _sut.Fill();

        // Assert
        Assert.AreEqual(312, _sut.Cards.Count);
    }

    [TestMethod]
    public void Fill_FirstCardInCardsList_ReturnTwoOfSpades()
    {
        var _sut = new Shoe();

        _sut.Fill();

        Assert.AreEqual("Two of Spades", _sut.Cards[0].ToString());
    }

    [TestMethod]
    public void Fill_LastCardInCardsList_ReturnTwoOfSpades()
    {
        var _sut = new Shoe();

        _sut.Fill();

        Assert.AreEqual("Ace of Clubs", _sut.Cards[311].ToString());
    }

    [DataTestMethod]
    [DataRow(Rank.Two, Suit.Spades, 0)]
    [DataRow(Rank.Three, Suit.Spades, 1)]
    [DataRow(Rank.Four, Suit.Spades, 2)]
    [DataRow(Rank.Five, Suit.Spades, 3)]
    [DataRow(Rank.Six, Suit.Spades, 4)]
    [DataRow(Rank.Seven, Suit.Spades, 5)]
    [DataRow(Rank.Eight, Suit.Spades, 6)]
    [DataRow(Rank.Nine, Suit.Spades, 7)]
    [DataRow(Rank.Ten, Suit.Spades, 8)]
    [DataRow(Rank.Jack, Suit.Spades, 9)]
    [DataRow(Rank.Queen, Suit.Spades, 10)]
    [DataRow(Rank.King, Suit.Spades, 11)]
    [DataRow(Rank.Ace, Suit.Spades, 12)]
    public void Shuffle_First12Cards_ReturnCorrectCards(Rank rank, Suit suit, int i)
    {
        var _sut = new Shoe();

        _sut.Fill();

        string expected = $"{rank} of {suit}";
        Assert.AreEqual(expected, _sut.Cards[i].ToString());
    }

    [TestMethod]
    public void Shuffle_First12Cards_ReturnDifferentCards()
    {
        var _sut = new Shoe();

        _sut.Fill();
        List<Card> CardsUnshuffled = _sut.Cards[0..12];
        
        _sut.Shuffle();
        List<Card> CardsShuffled = _sut.Cards[0..12];

        CollectionAssert.AreNotEqual(CardsUnshuffled, CardsShuffled);
    }

    [TestMethod]
    public void Shuffle_Last12Cards_ReturnDifferentCards()
    {
        var _sut = new Shoe();

        _sut.Fill();
        List<Card> CardsUnshuffled = _sut.Cards[299..311];

        _sut.Shuffle();
        List<Card> CardsShuffled = _sut.Cards[299..311];

        CollectionAssert.AreNotEqual(CardsUnshuffled, CardsShuffled);
    }

    [TestMethod]
    public void Draw_Draw1Card_RemovesCardFromList()
    {
        var _sut = new Shoe();

        _sut.Fill();
        int OldCount = _sut.Cards.Count;
        _sut.Draw();


        Assert.AreEqual(OldCount-1, _sut.Cards.Count);
    }

    [TestMethod]
    public void Draw_Draw5Card_RemovesCardFromList()
    {
        var _sut = new Shoe();

        _sut.Fill();
        int OldCount = _sut.Cards.Count;
        _sut.Draw();
        _sut.Draw();
        _sut.Draw();
        _sut.Draw();
        _sut.Draw();


        Assert.AreEqual(OldCount - 5, _sut.Cards.Count);
    }
}
