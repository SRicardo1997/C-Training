using System.Text;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //simpleLoops();
            //GetFactorialOpdracht();
            //Console.WriteLine(bereken(5));
            string RandomZin = BouwZin("I", "Love", "MD");
            Console.WriteLine(RandomZin);
        }


        static void simpleLoops()
        {
            for (int i = 0; i <= 50; i += 5)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------------------------------- ");
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        static int bereken(int a, int b = 4)
        {
            return a + b;
        }


        private static bool GetFactorialOpdracht()
        {
            Console.WriteLine("Voer een geheel getal in:");

            string inputWaarde = Console.ReadLine() ?? string.Empty;

            if (!long.TryParse(inputWaarde, out long value))
            {
                Console.WriteLine("Geen geldig getal ingevoerd");
                return false;
            }

            long factorial = GetFactorial(value);
            Console.WriteLine(factorial);
            return true;
        }

        static long GetFactorial(long factorial)
        {
            int faculteit = 1;
            for (int i = 1; i <= factorial; i++)
            {
                faculteit *= i;
            };
            return faculteit;
        }

        static string BouwZin(params string[] woorden)
        {
            string zin = string.Empty;
            foreach (var woord in woorden)
            {
                zin += woord + " ";
            }
            return zin;
        }

        static string BouwZin2(params string[] woorden)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var woord in woorden)
            {
                sb.Append(woord);
                sb.Append(' ');
            }
            return sb.ToString();
        }
    }
}
