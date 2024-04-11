namespace TableauxMultidimensionnels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Déclaration et initialisation du tableau uniforme
            int[,] tableauUniforme = {
            { 1, 2, 3 },
            { 2, 3, 4 },
            { 3, 4, 5 }
        };

            // Déclaration du tableau irrégulier
            int[][] tableauIrregulier = new int[3][];

            // Remplissage du tableau irrégulier en retirant un élément à chaque ligne
            for (int i = 0; i < tableauUniforme.GetLength(0); i++)
            {
                // Initialisation du tableau irrégulier à la taille de la ligne correspondante dans le tableau uniforme moins i
                tableauIrregulier[i] = new int[tableauUniforme.GetLength(1) - i];

                // Remplissage du tableau irrégulier avec les éléments du tableau uniforme
                for (int j = 0; j < tableauIrregulier[i].Length; j++)
                {
                    tableauIrregulier[i][j] = tableauUniforme[i, j+i];
                }
            }

            // Affichage du tableau irrégulier
            Console.WriteLine("Tableau irrégulier :");
            for (int i = 0; i < tableauIrregulier.Length; i++)
            {
                Console.Write($"[{i} => [");
                for (int j = 0; j < tableauIrregulier[i].Length; j++)
                {
                    Console.Write($"{tableauIrregulier[i][j]}");
                    if (j < tableauIrregulier[i].Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("]]");
            }
        }
    }
}
