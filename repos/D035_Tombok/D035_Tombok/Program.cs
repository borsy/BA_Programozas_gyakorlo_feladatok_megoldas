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

        // Átlag számítása
        double atlag = SzamokAtlaga(tomb);

        Console.WriteLine("Tömb elemei:");
        foreach (var szam in tomb)
        {
            Console.Write(szam + " ");
        }
        Console.WriteLine();

        Console.WriteLine($"Az átlag: {atlag}");

        Console.WriteLine("Az átlagot meghaladó értékek:");
        foreach (var szam in tomb)
        {
            if (szam > atlag)
            {
                Console.Write(szam + " ");
            }
        }

        Console.ReadLine();
    }

    static double SzamokAtlaga(int[] tomb)
    {
        double osszeg = 0;

        foreach (var szam in tomb)
        {
            osszeg += szam;
        }

        return osszeg / tomb.Length;
    }
}