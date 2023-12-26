using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg az x koordinátát: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Kérem, adja meg az y koordinátát: ");
        double y = Convert.ToDouble(Console.ReadLine());

        string sikonNegyed = SikonNegyed(x, y);

        if (sikonNegyed != null)
        {
            Console.WriteLine($"A pont a(z) {sikonNegyed} síknegyedben van.");
        }
        else
        {
            Console.WriteLine("A pont a tengelyeken vagy a középpontban helyezkedik el.");
        }

        Console.ReadLine();
    }

    static string SikonNegyed(double x, double y)
    {
        if (x > 0 && y > 0)
        {
            return "első";
        }
        else if (x < 0 && y > 0)
        {
            return "második";
        }
        else if (x < 0 && y < 0)
        {
            return "harmadik";
        }
        else if (x > 0 && y < 0)
        {
            return "negyedik";
        }
        else
        {
            return null;
        }
    }
}