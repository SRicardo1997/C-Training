namespace Betaalkaarten.Tests;

[TestClass]
public sealed class VIPKaartTests
{
    [TestMethod]
    public void AanmakenGewoneKaart_ReturnsCorrectName()
    {
        var _sut = new VIPKaart("Tester", 20M);

        Assert.AreEqual("Tester", _sut.Naam);
    }

    [TestMethod]
    public void AanmakenGewoneKaart_ReturnsCorrectSaldo()
    {
        var _sut = new VIPKaart("Tester", 20M);

        Assert.AreEqual(20M, _sut.Saldo);
    }

    [TestMethod]
    public void Betaal_ValidAmount_StandaardKorting_ReturnsCorrectly()
    {
        var _sut = new VIPKaart("Tester", 200M);

        _sut.Betaal(100);

        Assert.AreEqual(110, _sut.Saldo);
    }

    [TestMethod]
    public void Betaal_ValidAmount_ExtraKorting_ReturnsCorrectly()
    {
        var _sut = new VIPKaart("Tester", 200M);

        _sut.Korting = Korting.Extra;
        _sut.Betaal(100);

        Assert.AreEqual(111, _sut.Saldo);
    }

    [TestMethod]
    public void Betaal_ValidAmount_VIPKorting_ReturnsCorrectly()
    {
        var _sut = new VIPKaart("Tester", 200M);

        _sut.Korting = Korting.VIPKorting;
        _sut.Betaal(100);

        Assert.AreEqual(112.5M, _sut.Saldo);
    }
}
