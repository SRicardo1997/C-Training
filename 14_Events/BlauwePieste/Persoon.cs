namespace BlauwePieste;

public delegate void AgeHandler(object sender, AgeArgs e);

public class Persoon
{
    public string? Naam { get; set; }

    private int _leeftijd;
    public int Leeftijd
    {
        get => _leeftijd;
        set
        {
            if (_leeftijd != value)
            {
                var ageArgs = new AgeArgs() { OudeLeeftijd = _leeftijd, NieuweLeeftijd = value };
                OnGewijzigd(ageArgs);
            }
            _leeftijd = value;
        }
    }


    public event AgeHandler? LeeftijdGewijzigd;

    public void Verjaar(int leeftijd)
    {
        Leeftijd = leeftijd;
    }

    protected virtual void OnGewijzigd(AgeArgs e)
    {
        LeeftijdGewijzigd?.Invoke(this, e);
    }
}
