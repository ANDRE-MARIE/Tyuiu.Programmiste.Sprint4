using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.Programmiste.Sprint4.Task6.V9.Lib
{
    public class DataService : ISprint4Task6V9
    {
        public int Calculate(string[] array)
        {
            if (array == null)
                throw new ArgumentException("Le tableau ne peut pas être null");

            if (array.Length == 0)
                throw new ArgumentException("Le tableau ne peut pas être vide");

            int count = 0;

            // Utiliser la classe Array pour parcourir et compter
            foreach (string str in array)
            {
                if (str.Length < 7)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
    