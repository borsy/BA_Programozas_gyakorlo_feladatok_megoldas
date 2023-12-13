using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg a hosszúságot milliméterben (mm): ");
        double millimeter = Convert.ToDouble(Console.ReadLine());

        double meter = millimeter / 1000;
        double decimeter = millimeter / 100;
        double centimeter = millimeter / 10;

        Console.WriteLine($"A megadott hosszúság:");
        Console.WriteLine($"Méterben (m): {meter:F2} m");
        Console.WriteLine($"Deciméterben (dm): {decimeter:F2} dm");
        Console.WriteLine($"Centiméterben (cm): {centimeter:F2} cm");
        Console.WriteLine($"Milliméterben (mm): {millimeter:F2} mm");

        Console.ReadLine();
    }
}