using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg a kocka oldalhosszúságát (a): ");
        double a = Convert.ToDouble(Console.ReadLine());

        double felszin = 6 * Math.Pow(a, 2);
        double terfogat = Math.Pow(a, 3);

        Console.WriteLine($"A kocka felszíne: {felszin:F2}");
        Console.WriteLine($"A kocka térfogata: {terfogat:F2}");

        Console.ReadLine();
    }
}