using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg a téglatest egyik oldalának hosszát (a): ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Kérem, adja meg a téglatest második oldalának hosszát (b): ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Kérem, adja meg a téglatest harmadik oldalának hosszát (c): ");
        double c = Convert.ToDouble(Console.ReadLine());

        double felszin = 2 * (a * b + a * c + b * c);
        double terfogat = a * b * c;

        Console.WriteLine($"A téglatest felszíne: {felszin:F3}");
        Console.WriteLine($"A téglatest térfogata: {terfogat:F3}");

        Console.ReadLine();
    }
}