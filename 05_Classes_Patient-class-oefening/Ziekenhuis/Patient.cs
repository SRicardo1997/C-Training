using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Ziekenhuis
{
    public class Patient
    {
        public string Naam { get; set; }                                // Properties 
        public Geslacht Geslacht { get; set; }
        private List <Medicijnen> _medicijn = new();                     // Backing Field 
        public List <Medicijnen> Medicijnen        
        {
            get => _medicijn;
            set
            {
                if (value.Count > 3)
                {
                    throw new ArgumentException("Te veel medicijnen toegevoegd");
                }
                _medicijn = value;
            }           
            // set => _medicijn = value;
        }

        public Patient(params Medicijnen[] medicijnen)     // Constructor 
        {
            // Naam = naam;
            // Geslacht = geslacht;
            Medicijnen = medicijnen.ToList();
        }

        public void Slik(Medicijnen medicijn)
        {
            Medicijnen = new List<Medicijnen> { medicijn};
            Console.WriteLine($"Ik voel me nu veel beter na het slikken van {medicijn}");
        }
        public void Slik(Medicijnen[] medicijn)
        {
            Medicijnen = medicijn.ToList();
            Console.WriteLine($"Ik heb de volgende medicijnen geslikt: {string.Join(", ", medicijn)}");
        }

        public override string ToString()
        {
            return $"Patien {Naam} ({Geslacht})";
        }
    }
}