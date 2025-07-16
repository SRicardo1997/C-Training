namespace Persoongegevens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Graag uw gegevens invullen");
            Console.WriteLine("Volledige naam: ");
            string naam = Console.ReadLine();
            Console.WriteLine("Woonplaats: ");
            string woonplaats = Console.ReadLine();
            Console.WriteLine("Paspoortnummer: ");
            string paspoortnummer = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Uw ingevulde gegevens: ");
            Console.WriteLine($"U bent {naam} en u woont in {woonplaats} met paspoort nummer {paspoortnummer}");
        

        }
    }
}
