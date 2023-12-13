using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg az első számot: ");
        double szam1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Kérem, adja meg a második számot: ");
        double szam2 = Convert.ToDouble(Console.ReadLine());

        double kulonbseg = Math.Abs(szam1 - szam2);

        Console.WriteLine($"A két szám különbsége: {kulonbseg}");

        Console.ReadLine();
    }
}