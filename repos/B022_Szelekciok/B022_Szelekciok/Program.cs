using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg egy számot: ");
        int szam = Convert.ToInt32(Console.ReadLine());

        if (szam % 3 == 0)
        {
            Console.WriteLine("Az adott szám osztható maradék nélkül 3-mal.");
        }
        else
        {
            Console.WriteLine("Az adott szám nem osztható maradék nélkül 3-mal.");
        }

        Console.ReadLine();
    }
}