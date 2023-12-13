using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg a négyzet oldalhosszát (a): ");
        double a = Convert.ToDouble(Console.ReadLine());

        double kerulet = 4 * a;
        double terulet = Math.Pow(a, 2);

        Console.WriteLine($"A négyzet kerülete: {kerulet:F2}");
        Console.WriteLine($"A négyzet területe: {terulet:F2}");

        Console.ReadLine();
    }
}