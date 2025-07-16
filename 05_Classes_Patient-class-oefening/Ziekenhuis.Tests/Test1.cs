namespace Ziekenhuis.Tests
{
    [TestClass]
    public sealed class Test1
    {

        private Patient _sut = null!;
        [TestInitialize]
        public void Initialize()
        {
            // Arrange 
            _sut = new Patient();
        }

        [TestMethod]
        public void HaalMedicijnenOp_ReturnJuisteMedicijn()
        {
            // Arrange 
            _sut = new Patient(Medicijnen.Omeprazol);
            
            // Act
            Medicijnen[] expected = { Medicijnen.Omeprazol };
            var actual = _sut.Medicijnen;

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Slik_VoegMedicijnToe()
        {
            Medicijnen[] medicijnen = { Medicijnen.Diclofenac, Medicijnen.Omeprazol };
            _sut.Slik(medicijnen);

            CollectionAssert.AreEqual(medicijnen, _sut.Medicijnen);
        }

        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void MeerDan3Medicijnen_Exception()
        {
            Medicijnen[] medicijnen = 
            {
                Medicijnen.Diclofenac, 
                Medicijnen.Omeprazol, 
                Medicijnen.Ibuprofen,
                Medicijnen.Metaprolol,
            };
            _sut.Slik(medicijnen);
        }
    }
}
