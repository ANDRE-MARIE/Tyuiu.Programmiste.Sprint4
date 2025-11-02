using Tyuiu.Programmiste.Sprint4.Task7.V1.Lib;

namespace Tyuiu.Programmiste.Sprint4.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            // Arrange
            DataService ds = new DataService();
            string value = "135792468";
            int n = 3;
            int m = 3;

            // Act
            int result = ds.Calculate(n, m, value);

            // Assert
            // Nombres pairs dans "135792468": 2, 4, 6, 8 = 4 éléments
            int wait = 4;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_WithNullString_ThrowsException()
        {
            // Arrange
            DataService ds = new DataService();
            string value = null;
            int n = 3;
            int m = 3;

            // Act
            ds.Calculate(n, m, value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_WithEmptyString_ThrowsException()
        {
            // Arrange
            DataService ds = new DataService();
            string value = "";
            int n = 3;
            int m = 3;

            // Act
            ds.Calculate(n, m, value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_WithInvalidDimensions_ThrowsException()
        {
            // Arrange
            DataService ds = new DataService();
            string value = "135792468";
            int n = 2;
            int m = 2; // 2x2 = 4, mais la chaîne a 9 caractères

            // Act
            ds.Calculate(n, m, value);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_WithZeroDimensions_ThrowsException()
        {
            // Arrange
            DataService ds = new DataService();
            string value = "123";
            int n = 0;
            int m = 3;

            // Act
            ds.Calculate(n, m, value);
        }

        [TestMethod]
        public void Calculate_WithAllEvenNumbers_ReturnsTotalCount()
        {
            // Arrange
            DataService ds = new DataService();
            string value = "246802468";
            int n = 3;
            int m = 3;

            // Act
            int result = ds.Calculate(n, m, value);

            // Assert
            // Tous les nombres sont pairs
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void Calculate_WithAllOddNumbers_ReturnsZero()
        {
            // Arrange
            DataService ds = new DataService();
            string value = "135791357";
            int n = 3;
            int m = 3;

            // Act
            int result = ds.Calculate(n, m, value);

            // Assert
            // Aucun nombre pair
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Calculate_WithDifferentMatrixSize_ReturnsCorrectCount()
        {
            // Arrange
            DataService ds = new DataService();
            string value = "123456";
            int n = 2;
            int m = 3;

            // Act
            int result = ds.Calculate(n, m, value);

            // Assert
            // Nombres pairs: 2, 4, 6 = 3 éléments
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Calculate_WithSingleElement_ReturnsCorrectCount()
        {
            // Arrange
            DataService ds = new DataService();
            string value = "4";
            int n = 1;
            int m = 1;

            // Act
            int result = ds.Calculate(n, m, value);

            // Assert
            // Le seul élément est pair
            Assert.AreEqual(1, result);
        }
    }
}
