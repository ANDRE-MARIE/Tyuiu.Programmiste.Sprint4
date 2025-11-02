
using Tyuiu.Programmiste.Sprint4.Task4.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* TASK: CALCUL DE LA SOMME DES ÉLÉMENTS PAIRS DE LA MATRICE 5x5         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Matrice 5x5 fixe :                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            DataService ds = new DataService();

            // Matrice fixe 5x5
            int[,] matrix = {
                { 5, 6, 5, 6, 5 },
                { 5, 5, 5, 8, 4 },
                { 8, 5, 5, 8, 8 },
                { 6, 5, 4, 4, 8 },
                { 8, 5, 6, 8, 8 }
            };

            Console.WriteLine("Matrice 5x5 complète:");
            PrintMatrix(matrix);
            Console.WriteLine();

            // VÉRIFICATION DU CALCUL - DÉBOGAGE
            DebugCalculation(matrix);

            Console.WriteLine("Éléments pairs de la matrice:");
            PrintEvenElements(matrix);
            Console.WriteLine();

            try
            {
                int result = ds.Calculate(matrix);

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* RÉSULTAT:                                                              *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine($"Somme des éléments pairs = {result}");
                Console.WriteLine("***************************************************************************");

                // Affichage détaillé du calcul
                Console.WriteLine();
                Console.WriteLine("Détail du calcul:");
                PrintCalculationDetails(matrix);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur: {ex.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("Appuyez sur une touche pour fermer cette fenêtre...");
            Console.ReadKey();
        }

        // MÉTHODE 1: Affichage de la matrice complète
        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // MÉTHODE 2: Débogage détaillé
        static void DebugCalculation(int[,] matrix)
        {
            Console.WriteLine("DÉBOGAGE - Calcul détaillé:");
            Console.WriteLine("============================");

            int totalSum = 0;
            int rowSum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                rowSum = 0;
                Console.Write($"Ligne {i}: ");

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        Console.Write($"{matrix[i, j]} ");
                        rowSum += matrix[i, j];
                    }
                    else
                    {
                        Console.Write("_ ");
                    }
                }

                Console.WriteLine($"= {rowSum}");
                totalSum += rowSum;
            }

            Console.WriteLine($"============================");
            Console.WriteLine($"TOTAL: {totalSum}");
            Console.WriteLine();
        }

        // MÉTHODE 3: Affichage des éléments pairs seulement
        static void PrintEvenElements(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            bool firstElement = true;

            Console.Write("{ ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        if (!firstElement)
                            Console.Write(", ");
                        Console.Write(matrix[i, j]);
                        firstElement = false;
                    }
                }
            }
            Console.WriteLine(" }");
        }

        // MÉTHODE 4: Détail du calcul avec opérateurs
        static void PrintCalculationDetails(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int sum = 0;
            bool firstElement = true;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        if (!firstElement)
                            Console.Write(" + ");
                        Console.Write(matrix[i, j]);
                        sum += matrix[i, j];
                        firstElement = false;
                    }
                }
            }

            Console.WriteLine($" = {sum}");
        }
    }
}