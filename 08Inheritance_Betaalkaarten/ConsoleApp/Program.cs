using Betaalkaarten;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kaart1 = new GewoneKaart("kees", 20);
            //kaart1.Betaal(-5);          // niet toegestaan
            kaart1.Betaal(5);

            Console.WriteLine(kaart1);

            var vipKaart = new VIPKaart("Hans", 200);
            vipKaart.Korting = Korting.VIPKorting;
            vipKaart.Betaal(100);
            Console.WriteLine(vipKaart);
        }
    }
}
