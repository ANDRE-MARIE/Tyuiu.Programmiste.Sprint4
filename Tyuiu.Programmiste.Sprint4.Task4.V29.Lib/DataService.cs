using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.Programmiste.Sprint4.Task4.V29.Lib
{
    public class DataService : ISprint4Task4V29
    {
        public int Calculate(int[,] matrix)
        {
            if (matrix == null)
                throw new ArgumentException("La matrice ne peut pas être null");

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            if (rows == 0 || columns == 0)
                throw new ArgumentException("La matrice ne peut pas être vide");

            int sum = 0;

            // Parcourir tous les éléments de la matrice
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // Vérifier si l'élément est pair
                    if (matrix[i, j] % 2 == 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            return sum;
        }
    }
}