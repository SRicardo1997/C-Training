namespace ClassEnTests;

internal class Voertuig
{
    public Type Type { get; }
    public int AantalWielen {  get; }

    public Voertuig(Type type , int aantalwielen)
    {
        Type = type;
        AantalWielen = aantalwielen;
    }

    public bool IsRupsVoertuig()
    {
        return AantalWielen == 0;
    }


    public override string ToString()
    {
        return $"Type: {Type}, Wielen: {AantalWielen}";
    }

}
