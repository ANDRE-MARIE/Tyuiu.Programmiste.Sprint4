
using Tyuiu.Programmiste.Sprint4.Task1.V7.Lib;
namespace Tyuiu.Programmiste.Sprint4.Task1.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { 2, 5, 3, 8, 2, 6, 2, 5, 5, 7, 4 };

            // Act
            int result = ds.Calculate(array);

            // Assert
            // Calcul manuel: 2 + 8 + 2 + 6 + 2 + 4 = 24
            int wait = 24;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void Calculate_WithNoEvenElements_ReturnsZero()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { 1, 3, 5, 7, 9, 11 };

            // Act
            int result = ds.Calculate(array);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Calculate_WithAllEvenElements_ReturnsCorrectSum()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { 2, 4, 6, 8, 10 };

            // Act
            int result = ds.Calculate(array);

            // Assert
            Assert.AreEqual(30, result); // 2 + 4 + 6 + 8 + 10 = 30
        }

        [TestMethod]
        public void Calculate_WithMixedElements_ReturnsCorrectSum()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { 1, 2, 3, 4, 5, 6 };

            // Act
            int result = ds.Calculate(array);

            // Assert
            Assert.AreEqual(12, result); // 2 + 4 + 6 = 12
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_WithEmptyArray_ThrowsException()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { };

            // Act
            ds.Calculate(array);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_WithNullArray_ThrowsException()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = null;

            // Act
            ds.Calculate(array);
        }

        [TestMethod]
        public void Calculate_WithZeros_ReturnsZero()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { 0, 0, 0, 1, 3, 5 };

            // Act
            int result = ds.Calculate(array);

            // Assert
            Assert.AreEqual(0, result); // 0 + 0 + 0 = 0
        }

        [TestMethod]
        public void Calculate_WithNegativeEvenNumbers_ReturnsCorrectSum()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { -2, 4, -6, 8, 1, 3 };

            // Act
            int result = ds.Calculate(array);

            // Assert
            Assert.AreEqual(4, result); // -2 + 4 + (-6) + 8 = 4
        }
    }
}