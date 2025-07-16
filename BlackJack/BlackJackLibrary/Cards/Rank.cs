namespace BlackJackLibrary.Cards;

public enum Rank
{
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King,
    Ace
}

public static class RankExtension
{
    public static int GetRankValue(this Rank rank) => rank switch
    {
        Rank.Two => 2,
        Rank.Three => 3,
        Rank.Four => 4,
        Rank.Five => 5,
        Rank.Six => 6,
        Rank.Seven => 7,
        Rank.Eight => 8,
        Rank.Nine => 9,
        Rank.Ten or Rank.Jack or Rank.Queen or Rank.King => 10,
        Rank.Ace => 11,
        _ => throw new NotImplementedException()
    };

}

