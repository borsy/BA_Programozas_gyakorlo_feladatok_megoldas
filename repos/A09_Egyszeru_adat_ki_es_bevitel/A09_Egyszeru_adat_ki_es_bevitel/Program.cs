using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg a téglalap egyik oldalának hosszát (a): ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Kérem, adja meg a téglalap másik oldalának hosszát (b): ");
        double b = Convert.ToDouble(Console.ReadLine());

        double kerulet = 2 * (a + b);
        double terulet = a * b;

        Console.WriteLine($"A téglalap kerülete: {kerulet:F2}");
        Console.WriteLine($"A téglalap területe: {terulet:F2}");

        Console.ReadLine();
    }
}
