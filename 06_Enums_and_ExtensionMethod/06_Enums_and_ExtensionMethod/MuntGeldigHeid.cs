namespace _06_Enums_and_ExtensionMethod;

internal class MuntGeldigHeid
{
    public static void Geldigemunt(Muntsoort munt)
        => Console.WriteLine(isMuntGeldig(munt) ? "Geldig" : "Niet geldig");

    private static bool isMuntGeldig(Muntsoort muntsoort)
        => muntsoort == Muntsoort.Euro;
}
