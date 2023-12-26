using System;

class Program
{
    static void Main()
    {
        int[] tomb = new int[10];
        Random random = new Random();

        // Tömb feltöltése véletlenszerű egész számokkal 1 és 100 között
        for (int i = 0; i < 10; i++)
        {
            tomb[i] = random.Next(1, 101);
        }

        Console.WriteLine("Tömb elemei:");
        foreach (var szam in tomb)
        {
            Console.Write(szam + " ");
        }
        Console.WriteLine();

        int parosSzamok = 0;
        int paratlanSzamok = 0;

        foreach (var szam in tomb)
        {
            if (szam % 2 == 0)
            {
                parosSzamok++;
            }
            else
            {
                paratlanSzamok++;
            }
        }

        Console.WriteLine($"Páros számok száma: {parosSzamok}");
        Console.WriteLine($"Páratlan számok száma: {paratlanSzamok}");

        Console.ReadLine();
    }
}