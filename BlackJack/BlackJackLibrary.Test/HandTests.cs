using System;
using System.Data;
using BlackJackLibrary.Cards;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;

namespace BlackJackLibrary.Test;

[TestClass]
public class HandTests
{

    private Hand _sut = null!; 
    [TestInitialize]
    public void TestInitialize()
    {
        _sut = new Hand();
    }

    [TestMethod]
    public void CalculateSum_ReturnsCorrectValue()
    {
        Card card1 = new Card(Rank.Six, Suit.Hearts);
        Card card2 = new Card(Rank.Six, Suit.Diamonds);

        _sut.AddCard(card1);
        _sut.AddCard(card2);

        Assert.AreEqual(12 , _sut.CalculateSum());
    }

    [DataTestMethod]
    [DataRow(Rank.Ten, Rank.Ace, Rank.Two, 13)]
    [DataRow(Rank.Five, Rank.Eight, Rank.Two, 15)]
    [DataRow(Rank.Jack, Rank.Two, Rank.Four, 16)]
    [DataRow(Rank.Three, Rank.Ace, Rank.Six, 20)]
    [DataRow(Rank.Two, Rank.Nine, Rank.Eight, 19)]
    public void CalculateSum_ThreeCards_ReturnsCorrectValue(Rank rank1, Rank rank2, Rank rank3, int Total)
    {
        Card card1 = new Card(rank1, Suit.Hearts);
        Card card2 = new Card(rank2, Suit.Diamonds);
        Card card3 = new Card(rank3, Suit.Diamonds);

        _sut.AddCard(card1);
        _sut.AddCard(card2);
        _sut.AddCard(card3);

        Assert.AreEqual(Total, _sut.CalculateSum());
    }

    [TestMethod]
    public void AcesInHand_Add1Ace_Returns1Ace()
    {
        Card card1 = new Card(Rank.Eight, Suit.Diamonds);
        Card card2 = new Card(Rank.Ace, Suit.Clubs);

        _sut.AddCard(card1);
        _sut.AddCard(card2);

        Assert.AreEqual(1, _sut.AcesInHand());
    }

    [TestMethod]
    public void AcesInHand_Add4Ace_Returns4Aces()
    {
        Card card1 = new Card(Rank.Eight, Suit.Diamonds);
        Card card2 = new Card(Rank.Ace, Suit.Clubs);
        Card card3 = new Card(Rank.Ace, Suit.Spades);
        Card card4 = new Card(Rank.Ace, Suit.Diamonds);
        Card card5 = new Card(Rank.Ace, Suit.Hearts);

        _sut.AddCard(card1);
        _sut.AddCard(card2);
        _sut.AddCard(card3);
        _sut.AddCard(card4);
        _sut.AddCard(card5);

        Assert.AreEqual(4, _sut.AcesInHand());
    }

    [DataTestMethod]
    [DataRow(Rank.Five, Rank.Three, 19)]
    [DataRow(Rank.Eight, Rank.Nine, 18)]
    [DataRow(Rank.Jack, Rank.Two, 13)]
    [DataRow(Rank.King, Rank.Queen, 21)]
    [DataRow(Rank.Ace, Rank.Four, 16)]
    public void CalculateSum_WithAce_ReturnsCorrectValue(Rank rank2, Rank rank3, int Total)
    {
        Card card1 = new Card(Rank.Ace, Suit.Hearts);
        Card card2 = new Card(rank2, Suit.Diamonds);
        Card card3 = new Card(rank3, Suit.Clubs);

        _sut.AddCard(card1);
        _sut.AddCard(card2);
        _sut.AddCard(card3);

        Assert.AreEqual(Total, _sut.CalculateSum());
    }

    [DataTestMethod]
    [DataRow(Rank.Ten)]
    [DataRow(Rank.Jack)]
    [DataRow(Rank.Queen)]
    [DataRow(Rank.King)]
    public void IsBlackJack_21_returnsTrue(Rank rank1)
    {
        Card card1 = new Card(rank1, Suit.Hearts);
        Card card2 = new Card(Rank.Ace, Suit.Diamonds);

        _sut.AddCard(card1);
        _sut.AddCard(card2);

        Assert.IsTrue(_sut.IsBlackJack());
    }

    [TestMethod]
    public void IsBlackJack_With3Cards_returnsFasle()
    {
        Card card1 = new Card(Rank.Two, Suit.Hearts);
        Card card2 = new Card(Rank.Ten, Suit.Diamonds);
        Card card3 = new Card(Rank.Nine, Suit.Clubs);

        _sut.AddCard(card1);
        _sut.AddCard(card2);
        _sut.AddCard(card3);

        Assert.IsFalse(_sut.IsBlackJack());
    }

    [DataTestMethod]
    [DataRow(Rank.Ten, Rank.Two)]
    [DataRow(Rank.Jack, Rank.Five)]
    [DataRow(Rank.Queen, Rank.Queen)]
    [DataRow(Rank.King, Rank.Eight)]
    [DataRow(Rank.Ace, Rank.Ace)]
    [DataRow(Rank.Two, Rank.Three)]
    public void IsBlackJack_Not21_returnsFasle(Rank rank1, Rank rank2)
    {
        Card card1 = new Card(rank1, Suit.Hearts);
        Card card2 = new Card(rank2, Suit.Diamonds);

        _sut.AddCard(card1);
        _sut.AddCard(card2);

        Assert.IsFalse(_sut.IsBlackJack());
    }
}
