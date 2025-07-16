namespace Betaalkaarten;

public class SaldoOntoereikendException : Exception
{
    public SaldoOntoereikendException() { }

    public SaldoOntoereikendException(string message)
        : base(message) { }

    public SaldoOntoereikendException(decimal huidigSaldo, decimal bedrag)
        : base($"Uw saldo van {huidigSaldo:F2} Euro is ontoereikend " +
            $"om een bedrag van {bedrag:F2} mee te betalen")
    { }
}
