using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg a kör sugarát (r): ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double pi = Math.PI;
        double kerulet = 2 * radius * pi;
        double terulet = Math.Pow(radius, 2) * pi;

        Console.WriteLine($"A kör kerülete: {kerulet:F4}");
        Console.WriteLine($"A kör területe: {terulet:F4}");

        Console.ReadLine();
    }
}