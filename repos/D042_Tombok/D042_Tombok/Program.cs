using System;

class Program
{
    static void Main()
    {
        Console.Write("Adja meg a tömb méretét (N): ");
        int N = int.Parse(Console.ReadLine());

        int[] eredetiTomb = new int[N];
        int[] parosTomb;

        Random random = new Random();

        // Tömb feltöltése véletlenszerű egész számokkal 1 és 100 között
        for (int i = 0; i < N; i++)
        {
            eredetiTomb[i] = random.Next(1, 101);
        }

        Console.WriteLine("Eredeti tömb elemei:");
        foreach (var szam in eredetiTomb)
        {
            Console.Write(szam + " ");
        }
        Console.WriteLine();

        int parosDb = 0;

        // Páros számok számolása és másolása
        for (int i = 0; i < N; i++)
        {
            if (eredetiTomb[i] % 2 == 0)
            {
                parosDb++;
            }
        }

        parosTomb = new int[parosDb];
        int parosIndex = 0;

        for (int i = 0; i < N; i++)
        {
            if (eredetiTomb[i] % 2 == 0)
            {
                parosTomb[parosIndex] = eredetiTomb[i];
                parosIndex++;
            }
        }

        Console.WriteLine("Páros számok másolt tömb elemei:");
        foreach (var szam in parosTomb)
        {
            Console.Write(szam + " ");
        }
        Console.WriteLine();

        Console.ReadLine();
    }
}