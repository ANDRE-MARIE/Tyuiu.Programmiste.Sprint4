using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.Programmiste.Sprint4.Task3.V25.Lib
{
    public class DataService : ISprint4Task3V25
    {
        public int Calculate(int[,] array)
        {
            if (array == null)
                throw new ArgumentException("Le tableau ne peut pas être null");

            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            if (rows == 0 || columns == 0)
                throw new ArgumentException("Le tableau ne peut pas être vide");

            // Vérifier que le tableau a au moins 4 colonnes (index 3 pour la 4ème colonne)
            if (columns < 4)
                throw new ArgumentException("Le tableau doit avoir au moins 4 colonnes");

            int product = 1;
            int fourthColumnIndex = 3; // 4ème colonne (index 3 en base 0)

            // Parcourir toutes les lignes de la 4ème colonne
            for (int i = 0; i < rows; i++)
            {
                product *= array[i, fourthColumnIndex];
            }

            return product;
        }
    }
}