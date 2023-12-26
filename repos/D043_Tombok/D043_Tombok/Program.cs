using System;

class Program
{
    static void Main()
    {
        Console.Write("Adja meg a tömb méretét (N): ");
        int N = int.Parse(Console.ReadLine());

        int[] tomb = new int[N];
        Random random = new Random();

        // Tömb feltöltése véletlenszerű egész számokkal 1 és 100 között
        for (int i = 0; i < N; i++)
        {
            tomb[i] = random.Next(1, 101);
        }

        Console.WriteLine("Tömb elemei:");
        foreach (var szam in tomb)
        {
            Console.Write(szam + " ");
        }
        Console.WriteLine();

        int parosDb = 0;

        // Páros számok számolása és kiírása
        Console.Write("Páros számok: ");
        foreach (var szam in tomb)
        {
            if (szam % 2 == 0)
            {
                Console.Write(szam + " ");
                parosDb++;
            }
        }
        Console.WriteLine();
        Console.WriteLine($"A tömbben {parosDb} darab páros szám található.");

        Console.ReadLine();
    }
}