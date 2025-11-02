using System;
using Tyuiu.Programmiste.Sprint4.Task1.V7.Lib;

namespace Tyuiu.Programmiste.Sprint4.Task1.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* TASK: CALCUL DE LA SOMME DES ÉLÉMENTS PAIRS DU TABLEAU                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Le tableau fixe: {2, 5, 3, 8, 2, 6, 2, 5, 5, 7, 4}                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();

            DataService ds = new DataService();
            int[] array = { 2, 5, 3, 8, 2, 6, 2, 5, 5, 7, 4 };

            Console.WriteLine("Tableau d'origine:");
            PrintArray(array);
            Console.WriteLine();

            try
            {
                int result = ds.Calculate(array);

                Console.WriteLine("Éléments pairs du tableau:");
                PrintEvenElements(array);
                Console.WriteLine();

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* RÉSULTAT:                                                              *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine($"Somme des éléments pairs = {result}");
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

        static void PrintEvenElements(int[] array)
        {
            Console.Write("{ ");
            bool first = true;
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    if (!first)
                        Console.Write(" + ");
                    Console.Write(num);
                    first = false;
                }
            }
            Console.WriteLine(" }");
        }

        static void PrintCalculationDetails(int[] array)
        {
            int sum = 0;
            bool first = true;

            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    if (!first)
                        Console.Write(" + ");
                    Console.Write(num);
                    sum += num;
                    first = false;
                }
            }

            Console.WriteLine($" = {sum}");
        }
    }
}