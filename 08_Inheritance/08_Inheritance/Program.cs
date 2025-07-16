using System.Text;

namespace _08_Inheritance;

internal class Program
{
    static void Main(string[] args)
    {
        Kaart kaart1 = new GewoneKaart("Tim", 20);

        Console.WriteLine(kaart1);
    }
}
