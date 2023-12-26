using System;

class Program
{
    static void Main()
    {
        Console.Write("Adjon meg egy dátumot (éééé-hh-nn): ");
        string datumString = Console.ReadLine();

        if (DateTime.TryParse(datumString, out DateTime kezdoDatum))
        {
            DateTime negyHetesDatum = kezdoDatum.AddDays(28); // 4 hét = 4 * 7 nap
            Console.WriteLine($"A négy héttel későbbi dátum: {negyHetesDatum.ToString("yyyy-MM-dd")}");
        }
        else
        {
            Console.WriteLine("Hibás dátumformátum!");
        }

        Console.ReadLine();
    }
}