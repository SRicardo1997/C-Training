namespace _06_Enums_and_ExtensionMethod;

static class MuntsoortExtensions
{
    public static string CodeVanMunt(this Muntsoort muntsoort) =>
    muntsoort switch
    {
        Muntsoort.Euro => "EUR",
        Muntsoort.Gulden => "Hfl",
        Muntsoort.Florijn => "fl",
        Muntsoort.Dukaat => "HD",
        _ => throw new NotImplementedException(),
    };

    public static Muntsoort ToMuntSoort(this string muntcode)
    {

        Muntsoort muntsoort = muntcode switch
        {
            "EUR" => Muntsoort.Euro,
            "Hfl" => Muntsoort.Gulden,
            "fl" => Muntsoort.Florijn,
            "HD" => Muntsoort.Dukaat,
            _ => throw new InvalidValutaException(),
        };
        return muntsoort;




    }


}
