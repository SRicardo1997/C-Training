namespace HoekjeOpdracht;

public abstract class Ambtenaar
{
    public string? Naam {  get; set; }
    public Geslacht Geslacht { get; set; }
    public abstract void TaakUitvoeren();           // abstract method
}
