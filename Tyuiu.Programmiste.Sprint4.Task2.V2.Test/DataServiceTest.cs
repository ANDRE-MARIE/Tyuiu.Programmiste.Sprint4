using Tyuiu.Programmiste.Sprint4.Task2.V2.Lib;

namespace Tyuiu.Programmiste.Sprint4.Task2.V2.Test
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
            // Calcul manuel: 5 × 3 × 5 × 5 × 7 = 2625
            int wait = 2625;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void Calculate_WithNoOddElements_ReturnsZero()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { 2, 4, 6, 8, 2, 6, 2, 8, 4, 6, 2 };

            // Act
            int result = ds.Calculate(array);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Calculate_WithAllOddElements_ReturnsCorrectProduct()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { 1, 3, 5, 7, 1, 3, 5, 7, 1, 3, 5 };

            // Act
            int result = ds.Calculate(array);

            // Assert
            // 1 × 3 × 5 × 7 × 1 × 3 × 5 × 7 × 1 × 3 × 5
            Assert.AreEqual(165375, result);
        }

        [TestMethod]
        public void Calculate_WithMixedElements_ReturnsCorrectProduct()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };

            // Act
            int result = ds.Calculate(array);

            // Assert
            Assert.AreEqual(105, result); // 1 × 3 × 5 × 7 = 105
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
        public void Calculate_WithOneOddElement_ReturnsThatElement()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { 2, 4, 7, 8, 2, 4, 6, 8, 2, 4, 6 };

            // Act
            int result = ds.Calculate(array);

            // Assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Calculate_WithOnes_ReturnsOne()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { 1, 1, 1, 2, 4, 6, 1, 2, 4, 6, 1 };

            // Act
            int result = ds.Calculate(array);

            // Assert
            Assert.AreEqual(1, result); // 1 × 1 × 1 × 1 × 1 = 1
        }
    }
}