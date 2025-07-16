using System.Reflection.Metadata.Ecma335;

namespace _10_Record;

internal class Program
{
    static void Main(string[] args)
    {
        var Bier = new AlcoholHoudend(5);
        var Whiskey = new AlcoholHoudend(40);
        var Schoen = new Overig();

        Console.WriteLine($"Prijs van bier is: {Bier.BrutoPrijs(4)}"); 
        Console.WriteLine($"Prijs van wiskey is: {Whiskey.BrutoPrijs(20)}"); 
        Console.WriteLine($"Prijs van Schoen is: {Schoen.BrutoPrijs(100)}"); 
    }
}


public abstract record Product
{
    public decimal BTW() => this switch
    {
        AlcoholHoudend(decimal x) => AlcoholHoudend.AlcoholBTW + x,
        SuikerHoudend(decimal x) => SuikerHoudend.SuikerBTW + x/4,
        Overig => Overig.overigBTW,
        _ => throw new NotImplementedException()

    };

    public decimal BrutoPrijs(decimal NettoPrijs)
    {
        return NettoPrijs += NettoPrijs * BTW() / 100;
    }
}

public record AlcoholHoudend(decimal Percentage) : Product
{
    public const decimal AlcoholBTW = 21;
}

public record SuikerHoudend(decimal GramSuiker) : Product
{
    public const decimal SuikerBTW = 16;
}

public record Overig() : Product
{
    public const decimal overigBTW = 5;
}
