using System;

class Program
{
    static void Main()
    {
        Console.Write("Adjon meg egy dátumot (éééé-hh-nn): ");
        string datumString = Console.ReadLine();

        if (DateTime.TryParse(datumString, out DateTime datum))
        {
            string napNev = MeghatarozNapnevet(datum.DayOfWeek);
            Console.WriteLine($"A megadott dátum a hét {napNev} napjára esik.");
        }
        else
        {
            Console.WriteLine("Hibás dátumformátum!");
        }

        Console.ReadLine();
    }

    static string MeghatarozNapnevet(DayOfWeek nap)
    {
        switch (nap)
        {
            case DayOfWeek.Sunday:
                return "vasárnap";
            case DayOfWeek.Monday:
                return "hétfő";
            case DayOfWeek.Tuesday:
                return "kedd";
            case DayOfWeek.Wednesday:
                return "szerda";
            case DayOfWeek.Thursday:
                return "csütörtök";
            case DayOfWeek.Friday:
                return "péntek";
            case DayOfWeek.Saturday:
                return "szombat";
            default:
                return "ismeretlen";
        }
    }
}