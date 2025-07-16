using BlackJackLibrary.Cards;

namespace BlackJackLibrary.Test;

[TestClass]
public sealed class CardTests
{
    [DataTestMethod]
    [DataRow(Rank.Three, Suit.Spades, "Three of Spades")]
    [DataRow(Rank.Ace, Suit.Diamonds, "Ace of Diamonds")]
    [DataRow(Rank.Jack, Suit.Hearts, "Jack of Hearts")]
    [DataRow(Rank.King, Suit.Clubs, "King of Clubs")]
    [DataRow(Rank.Eight, Suit.Spades, "Eight of Spades")]
    public void ToString_Displays_Correctly(Rank rank, Suit suit, string expected)
    {
        // Arrange
        var _sut = new Card(rank, suit);

        // Act
        var result = _sut.ToString();

        // Assert
        Assert.AreEqual(expected, result);
    }

    [DataTestMethod]
    [DataRow(Rank.Two, 2)]
    [DataRow(Rank.Three, 3)]
    [DataRow(Rank.Four, 4)]
    [DataRow(Rank.Five, 5)]
    [DataRow(Rank.Six, 6)]
    [DataRow(Rank.Seven, 7)]
    [DataRow(Rank.Eight, 8)]
    [DataRow(Rank.Nine, 9)]
    [DataRow(Rank.Jack, 10)]
    [DataRow(Rank.Queen, 10)]
    [DataRow(Rank.King, 10)]
    [DataRow(Rank.Ace, 11)]
    public void GetRankValue_ReturnsCorrectIntValue(Rank rank, int expected)
    {
        var _sut = new Card(rank, Suit.Spades);

        var result = _sut.RankValue(); 

        Assert.AreEqual(expected, result);
    }
}
