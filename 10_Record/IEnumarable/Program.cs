namespace IEnumarable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] morsecode = { "Alpha", "Bravo", "Charlie", "Echo", "Foxtroxt", "Golf", "Hotel", "India"};

            var WoordenMetE = morsecode.Where(n => n.Contains('o'));

            foreach (var woord in WoordenMetE)
            {
                Console.WriteLine(woord);
            }
            
        }
    }
}
