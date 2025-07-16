namespace HoekjeOpdracht;

public class VerkeersAgent : PolitieAgent
{
    public override void TaakUitvoeren()
    {
        base.TaakUitvoeren();
        Console.WriteLine("Regelen van het verkeer");
    }

    public void SchrijfVerkeersboeke()
    {
        Console.WriteLine("Schrijven van een boete");
        RapportSchrijven();
    }
}
