namespace _10_Record_LegerEenheid;

internal class Program
{
    static void Main(string[] args)
    {
        LegerEenheid eenheid1 = new PantserEenheid("EenheidAmersfoort", 100);
        LegerEenheid eenheid2 = new InfanterieEenheid("UtrechtEenheid", 99) { WapenType = "AK47"};
        Console.WriteLine(eenheid1);
        Console.WriteLine(eenheid2);
        Console.WriteLine(eenheid1.IsGrootGenoeg());
        Console.WriteLine(eenheid2.IsGrootGenoeg(110));
    }
}

public abstract record LegerEenheid(string Naam, int Grootte)
{
    public bool IsGrootGenoeg(int treshold = 15)
    {
        if (Grootte >= treshold)
        {
            return true;
        }
        return false;
    }
}
public record PantserEenheid : LegerEenheid
{
    public PantserEenheid(string Naam, int Grootte): base(Naam, Grootte)
    {
    }
} 
public record InfanterieEenheid : LegerEenheid
{
    public required string WapenType { get; init; }
    public InfanterieEenheid(string Naam, int Grootte) : base(Naam, Grootte)
    {
    }
}
