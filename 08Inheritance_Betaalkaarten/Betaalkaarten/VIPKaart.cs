namespace Betaalkaarten;

public class VIPKaart : BetaalKaart
{
    private Korting _korting = Korting.Standaard;
    public Korting Korting
    {
        get => _korting;
        set => _korting = value;
    }

    public VIPKaart(string naam, decimal saldo) : base(naam, saldo)
    {
    }

    public override void Betaal(decimal bedrag)
        => base.Betaal(BedragIncKorting(bedrag));

    private decimal BedragIncKorting(decimal bedrag)
    {
        decimal hoogteKorting = Korting switch
        {
            Korting.Extra => 0.11M,
            Korting.VIPKorting => 0.125M,
            _ => 0.10M,
        };
        
        return bedrag -= bedrag * hoogteKorting;
    }
}
