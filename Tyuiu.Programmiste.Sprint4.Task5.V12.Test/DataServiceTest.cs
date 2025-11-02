
using Tyuiu.Programmiste.Sprint4.Task5.V12.Lib;
namespace Tyuiu.Programmiste.Sprint4.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            // Arrange
            DataService ds = new DataService();
            int[,] matrix = {
                { -1, 2, -3, 4, -5 },
                { 0, -2, 3, -4, 1 },
                { -6, 4, -1, 2, -3 },
                { 3, -5, 2, -2, 4 },
                { -4, 1, -1, 3, -2 }
            };

            // Act
            int result = ds.Calculate(matrix);

            // Assert
            // 13 éléments négatifs dans cette matrice
            int wait = 13;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void Calculate_WithNoNegativeElements_ReturnsZero()
        {
            // Arrange
            DataService ds = new DataService();
            int[,] matrix = {
                { 0, 1, 2, 3, 4 },
                { 1, 2, 3, 4, 0 },
                { 2, 3, 4, 0, 1 },
                { 3, 4, 0, 1, 2 },
                { 4, 0, 1, 2, 3 }
            };

            // Act
            int result = ds.Calculate(matrix);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Calculate_WithAllNegativeElements_ReturnsTotalCount()
        {
            // Arrange
            DataService ds = new DataService();
            int[,] matrix = {
                { -1, -2, -3 },
                { -4, -5, -6 },
                { -1, -2, -3 }
            };

            // Act
            int result = ds.Calculate(matrix);

            // Assert
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_WithNullMatrix_ThrowsException()
        {
            // Arrange
            DataService ds = new DataService();
            int[,] matrix = null;

            // Act
            ds.Calculate(matrix);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_WithEmptyMatrix_ThrowsException()
        {
            // Arrange
            DataService ds = new DataService();
            int[,] matrix = new int[0, 0];

            // Act
            ds.Calculate(matrix);
        }

        [TestMethod]
        public void Calculate_WithMixedElements_ReturnsCorrectCount()
        {
            // Arrange
            DataService ds = new DataService();
            int[,] matrix = {
                { -1, 2, -3 },
                { 4, -5, 6 },
                { -7, 8, -9 }
            };

            // Act
            int result = ds.Calculate(matrix);

            // Assert
            // Éléments négatifs: -1, -3, -5, -7, -9 = 5 éléments
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Calculate_WithZeros_ReturnsZeroForZeros()
        {
            // Arrange
            DataService ds = new DataService();
            int[,] matrix = {
                { 0, -1, 0 },
                { -2, 0, -3 },
                { 0, -4, 0 }
            };

            // Act
            int result = ds.Calculate(matrix);

            // Assert
            // Éléments négatifs: -1, -2, -3, -4 = 4 éléments (les zéros ne comptent pas)
            Assert.AreEqual(4, result);
        }
    }
}
