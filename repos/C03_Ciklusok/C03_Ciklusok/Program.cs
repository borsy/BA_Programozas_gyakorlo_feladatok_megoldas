using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg az első számot: ");
        int szam1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Kérem, adja meg a második számot: ");
        int szam2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Az {szam1} és {szam2} közötti páros számok:");

        for (int i = szam1; i <= szam2; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadLine();
    }
}