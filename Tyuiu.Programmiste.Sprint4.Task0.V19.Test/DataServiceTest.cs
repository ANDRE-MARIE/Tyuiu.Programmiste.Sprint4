using Tyuiu.Programmiste.Sprint4.Task0.V19.Lib;
namespace Tyuiu.Programmiste.Sprint4.Task0.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCal()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };

            // Act
            int result = ds.GetMultOddArrEl(array);

            // Assert
            // Calcul manuel: 9 × 5 × 7 × 5 × 3 × 7 × 9 × 1 = 297675
            int wait = 297675;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void GetMultOddArrEl_WithNoOddElements_ReturnsZero()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { 2, 4, 6, 8, 10 };

            // Act
            int result = ds.GetMultOddArrEl(array);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void GetMultOddArrEl_WithOneOddElement_ReturnsThatElement()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { 2, 4, 7, 8, 10 };

            // Act
            int result = ds.GetMultOddArrEl(array);

            // Assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void GetMultOddArrEl_WithEmptyArray_ThrowsException()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { };

            // Act & Assert
            Assert.ThrowsException<System.ArgumentException>(() => ds.GetMultOddArrEl(array));
        }

        [TestMethod]
        public void GetMultOddArrEl_WithNullArray_ThrowsException()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = null;

            // Act & Assert
            Assert.ThrowsException<System.ArgumentException>(() => ds.GetMultOddArrEl(array));
        }

        [TestMethod]
        public void GetMultOddArrEl_WithAllOddElements_ReturnsCorrectProduct()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { 1, 3, 5 };

            // Act
            int result = ds.GetMultOddArrEl(array);

            // Assert
            Assert.AreEqual(15, result); // 1 × 3 × 5 = 15
        }

        [TestMethod]
        public void GetMultOddArrEl_WithZeroInArray_ReturnsCorrectProduct()
        {
            // Arrange
            DataService ds = new DataService();
            int[] array = { 1, 0, 3, 0, 5 };

            // Act
            int result = ds.GetMultOddArrEl(array);

            // Assert
            Assert.AreEqual(15, result); // 1 × 3 × 5 = 15 (les zéros sont pairs donc ignorés)
        }
    }
}
