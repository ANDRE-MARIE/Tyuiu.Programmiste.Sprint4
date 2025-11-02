using Tyuiu.Programmiste.Sprint4.Task0.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* TASK: CALCUL DU PRODUIT DES ÉLÉMENTS IMPAIRS DU TABLEAU                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Le tableau fixe: {9, 5, 7, 4, 5, 3, 7, 8, 9, 1}                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine();

        DataService ds = new DataService();
        int[] array = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };

        Console.WriteLine("Tableau d'origine:");
        PrintArray(array);
        Console.WriteLine();

        try
        {
            int result = ds.GetMultOddArrEl(array);

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

        Console.ReadKey();
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
        Console.WriteLine(" }");
    }

    static void PrintCalculationDetails(int[] array)
    {
        int product = 1;
        bool first = true;

        foreach (int num in array)
        {
            if (num % 2 != 0)
            {
                if (!first)
                    Console.Write(" × ");
                Console.Write(num);
                product *= num;
                first = false;
            }
        }

        Console.WriteLine($" = {product}");
    }
}
