namespace App.Test;

[TestClass]
public sealed class KubusTest
{
    [TestMethod]
    public void BerekenOppervlakte_valideWaardes_ReturnCorrectOppervlalkte()
    {
        IVorm _sut = new Kubus(3);

        Assert.AreEqual(54, _sut.BerekenOppervlakte());
    }

    [TestMethod]
    public void BerekenInhoud_valideWaardes_ReturnCorrectInhoud()
    {
        IVorm _sut = new Kubus(3);

        Assert.AreEqual(27, _sut.BerekenInhoud());
    }
}
