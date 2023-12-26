using System;

class Program
{
    static void Main()
    {
        Console.Write("Adja meg az m értékét: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Adja meg az n értékét: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Adja meg az p értékét: ");
        int p = int.Parse(Console.ReadLine());

        int[,] A = new int[m, n];
        int[,] B = new int[n, p];
        int[,] C = new int[m, p];
        Random random = new Random();

        // Mátrix A feltöltése véletlenszerűen
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                A[i, j] = random.Next(-10, 11); // [-10, 10] közötti véletlenszerű számok
            }
        }

        // Mátrix B feltöltése véletlenszerűen
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < p; j++)
            {
                B[i, j] = random.Next(-10, 11); // [-10, 10] közötti véletlenszerű számok
            }
        }

        // Mátrix C kiszámítása (A*B)
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < p; j++)
            {
                C[i, j] = 0;
                for (int k = 0; k < n; k++)
                {
                    C[i, j] += A[i, k] * B[k, j];
                }
            }
        }

        // Eredmény kiírása
        Console.WriteLine("Mátrix A:");
        PrintMatrix(A, m, n);

        Console.WriteLine("Mátrix B:");
        PrintMatrix(B, n, p);

        Console.WriteLine("Mátrix C (A*B):");
        PrintMatrix(C, m, p);

        Console.ReadLine();
    }

    static void PrintMatrix(int[,] matrix, int rows, int cols)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}