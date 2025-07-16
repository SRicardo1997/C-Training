using System.Runtime.InteropServices.JavaScript;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is je leeftijd?");

            string inputAge = Console.ReadLine() ?? string.Empty;
            
            int age = int.Parse(inputAge);

            string volwassen = age > 18 ? "volwassen" : "een kind";
            Console.WriteLine($"Je bent {age+10} jaar oud en dus {volwassen}");
        }
    }
}
