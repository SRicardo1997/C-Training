namespace Dag09Opdrachten.Tests
{
    [TestClass]
    public sealed class Test1
    {


        [TestMethod]
        public void TelElementen_EmptyArray_ReturnsLengthOfZero()
        {
            ArrayLibrary _sut = new ArrayLibrary();
            int[] getallen = Array.Empty<int>();

            Assert.AreEqual(0, _sut.TelElementen(getallen));
        }

        [TestMethod]
        public void TelElementen_ArrayWithString_ReturnCorrectAmountOfElements()
        {
            var _sut = new ArrayLibrary();

            string[] woorden= {"Aap", "Koe", "Hond"};

            Assert.AreEqual(3, _sut.TelElementen(woorden));
        }

        [TestMethod]
        public void TelElementen_ArrayWithInt_ReturnsCorrectAmountOfElement()
        {
            var _sut = new ArrayLibrary();

            int[] getallen = {10, 3, 5, 2, 5 };

            Assert.AreEqual(5, _sut.TelElementen(getallen));
        }
    }
}
