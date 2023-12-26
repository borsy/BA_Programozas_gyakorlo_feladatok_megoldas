using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Másodfokú egyenlet megoldása");
        Console.WriteLine("============================");

        // Együtthatók bekérése
        Console.Write("Adja meg a másodfokú egyenlet együtthatóit (a, b, c): ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        // Diszkrimináns számítása
        double diszkriminans = b * b - 4 * a * c;

        if (diszkriminans > 0)
        {
            // Két különböző valós gyök
            double x1 = (-b + Math.Sqrt(diszkriminans)) / (2 * a);
            double x2 = (-b - Math.Sqrt(diszkriminans)) / (2 * a);

            Console.WriteLine($"Két különböző valós gyök van:");
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }
        else if (diszkriminans == 0)
        {
            // Két egyenlő gyök
            double x1 = -b / (2 * a);

            Console.WriteLine($"Két egyenlő (kétszeres) gyök van:");
            Console.WriteLine($"x1 = x2 = {x1}");
        }
        else
        {
            // Nincs valós gyök
            Console.WriteLine("Nincs valós gyök az egyenletnek.");
        }

        Console.ReadLine();
    }
}