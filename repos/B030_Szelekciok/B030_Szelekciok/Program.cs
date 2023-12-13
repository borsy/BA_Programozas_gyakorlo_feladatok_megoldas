using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg a víz hőmérsékletét (°C): ");
        double homerseklet = Convert.ToDouble(Console.ReadLine());

        string allapot = Halmazallapot(homerseklet);

        if (allapot != null)
        {
            Console.WriteLine($"A víz hőmérséklete {homerseklet} °C, halmazállapota: {allapot}");
        }
        else
        {
            Console.WriteLine("Az érvénytelen hőmérséklet.");
        }

        Console.ReadLine();
    }

    static string Halmazallapot(double homerseklet)
    {
        if (homerseklet >= 100)
        {
            return "gőz";
        }
        else if (homerseklet <= 0)
        {
            return "jég";
        }
        else
        {
            return "folyékony";
        }
    }
}