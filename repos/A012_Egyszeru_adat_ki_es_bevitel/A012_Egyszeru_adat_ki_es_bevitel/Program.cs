using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg a henger sugarát (r): ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Kérem, adja meg a henger magasságát (m): ");
        double m = Convert.ToDouble(Console.ReadLine());

        double pi = Math.PI;
        double terfogat = pi * Math.Pow(r, 2) * m;
        double felszin = 2 * pi * r * (r + m);

        Console.WriteLine($"A henger térfogata: {terfogat:F2}");
        Console.WriteLine($"A henger felszíne: {felszin:F2}");

        Console.ReadLine();
    }
}