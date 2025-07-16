using System.IO;

namespace App
{
    public class Kubus : IVorm 
    {
        public double Zijde { get; }

        public Kubus(double zijde)
        {
            Zijde = zijde;
        }

        public double BerekenInhoud()
        {
            return Math.Pow(Zijde, 3);
        }

        public double BerekenOppervlakte()
        {
            return (Zijde * Zijde) * 6;
        }
    }
}