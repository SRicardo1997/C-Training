namespace _08_Inheritance;

public class Kaart
{
    public string Naam { get; init; }

    private decimal _saldo;
    public decimal Saldo
    {
        get => _saldo;
        set
        {
            if (_saldo < value)
            {
                throw new InvalidOperationException("");
            }
            _saldo = value;
        }
    }

    public Kaart(string naam, decimal saldo)
    {
        Naam = naam;    
        Saldo = saldo; 
    }

    public override string ToString()
    {
        return $"Hallo";
    }


}
