namespace App.Test
{
    [TestClass]
    public sealed class BalkTest
    {
        [TestMethod]
        public void BerekenOppervlakte_valideWaardes_ReturnCorrectOppervlalkte()
        {
            IVorm _sut = new Balk(2, 3, 2);

            Assert.AreEqual(6, _sut.BerekenOppervlakte());
        }

        [TestMethod]
        public void BerekenInhoud_valideWaardes_ReturnCorrectInhoud()
        {
            IVorm _sut = new Balk(2, 3, 2);

            Assert.AreEqual(12, _sut.BerekenInhoud());
        }
    }
}
