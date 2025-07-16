namespace App;

public class Bol : IVorm
{
    public double Straal { get; }

    public Bol(double straal)
    {
        Straal = straal;
    }

    public double BerekenInhoud()
    {
        return (4d/3) * Math.PI * Math.Pow(Straal, 3);
    }

    public double BerekenOppervlakte()
    {
        return Math.PI * Straal * Straal;
    }
}
