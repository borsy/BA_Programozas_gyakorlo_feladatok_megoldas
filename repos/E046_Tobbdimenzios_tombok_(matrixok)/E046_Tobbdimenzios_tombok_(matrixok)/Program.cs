using System;

class Program
{
    static void Main()
    {
        int sorok = 4;
        int oszlopok = 7;
        double[,] tomb = new double[sorok, oszlopok];
        Random random = new Random();

        // Tömb feltöltése véletlenszerűen -1 és 1 között 2 tizedes pontossággal
        for (int i = 0; i < sorok; i++)
        {
            for (int j = 0; j < oszlopok; j++)
            {
                tomb[i, j] = Math.Round(random.NextDouble() * 2 - 1, 2);
            }
        }

        // Tömb elemeinek kiírása
        Console.WriteLine("A tömb elemei:");
        for (int i = 0; i < sorok; i++)
        {
            for (int j = 0; j < oszlopok; j++)
            {
                Console.Write(tomb[i, j].ToString("F2") + " ");
            }
            Console.WriteLine();
        }

        // Sorok összegének kiírása
        Console.WriteLine("Sorok összege:");
        for (int i = 0; i < sorok; i++)
        {
            double sorOsszeg = 0;
            for (int j = 0; j < oszlopok; j++)
            {
                sorOsszeg += tomb[i, j];
            }
            Console.WriteLine($"Sor {i + 1}: {sorOsszeg}");
        }

        // Oszlopok összegének kiírása
        Console.WriteLine("Oszlopok összege:");
        for (int j = 0; j < oszlopok; j++)
        {
            double oszlopOsszeg = 0;
            for (int i = 0; i < sorok; i++)
            {
                oszlopOsszeg += tomb[i, j];
            }
            Console.WriteLine($"Oszlop {j + 1}: {oszlopOsszeg}");
        }

        Console.ReadLine();
    }
}