namespace App;

internal class Program
{
    static void Main(string[] args)
    {
        IVorm Balk = new Balk(2, 3, 2);
        Console.WriteLine(Balk.BerekenOppervlakte());

        IVorm[] vormen = new IVorm[3];

        vormen[0] = new Balk(2, 3, 4);
        vormen[1] = new Bol(3);
        vormen[2] = new Kubus(3);

        Console.WriteLine(InhoudenOptellen(vormen));
    }

    public static double InhoudenOptellen(IVorm[] vormen)
    {
        double TotaleInhoud = 0d;
        foreach(var vorm in vormen)
        {
            TotaleInhoud += vorm.BerekenInhoud();
        }
        return TotaleInhoud;
    }
    
}
