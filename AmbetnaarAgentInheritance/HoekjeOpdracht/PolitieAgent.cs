namespace HoekjeOpdracht;

public class PolitieAgent: Ambtenaar
{
    public int DienstNummer {  get; set; }

    public override void TaakUitvoeren()
    {
        Console.WriteLine("Handen Openbare Orde en Veiligheid");
    }

    // protected --> alleen aanroepen vanuit child classes
    protected void RapportSchrijven ()              
    {
        Console.WriteLine("Schrijven van Rapport");
    }
}
