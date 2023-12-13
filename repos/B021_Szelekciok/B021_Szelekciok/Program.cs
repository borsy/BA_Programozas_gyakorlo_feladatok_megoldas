using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg egy számot: ");
        int szam = Convert.ToInt32(Console.ReadLine());

        if (szam == 0)
        {
            Console.WriteLine("A megadott szám nulla.");
        }
        else if (szam % 2 == 0)
        {
            Console.WriteLine("A megadott szám páros.");
        }
        else
        {
            Console.WriteLine("A megadott szám páratlan.");
        }

        Console.ReadLine();
    }
}