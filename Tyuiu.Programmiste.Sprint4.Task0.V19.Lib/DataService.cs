using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.Programmiste.Sprint4.Task0.V19.Lib
{
    public class DataService : ISprint4Task0V19
    {
        public int GetMultOddArrEl(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Le tableau ne peut pas être null ou vide");

            int product = 1;
            bool hasOdd = false;

            // Parcourir le tableau et multiplier les éléments impairs
            foreach (int num in array)
            {
                if (num % 2 != 0) // Vérifier si le nombre est impair
                {
                    product *= num;
                    hasOdd = true;
                }
            }

            // Si aucun élément impair n'a été trouvé
            if (!hasOdd)
                return 0;

            return product;
        }
    }
}
       
