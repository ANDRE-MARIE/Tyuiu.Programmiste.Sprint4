using Tyuiu.Programmiste.Sprint4.Task5.V12.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* TASK: COMPTAGE DES ÉLÉMENTS NÉGATIFS DANS LA MATRICE 5x5              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Matrice 5x5 avec valeurs aléatoires entre -6 et 4                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine();

        DataService ds = new DataService();

        // Génération d'une matrice 5x5 avec valeurs aléatoires entre -6 et 4
        int[,] matrix = GenerateRandomMatrix(5, 5, -6, 4);

        Console.WriteLine("Matrice 5x5 générée aléatoirement:");
        PrintMatrix(matrix);
        Console.WriteLine();

        Console.WriteLine("Éléments négatifs de la matrice (marqués par *):");
        PrintNegativeElements(matrix);
        Console.WriteLine();

        try
        {
            int result = ds.Calculate(matrix);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* RÉSULTAT:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Nombre d'éléments négatifs = {result}");
            Console.WriteLine("***************************************************************************");

            // Affichage détaillé du comptage
            Console.WriteLine();
            Console.WriteLine("Détail du comptage:");
            PrintCountingDetails(matrix);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur: {ex.Message}");
        }

        Console.WriteLine();
        Console.WriteLine("Appuyez sur une touche pour fermer cette fenêtre...");
        Console.ReadKey();
    }

    // Méthode pour générer une matrice aléatoire
    static int[,] GenerateRandomMatrix(int rows, int columns, int minValue, int maxValue)
    {
        Random random = new Random();
        int[,] matrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = random.Next(minValue, maxValue + 1);
            }
        }

        return matrix;
    }

    // Méthode pour afficher la matrice
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matrix[i, j],3} "); // Formatage sur 3 caractères
            }
            Console.WriteLine();
        }
    }

    // Méthode pour afficher les éléments négatifs
    static void PrintNegativeElements(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (matrix[i, j] < 0)
                {
                    Console.Write($"{matrix[i, j]}* ");
                }
                else
                {
                    Console.Write($"{matrix[i, j],2}  ");
                }
            }
            Console.WriteLine();
        }
    }

    // Méthode pour afficher le détail du comptage
    static void PrintCountingDetails(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        int negativeCount = 0;

        Console.Write("Éléments négatifs trouvés: ");
        bool firstElement = true;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (matrix[i, j] < 0)
                {
                    if (!firstElement)
                        Console.Write(", ");
                    Console.Write(matrix[i, j]);
                    negativeCount++;
                    firstElement = false;
                }
            }
        }

        if (negativeCount == 0)
        {
            Console.Write("Aucun élément négatif");
        }

        Console.WriteLine();
        Console.WriteLine($"Total des éléments négatifs: {negativeCount}");
    }
}
