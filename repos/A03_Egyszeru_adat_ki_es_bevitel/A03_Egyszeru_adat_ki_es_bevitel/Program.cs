using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg a térfogatot deciliterben (dl): ");
        double deciliter = Convert.ToDouble(Console.ReadLine());

        double hektoliter = deciliter / 100;
        double liter = deciliter / 10;

        Console.WriteLine($"A megadott térfogat:");
        Console.WriteLine($"Hektoliterben (hl): {hektoliter:F2} hl");
        Console.WriteLine($"Literben (l): {liter:F2} l");
        Console.WriteLine($"Deciliterben (dl): {deciliter:F2} dl");

        Console.ReadLine();
    }
}