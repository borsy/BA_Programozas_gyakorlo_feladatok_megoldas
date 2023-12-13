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
        else if (szam1 % szam2 == 0)
        {
            double eredmeny = szam1 / szam2;
            Console.WriteLine($"{szam1} osztója {szam2}-nek, az osztás eredménye: {eredmeny}");
        }
        else
        {
            Console.WriteLine($"{szam1} nem osztója {szam2}-nek.");
        }

        Console.ReadLine();
    }
}