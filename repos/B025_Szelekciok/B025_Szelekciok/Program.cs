using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg az első számot: ");
        double szam1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Kérem, adja meg a második számot: ");
        double szam2 = Convert.ToDouble(Console.ReadLine());

        if (szam2 == 0)
        {
            Console.WriteLine("Nullával nem lehet osztani!");
        }
        else
        {
            double eredmeny = Math.Round(Math.Max(szam1, szam2) / Math.Min(szam1, szam2), 2);
            Console.WriteLine($"Az eredmény: {eredmeny}");
        }

        Console.ReadLine();
    }
}