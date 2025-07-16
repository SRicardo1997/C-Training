namespace _10_Record.Test
{
    [TestClass]
    public sealed class ProdctTest
    {
        [TestMethod]
        public void Bruto_Alcohol_5Procent_ReturnCorrectValue()
        {
            var _sut = new AlcoholHoudend(5);

            Assert.AreEqual(6.3M, _sut.BrutoPrijs(5));
        }

        [TestMethod]
        public void Bruto_Alcohol_40Procent_ReturnCorrectValue()
        {
            var _sut = new AlcoholHoudend(40);

            Assert.AreEqual(48.3M, _sut.BrutoPrijs(30));
        }

        [TestMethod]
        public void Bruto_Suiker_200gramSuiker_ReturnCorrectValue()
        {
            var _sut = new SuikerHoudend(200);

            Assert.AreEqual(11.62M, _sut.BrutoPrijs(7));
        }

        [TestMethod]
        public void Bruto_Overig_ReturnCorrectValue()
        {
            var _sut = new Overig();

            Assert.AreEqual(105M, _sut.BrutoPrijs(100));
        }


    }
}
