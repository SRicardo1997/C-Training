using BlauwePieste;

namespace _14_Events;

internal class Program
{
    static void Main(string[] args)
    {
        var persoon = new Persoon() { Naam="Tim",  Leeftijd=20};

        persoon.LeeftijdGewijzigd += OnVerjaar;

        persoon.Verjaar(30);
        persoon.Leeftijd = 30;

    }


    static void OnVerjaar(object sender, AgeArgs e)
    {
        Console.WriteLine($"Leeftijd van {((Persoon)sender).Naam} verranderd. Oude leeftijd: {e.OudeLeeftijd}, Nieuwe leeftijd{e.NieuweLeeftijd}");
    }
}
