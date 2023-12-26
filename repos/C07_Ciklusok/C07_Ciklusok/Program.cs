using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg a számot: ");
        int szam = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Növekvő | Csökkenő");
        Console.WriteLine("------------------");

        for (int i = 0; i <= szam; i++)
        {
            int csokkeno = szam - i;
            Console.WriteLine($"{i,-7} | {csokkeno}");
        }

        Console.ReadLine();
    }
}