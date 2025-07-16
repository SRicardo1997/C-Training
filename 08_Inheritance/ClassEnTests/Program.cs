namespace ClassEnTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voertuig voertuig1 = new Voertuig(Type.Pantserwagen, 4);
            Console.WriteLine(voertuig1);

            Voertuig voertuig2 = new Voertuig(Type.Jeep, 0);
            Console.WriteLine(voertuig2.IsRupsVoertuig());
        }
    }
}
