using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg az a befogó hosszát: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Kérem, adja meg a b befogó hosszát: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

        Console.WriteLine($"A háromszög átfogója: {c:F2}");

        Console.ReadLine();
    }
}