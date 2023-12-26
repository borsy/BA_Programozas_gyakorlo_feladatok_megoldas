using System;

class Program
{
    static void Main()
    {
        Console.Write("Adja meg a mátrix méretét (n): ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        Random random = new Random();

        // Mátrix feltöltése véletlenszerűen 1 és 100 közötti értékekkel
        // Az átlóban csak nullák vannak
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    matrix[i, j] = 0;
                }
                else
                {
                    matrix[i, j] = random.Next(1, 101);
                }
            }
        }

        // Mátrix kiírása
        Console.WriteLine("Az eredmény mátrix:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j].ToString().PadLeft(3) + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}