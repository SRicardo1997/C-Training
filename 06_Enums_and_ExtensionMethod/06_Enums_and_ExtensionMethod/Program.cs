
namespace _06_Enums_and_ExtensionMethod;

internal class Program
{
    static void Main(string[] args)
    {
        Muntsoort munt1 = Muntsoort.Euro;
        Muntsoort munt2 = Muntsoort.Dukaat;
        MuntGeldigHeid.Geldigemunt(munt1);
        MuntGeldigHeid.Geldigemunt(munt2);
 
        Console.WriteLine($"Code van de munt is: {munt2.CodeVanMunt()}");
        Muntsoort muntcodeEuro = MuntsoortExtensions.ToMuntSoort("EUR");
        Console.WriteLine($"De muntsoort is: {muntcodeEuro}");
    }

    


}
