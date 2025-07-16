namespace RodePise_Loop
{
    internal class Program
    {
        static void Main(string[] args)
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
        }


            static long GetFactorial(int factorial)
            {
                int faculteit = 1;
                for (int i = 1; i < factorial; i++)
                {
                    faculteit *= i;

                };
            return faculteit;
                
            }
        }
    }


