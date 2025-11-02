using Tyuiu.Programmiste.Sprint4.Task7.V1.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* TASK: CONVERSION CHAÎNE → MATRICE 3x3 ET COMPTAGE DES NOMBRES PAIRS   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Chaîne d'origine : « 135792468 »                                       *");
        Console.WriteLine("* Dimensions de la matrice : 3x3                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine();

        DataService ds = new DataService();

        string value = "135792468";
        int n = 3; // nombre de lignes
        int m = 3; // nombre de colonnes

        Console.WriteLine($"Chaîne d'entrée: \"{value}\"");
        Console.WriteLine($"Dimensions de la matrice: {n}x{m}");
        Console.WriteLine();

        try
        {
            // Convertir la chaîne en matrice pour l'affichage
            int[,] matrix = ConvertStringToMatrix(n, m, value);

            Console.WriteLine("Matrice 3x3 générée:");
            PrintMatrix(matrix);
            Console.WriteLine();

            Console.WriteLine("Nombres pairs dans la matrice (marqués par *):");
            PrintEvenNumbers(matrix);
            Console.WriteLine();

            int result = ds.Calculate(n, m, value);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* RÉSULTAT:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Nombre de nombres pairs = {result}");
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

    // Méthode pour convertir la chaîne en matrice
    static int[,] ConvertStringToMatrix(int n, int m, string value)
    {
        int[,] matrix = new int[n, m];
        int index = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(value[index].ToString());
                index++;
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
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    // Méthode pour afficher les nombres pairs
    static void PrintEvenNumbers(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (matrix[i, j] % 2 == 0)
                {
                    Console.Write($"{matrix[i, j]}* ");
                }
                else
                {
                    Console.Write($"{matrix[i, j]}  ");
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
        int evenCount = 0;

        Console.Write("Nombres pairs trouvés: ");
        bool firstElement = true;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (matrix[i, j] % 2 == 0)
                {
                    if (!firstElement)
                        Console.Write(", ");
                    Console.Write(matrix[i, j]);
                    evenCount++;
                    firstElement = false;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Total des nombres pairs: {evenCount}");
    }
}
