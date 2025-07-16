namespace App.Test;

[TestClass]
public sealed class BolTest
{
    [TestMethod]
    public void BerekenOppervlakte_valideWaardes_ReturnCorrectOppervlalkte()
    {
        IVorm _sut = new Bol(3);

        Assert.AreEqual(28.0, _sut.BerekenOppervlakte(), 1);
    }

    [TestMethod]
    public void BerekenInhoud_valideWaardes_ReturnCorrectInhoud()
    {
        IVorm _sut = new Bol(3);

        Assert.AreEqual(113, _sut.BerekenInhoud(), 1);
    }

}
