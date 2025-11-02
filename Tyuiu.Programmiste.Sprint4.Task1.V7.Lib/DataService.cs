using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.Programmiste.Sprint4.Task1.V7.Lib
{
    public class DataService : ISprint4Task1V7
    {
        public int Calculate(int[] array)
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Le tableau ne peut pas être null ou vide");

            int sum = 0;

            // Parcourir le tableau et additionner les éléments pairs
            foreach (int num in array)
            {
                if (num % 2 == 0) // Vérifier si le nombre est pair
                {
                    sum += num;
                }
            }

            return sum;
        }
    }
}