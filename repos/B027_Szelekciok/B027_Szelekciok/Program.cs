using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg az első oldal hosszát: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Kérem, adja meg a második oldal hosszát: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Kérem, adja meg a harmadik oldal hosszát: ");
        double c = Convert.ToDouble(Console.ReadLine());

        if (SzerkeszthetoHaromszog(a, b, c))
        {
            Console.WriteLine("A háromszög szerkeszthető.");
        }
        else
        {
            Console.WriteLine("A háromszög nem szerkeszthető.");
        }

        Console.ReadLine();
    }

    static bool SzerkeszthetoHaromszog(double a, double b, double c)
    {
        if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)
        {
            return true;
        }
        return false;
    }
}