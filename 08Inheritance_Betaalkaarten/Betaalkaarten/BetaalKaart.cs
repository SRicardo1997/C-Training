namespace Betaalkaarten;

public class BetaalKaart
{
    public string? Naam { get; set; }
    private decimal _saldo;
    public decimal Saldo
    {
        get => _saldo;
        private set
        {
            SaldoCheck(value);
            _saldo = value;
        }
    }

    private void SaldoCheck(decimal bedrag)
    {
        if (bedrag > _saldo)
        {
            throw new SaldoOntoereikendException(_saldo, bedrag);
        }

    }

    public BetaalKaart(string naam, decimal saldo)
    {
        Naam = naam;
        _saldo = saldo;
    }

    public virtual void Betaal(decimal bedrag) => Saldo -= bedrag;

    public override string ToString()
    {
        return $" Het saldo is: {Saldo}";
    }


}
