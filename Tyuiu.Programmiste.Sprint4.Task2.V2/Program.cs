using Tyuiu.Programmiste.Sprint4.Task2.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* TASK: CALCUL DU PRODUIT DES ÉLÉMENTS IMPAIRS DU TABLEAU                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Le tableau de 11 éléments (valeurs entre 1 et 8) :                     *");
        Console.WriteLine("* Génération de nombres aléatoires...                                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine();

        DataService ds = new DataService();

        // Génération du tableau de 11 éléments avec valeurs aléatoires entre 1 et 8
        int[] array = GenerateRandomArray(11, 1, 8);

        Console.WriteLine("Tableau généré aléatoirement:");
        PrintArray(array);
        Console.WriteLine();

        try
        {
            int result = ds.Calculate(array);

            Console.WriteLine("Éléments impairs du tableau:");
            PrintOddElements(array);
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* RÉSULTAT:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Produit des éléments impairs = {result}");
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

    // Méthode pour générer un tableau aléatoire
    static int[] GenerateRandomArray(int length, int minValue, int maxValue)
    {
        Random random = new Random();
        int[] array = new int[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(minValue, maxValue + 1);
        }

        return array;
    }

    static void PrintArray(int[] array)
    {
        Console.Write("{ ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i < array.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine(" }");
    }

    static void PrintOddElements(int[] array)
    {
        Console.Write("{ ");
        bool first = true;
        foreach (int num in array)
        {
            if (num % 2 != 0)
            {
                if (!first)
                    Console.Write(" × ");
                Console.Write(num);
                first = false;
            }
        }

        // Si aucun élément impair
        if (first)
            Console.Write("Aucun élément impair");

        Console.WriteLine(" }");
    }

    static void PrintCalculationDetails(int[] array)
    {
        int product = 1;
        bool first = true;
        bool hasOdd = false;

        foreach (int num in array)
        {
            if (num % 2 != 0)
            {
                if (!first)
                    Console.Write(" × ");
                Console.Write(num);
                product *= num;
                first = false;
                hasOdd = true;
            }
        }

        if (hasOdd)
            Console.WriteLine($" = {product}");
        else
            Console.WriteLine("Aucun élément impair à multiplier");
    }
}

