namespace App;

public class Balk : IVorm
{
    public double Lengte { get; }
    public double Breedte { get; }
    public double Diepte { get; }

    public Balk(double lengte, double breedte, double diepte)
    {
        Lengte = lengte;
        Breedte = breedte;
        Diepte = diepte;
    }

    public double BerekenInhoud()
    {
        return Lengte * Breedte * Diepte;
    }

    public double BerekenOppervlakte()
    {
        return Lengte* Breedte;
    }
}
    