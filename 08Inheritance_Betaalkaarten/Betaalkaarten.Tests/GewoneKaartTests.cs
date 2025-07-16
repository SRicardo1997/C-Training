namespace Betaalkaarten.Tests;

[TestClass]
public sealed class GewoneKaartTests
{
    [TestMethod]
    public void AanmakenGewoneKaart_ReturnsCorrectName()
    {
        var _sut = new GewoneKaart("Tester", 20M);

        Assert.AreEqual("Tester", _sut.Naam);
    }

    [TestMethod]
    public void AanmakenGewoneKaart_ReturnsCorrectSaldo()
    {
        var _sut = new GewoneKaart("Tester", 20M);

        Assert.AreEqual(20M, _sut.Saldo);
    }


    [TestMethod]
    public void Betaal_ValidAmount_ReturnsCorrectly()
    {
        var _sut = new GewoneKaart("Tester", 20M);

        _sut.Betaal(15);

        Assert.AreEqual(5, _sut.Saldo);
    }

    [TestMethod]
    public void Betaal_InvalidAmount_ReturnsException()
    {
        var _sut = new GewoneKaart("Tester", 20M);

        Action Act = () => _sut.Betaal(25);

        Assert.ThrowsException<SaldoOntoereikendException>(Act);
    }
}
