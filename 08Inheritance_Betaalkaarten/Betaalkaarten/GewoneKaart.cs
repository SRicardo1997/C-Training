namespace Betaalkaarten;

public class GewoneKaart : BetaalKaart
{
    public GewoneKaart(string naam, decimal saldo) : base(naam, saldo)
    {      
    }

    public override void Betaal(decimal bedrag)
    {
        if (bedrag > Saldo)
        {
            throw new SaldoOntoereikendException($"Uw saldo van {Saldo} " +
                $"Euro is ontoereiken om een bedrag van {bedrag} mee te betalen");
        }
        else
        {
            base.Betaal(bedrag);
        }
    }
}
