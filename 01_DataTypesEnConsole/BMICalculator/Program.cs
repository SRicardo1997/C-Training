namespace BMICalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij de BMI calculator");
            Console.Write("Voer je gewicht in (kg): ");
            string InputGewicht = Console.ReadLine() ?? string.Empty;
            Console.Write("Voer je lengte in (m): ");
            string InputLengte = Console.ReadLine() ?? string.Empty;

            if (double.TryParse(InputGewicht, out double gewicht) && 
                double.TryParse(InputLengte, out double lengte))
            {
                double bmi = gewicht / (lengte * lengte);
                Console.WriteLine($"je BMI is: {Math.Round(bmi, 2, MidpointRounding.AwayFromZero)}");
            }
            else
            {
                Console.WriteLine("Geen geldige gewicht of lengte ingevoerd");
            }
        }
    }
}
