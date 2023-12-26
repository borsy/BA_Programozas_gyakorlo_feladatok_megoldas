using System;

class Program
{
    static void Main()
    {
        Console.Write("Adja meg az n értékét (3-10): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Adja meg az m értékét (3-10): ");
        int m = int.Parse(Console.ReadLine());

        if (n < 3 || n > 10 || m < 3 || m > 10)
        {
            Console.WriteLine("Hibás bemenet. Az n és m értéke 3 és 10 között kell legyen!");
            Console.ReadLine();
            return;
        }

        int[,] matrix = new int[n, m];
        Random random = new Random();

        // Mátrix feltöltése véletlenszerűen 3 és 10 közötti értékekkel
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = random.Next(3, 11);
            }
        }

        // Mátrix kiírása
        Console.WriteLine("Eredeti mátrix:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Transzponált mátrix létrehozása és kiírása
        Console.WriteLine("Transzponált mátrix:");
        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}