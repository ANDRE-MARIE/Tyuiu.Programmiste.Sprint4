using Tyuiu.Programmiste.Sprint4.Task3.V25.Lib;
namespace Tyuiu.Programmiste.Sprint4.Task3.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            // Arrange
            DataService ds = new DataService();
            int[,] array = {
                { 7, 3, 5, 3, 6 },
                { 4, 6, 2, 5, 7 },
                { 2, 3, 3, 3, 5 },
                { 2, 7, 7, 6, 2 },
                { 6, 6, 4, 3, 6 }
            };

            // Act
            int result = ds.Calculate(array);

            // Assert
            // Calcul manuel: 3 × 5 × 3 × 6 × 3 = 810
            int wait = 810;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_WithNullArray_ThrowsException()
        {
            // Arrange
            DataService ds = new DataService();
            int[,] array = null;

            // Act
            ds.Calculate(array);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_WithEmptyArray_ThrowsException()
        {
            // Arrange
            DataService ds = new DataService();
            int[,] array = new int[0, 0];

            // Act
            ds.Calculate(array);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_WithInsufficientColumns_ThrowsException()
        {
            // Arrange
            DataService ds = new DataService();
            int[,] array = new int[5, 3]; // Seulement 3 colonnes

            // Act
            ds.Calculate(array);
        }

        [TestMethod]
        public void Calculate_WithDifferentMatrix_ReturnsCorrectProduct()
        {
            // Arrange
            DataService ds = new DataService();
            int[,] array = {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 }
            };

            // Act
            int result = ds.Calculate(array);

            // Assert
            // 4 × 9 × 14 = 504
            Assert.AreEqual(504, result);
        }

        [TestMethod]
        public void Calculate_WithOnes_ReturnsOne()
        {
            // Arrange
            DataService ds = new DataService();
            int[,] array = {
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 }
            };

            // Act
            int result = ds.Calculate(array);

            // Assert
            // 1 × 1 × 1 = 1
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Calculate_WithZeros_ReturnsZero()
        {
            // Arrange
            DataService ds = new DataService();
            int[,] array = {
                { 1, 2, 3, 0, 4 },
                { 5, 6, 7, 1, 8 },
                { 9, 10, 11, 2, 12 }
            };

            // Act
            int result = ds.Calculate(array);

            // Assert
            // 0 × 1 × 2 = 0
            Assert.AreEqual(0, result);
        }
    }
}