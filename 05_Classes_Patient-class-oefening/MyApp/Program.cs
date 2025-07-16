using Ziekenhuis;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient patient1 = new Patient();    
            Patient patient2 = new Patient();
            Patient patient3 = new Patient()
            {
                Naam = "Ricardo",
                Geslacht = Geslacht.Man,
            };

            patient1.Naam = "Bo";
            patient1.Geslacht = Geslacht.Vrouw;     // Setter aanroepen
            Console.WriteLine(patient1);
            patient1.Slik(Medicijnen.Omeprazol);

            patient2.Naam = "Tim";
            patient2.Geslacht = Geslacht.Man;
            Console.WriteLine(patient2);
            Medicijnen[] patient2Medicijnen = { Medicijnen.Omeprazol, Medicijnen.Ibuprofen };
            patient2.Slik(patient2Medicijnen);
        }
    }
}
