using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg az első egész számot (a): ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Kérem, adja meg a második egész számot (b): ");
        int b = Convert.ToInt32(Console.ReadLine());

        int osszeg = a + b;
        int kulonbseg = a - b;

        Console.WriteLine($"Az összegük: {osszeg}");
        Console.WriteLine($"A különbségük: {kulonbseg}");

        Console.ReadLine();
    }
}