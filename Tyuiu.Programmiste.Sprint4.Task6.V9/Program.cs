using Tyuiu.Programmiste.Sprint4.Task6.V9.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* TASK: COMPTAGE DES CHAÎNES DE LONGUEUR < 7                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Tableau de couleurs : [\"Rouge\", \"Orange\", \"Jaune\", \"Vert\", \"Bleu\", \"Indigo\", \"Violet\"] *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine();

        DataService ds = new DataService();

        // Tableau fixe de couleurs
        string[] colorsArray = { "Rouge", "Orange", "Jaune", "Vert", "Bleu", "Indigo", "Violet" };

        Console.WriteLine("Tableau de couleurs complet:");
        PrintArray(colorsArray);
        Console.WriteLine();

        Console.WriteLine("Analyse des longueurs des chaînes:");
        PrintLengthAnalysis(colorsArray);
        Console.WriteLine();

        try
        {
            int result = ds.Calculate(colorsArray);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* RÉSULTAT:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Nombre de chaînes avec longueur < 7 = {result}");
            Console.WriteLine("***************************************************************************");

            // Affichage détaillé du comptage
            Console.WriteLine();
            Console.WriteLine("Détail du comptage:");
            PrintCountingDetails(colorsArray);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erreur: {ex.Message}");
        }

        Console.WriteLine();
        Console.WriteLine("Appuyez sur une touche pour fermer cette fenêtre...");
        Console.ReadKey();
    }

    // Méthode pour afficher le tableau
    static void PrintArray(string[] array)
    {
        Console.Write("[ ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"\"{array[i]}\"");
            if (i < array.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine(" ]");
    }

    // Méthode pour analyser les longueurs
    static void PrintLengthAnalysis(string[] array)
    {
        Console.WriteLine("Chaîne".PadRight(10) + "Longueur".PadRight(10) + "Longueur < 7");
        Console.WriteLine(new string('-', 35));

        foreach (string str in array)
        {
            string lengthStatus = str.Length < 7 ? "OUI" : "NON";
            Console.WriteLine($"\"{str}\"".PadRight(10) + str.Length.ToString().PadRight(10) + lengthStatus);
        }
    }

    // Méthode pour afficher le détail du comptage
    static void PrintCountingDetails(string[] array)
    {
        int count = 0;
        bool firstElement = true;

        Console.Write("Chaînes avec longueur < 7: ");

        foreach (string str in array)
        {
            if (str.Length < 7)
            {
                if (!firstElement)
                    Console.Write(", ");
                Console.Write($"\"{str}\"");
                count++;
                firstElement = false;
            }
        }

        if (count == 0)
        {
            Console.Write("Aucune chaîne trouvée");
        }

        Console.WriteLine();
        Console.WriteLine($"Total: {count} chaîne(s)");
    }
}
