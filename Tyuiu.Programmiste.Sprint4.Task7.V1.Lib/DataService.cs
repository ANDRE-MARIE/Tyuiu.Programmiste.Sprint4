
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.Programmiste.Sprint4.Task7.V1.Lib
{
    public class DataService : ISprint4Task7V1
    {
        public int Calculate(int n, int m, string value)
        {
            // Validation des paramètres
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("La chaîne ne peut pas être null ou vide");

            if (n <= 0 || m <= 0)
                throw new ArgumentException("Les dimensions de la matrice doivent être positives");

            if (value.Length != n * m)
                throw new ArgumentException($"La longueur de la chaîne ({value.Length}) ne correspond pas aux dimensions de la matrice ({n}x{m} = {n * m})");

            // Convertir la chaîne en matrice
            int[,] matrix = new int[n, m];
            int evenCount = 0;
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // Convertir chaque caractère en nombre
                    matrix[i, j] = int.Parse(value[index].ToString());

                    // Compter les nombres pairs
                    if (matrix[i, j] % 2 == 0)
                    {
                        evenCount++;
                    }

                    index++;
                }
            }

            return evenCount;
        }
    }
}
        