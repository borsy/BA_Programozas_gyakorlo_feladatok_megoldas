using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg a pénzösszeget: ");
        double osszeg = Convert.ToDouble(Console.ReadLine());

        // Kerekítés a legközelebbi 5 Ft-re
        double kerekitettOsszeg = Math.Round(osszeg / 5) * 5;

        Console.WriteLine($"Kerekített összeg: {kerekitettOsszeg} Ft");

        Console.ReadLine();
    }
}