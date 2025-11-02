
using Tyuiu.Programmiste.Sprint4.Task6.V9.Lib;
namespace Tyuiu.Programmiste.Sprint4.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            // Arrange
            DataService ds = new DataService();
            string[] array = { "Rouge", "Orange", "Jaune", "Vert", "Bleu", "Indigo", "Violet" };

            // Act
            int result = ds.Calculate(array);

            // Assert
            // Chaînes avec longueur < 7: "Rouge"(5), "Jaune"(5), "Vert"(4), "Bleu"(4) = 4 éléments
            int wait = 4;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void Calculate_WithAllShortStrings_ReturnsTotalCount()
        {
            // Arrange
            DataService ds = new DataService();
            string[] array = { "Un", "Deux", "Trois", "Quatre", "Cinq" };

            // Act
            int result = ds.Calculate(array);

            // Assert
            // Toutes les chaînes ont moins de 7 caractères
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Calculate_WithAllLongStrings_ReturnsZero()
        {
            // Arrange
            DataService ds = new DataService();
            string[] array = { "Programmation", "Développement", "Application", "Console" };

            // Act
            int result = ds.Calculate(array);

            // Assert
            // Toutes les chaînes ont plus de 7 caractères
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_WithNullArray_ThrowsException()
        {
            // Arrange
            DataService ds = new DataService();
            string[] array = null;

            // Act
            ds.Calculate(array);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Calculate_WithEmptyArray_ThrowsException()
        {
            // Arrange
            DataService ds = new DataService();
            string[] array = new string[0];

            // Act
            ds.Calculate(array);
        }

        [TestMethod]
        public void Calculate_WithMixedLengths_ReturnsCorrectCount()
        {
            // Arrange
            DataService ds = new DataService();
            string[] array = { "A", "BB", "CCC", "DDDD", "EEEEE", "FFFFFF", "GGGGGGG", "HHHHHHHH" };

            // Act
            int result = ds.Calculate(array);

            // Assert
            // Chaînes avec longueur < 7: "A"(1), "BB"(2), "CCC"(3), "DDDD"(4), "EEEEE"(5), "FFFFFF"(6) = 6 éléments
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Calculate_WithExactLength7_ReturnsZeroForThose()
        {
            // Arrange
            DataService ds = new DataService();
            string[] array = { "1234567", "ABCDEFG", "7654321" };

            // Act
            int result = ds.Calculate(array);

            // Assert
            // Toutes les chaînes ont exactement 7 caractères (non inclus dans < 7)
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Calculate_WithEmptyStrings_CountsEmptyStrings()
        {
            // Arrange
            DataService ds = new DataService();
            string[] array = { "", "A", "Bonjour", "Test" };

            // Act
            int result = ds.Calculate(array);

            // Assert
            // Chaînes avec longueur < 7: ""(0), "A"(1), "Test"(4) = 3 éléments
            Assert.AreEqual(3, result);
        }
    }
}