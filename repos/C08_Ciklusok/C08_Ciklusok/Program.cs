using System;

class Program
{
    static void Main()
    {
        double[] honapok = new double[12];

        for (int i = 0; i < 12; i++)
        {
            Console.Write($"Kérem, adja meg a(z) {i + 1}. hónap középhőmérsékletét: ");
            honapok[i] = Convert.ToDouble(Console.ReadLine());
        }

        double eviKozephomerseklet = SzamolEviKozephomerseklet(honapok);
        Console.WriteLine($"Az éves középhőmérséklet: {eviKozephomerseklet:F2} Celsius fok");

        Console.ReadLine();
    }

    static double SzamolEviKozephomerseklet(double[] honapok)
    {
        double osszeg = 0;

        foreach (double homerseklet in honapok)
        {
            osszeg += homerseklet;
        }

        return osszeg / honapok.Length;
    }
}