namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PriemgetallenArray();

            int[] nummers = { 1, 4, 6, 8, 90, 3, 7 };
            
            Console.WriteLine(MaxValueInArray(nummers));
        }

        static void PriemgetallenArray()
        {
            int[] priemgetallen = { 2, 3, 5, 7, 11, 13, 17 };
            int som = 0;
            for (int i = 0; i < priemgetallen.Length; i++)
            {
                Console.WriteLine(priemgetallen[i]);
                som += priemgetallen[i];
            }
            Console.WriteLine($"Som van de priemgetallen: {som}");
        }  

        static int MaxValueInArray(int[] NumberList)
        {
            int maxValue = NumberList.Max();
            return maxValue;
        }

    }
}
