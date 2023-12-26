using System;

class Program
{
    static void Main()
    {
        int[] tomb = new int[10];
        Random random = new Random();

        // Tömb feltöltése véletlenszerű egész számokkal -50 és +50 között
        for (int i = 0; i < 10; i++)
        {
            tomb[i] = random.Next(-50, 51);
        }

        Console.WriteLine("Tömb elemei:");
        foreach (var szam in tomb)
        {
            Console.Write(szam + " ");
        }
        Console.WriteLine();

        int pozitivSzamok = 0;
        int negativSzamok = 0;
        int nullaErtekek = 0;

        foreach (var szam in tomb)
        {
            if (szam > 0)
            {
                pozitivSzamok++;
            }
            else if (szam < 0)
            {
                negativSzamok++;
            }
            else
            {
                nullaErtekek++;
            }
        }

        Console.WriteLine($"Pozitív számok száma: {pozitivSzamok}");
        Console.WriteLine($"Negatív számok száma: {negativSzamok}");
        Console.WriteLine($"Nulla értékek száma: {nullaErtekek}");

        Console.ReadLine();
    }
}