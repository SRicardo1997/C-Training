namespace _06_Enums_and_ExtensionMethod;

public struct Valuta
{
    public Muntsoort Muntsoort;
    public decimal Bedrag;

    public static decimal ConvertTo(Muntsoort muntsoort)
        => muntsoort switch
        {

        }

   public void OmrekenmodelVanEUR(Muntsoort muntsoort)
    {

    }
    public override string ToString()
    {
        return $"Het bedrag is {Bedrag:F2} {Muntsoort}";
    }
}
