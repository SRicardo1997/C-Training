using System.ComponentModel.Design;

namespace Datatypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float temperatuur = 28.3f;

            double pi = 3.1415d;

            decimal exactGetal = 2.45m;

            char medewerkerstatus = 'a';
            bool isLetter = char.IsLetter(medewerkerstatus);
            bool isNummertje = char.IsDigit(medewerkerstatus);

            Console.WriteLine($"Is het een letter? {isLetter}");
            Console.WriteLine($"Is het een nummertje {isNummertje}");

            decimal prijs = 20.00m;
            decimal korting = 0.10m; 
            decimal verkoopprijs = prijs * (1 - korting);
            Console.WriteLine($"De verkoopprijs met korting is ${Math.Round(verkoopprijs, 2)}");

        }
    }
}
