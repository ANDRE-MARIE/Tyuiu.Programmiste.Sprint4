
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.Programmiste.Sprint4.Task5.V12.Lib
{
    public class DataService : ISprint4Task5V12
    {
        public int Calculate(int[,] matrix)
        {
            if (matrix == null)
                throw new ArgumentException("La matrice ne peut pas être null");

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            if (rows == 0 || columns == 0)
                throw new ArgumentException("La matrice ne peut pas être vide");

            int negativeCount = 0;

            // Parcourir tous les éléments de la matrice
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // Vérifier si l'élément est négatif
                    if (matrix[i, j] < 0)
                    {
                        negativeCount++;
                    }
                }
            }

            return negativeCount;
        }
    }
}
        
