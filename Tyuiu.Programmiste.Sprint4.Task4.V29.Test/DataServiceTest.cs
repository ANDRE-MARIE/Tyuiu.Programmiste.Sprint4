using Tyuiu.Programmiste.Sprint4.Task4.V29.Lib;
namespace Tyuiu.Programmiste.Sprint4.Task4.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = {
        { 5, 6, 5, 6, 5 },
        { 5, 5, 5, 8, 4 },
        { 8, 5, 5, 8, 8 },
        { 6, 5, 4, 4, 8 },
        { 8, 5, 6, 8, 8 }
    };

            // Act - Calcul manuel
            int manualSum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        manualSum += matrix[i, j];
                    }
                }
            }

            // Act - Méthode du service
            int result = ds.Calculate(matrix);

            // Assert
            Assert.AreEqual(manualSum, result, "Le calcul automatique doit correspondre au calcul manuel");
            Assert.AreEqual(100, result, "Le résultat doit être 100 pour cette matrice");
        }
    }
}