
using Tyuiu.Programmiste.Sprint4.Task3.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* TASK: CALCUL DU PRODUIT DES ÉLÉMENTS DE LA QUATRIÈME COLONNE           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Tableau 5x5 fixe :                                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine();

        DataService ds = new DataService();

        // Tableau fixe 5x5
        int[,] array = {
                { 7, 3, 5, 3, 6 },
                { 4, 6, 2, 5, 7 },
                { 2, 3, 3, 3, 5 },
                { 2, 7, 7, 6, 2 },
                { 6, 6, 4, 3, 6 }
            };

        Console.WriteLine("Tableau 5x5 complet:");
        PrintMatrix(array);
        Console.WriteLine();

        Console.WriteLine("Quatrième colonne (colonne index 3):");
        PrintFourthColumn(array);
        Console.WriteLine();

        try
        {
            int result = ds.Calculate(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* RÉSULTAT:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Produit des éléments de la 4ème colonne = {result}");
            Console.WriteLine("***************************************************************************");

            // Affichage détaillé du calcul
            Console.WriteLine();
            Console.WriteLine("Détail du calcul:");
            PrintCalculationDetails(array);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur: {ex.Message}");
        }

        Console.WriteLine();
        Console.WriteLine("Appuyez sur une touche pour fermer cette fenêtre...");
        Console.ReadKey();
    }

    static void PrintMatrix(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void PrintFourthColumn(int[,] array)
    {
        int rows = array.GetLength(0);
        int fourthColumnIndex = 3;

        Console.Write("{ ");
        for (int i = 0; i < rows; i++)
        {
            Console.Write(array[i, fourthColumnIndex]);
            if (i < rows - 1)
                Console.Write(", ");
        }
        Console.WriteLine(" }");
    }

    static void PrintCalculationDetails(int[,] array)
    {
        int rows = array.GetLength(0);
        int fourthColumnIndex = 3;
        int product = 1;

        for (int i = 0; i < rows; i++)
        {
            if (i > 0)
                Console.Write(" × ");
            Console.Write(array[i, fourthColumnIndex]);
            product *= array[i, fourthColumnIndex];
        }

        Console.WriteLine($" = {product}");
    }
}
