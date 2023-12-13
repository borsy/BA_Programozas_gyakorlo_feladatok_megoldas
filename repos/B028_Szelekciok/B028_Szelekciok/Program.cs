using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg a hét napjának számát (1-7): ");
        int napSzama = Convert.ToInt32(Console.ReadLine());

        string napSzoveg = HetNapja(napSzama);

        if (napSzoveg != null)
        {
            Console.WriteLine($"A hét napja: {napSzoveg}");
        }
        else
        {
            Console.WriteLine("Érvénytelen nap szám.");
        }

        Console.ReadLine();
    }

    static string HetNapja(int napSzama)
    {
        switch (napSzama)
        {
            case 1:
                return "hétfő";
            case 2:
                return "kedd";
            case 3:
                return "szerda";
            case 4:
                return "csütörtök";
            case 5:
                return "péntek";
            case 6:
                return "szombat";
            case 7:
                return "vasárnap";
            default:
                return null;
        }
    }
}