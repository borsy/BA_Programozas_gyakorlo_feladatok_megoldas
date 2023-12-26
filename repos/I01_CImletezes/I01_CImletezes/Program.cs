using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg az összeget: ");
        int osszeg = Convert.ToInt32(Console.ReadLine());

        if (osszeg <= 0)
        {
            Console.WriteLine("Az összegnek pozitívnak kell lennie.");
        }
        else
        {
            Console.WriteLine($"Az összeget a lehető legkevesebb címletű pénzekkel összeállítva:");

            int[] cimletek = { 500, 100, 50, 20, 10, 5, 1 };

            foreach (int cimlet in cimletek)
            {
                int darab = osszeg / cimlet;
                if (darab > 0)
                {
                    Console.WriteLine($"{darab} darab {cimlet}-es címletű pénz");
                    osszeg -= darab * cimlet;
                }
            }
        }

        Console.ReadLine();
    }
}