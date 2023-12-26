using System;

class Program
{
    static void Main()
    {
        Console.Write("Adja meg az első dátumot (éééé-hh-nn): ");
        string elsoDatumString = Console.ReadLine();

        Console.Write("Adja meg a második dátumot (éééé-hh-nn): ");
        string masodikDatumString = Console.ReadLine();

        if (DateTime.TryParse(elsoDatumString, out DateTime elsoDatum) && DateTime.TryParse(masodikDatumString, out DateTime masodikDatum))
        {
            TimeSpan kulonbseg = masodikDatum - elsoDatum;
            int napokSzama = (int)kulonbseg.TotalDays;

            Console.WriteLine($"A két dátum között eltelt napok száma: {napokSzama}");
        }
        else
        {
            Console.WriteLine("Hibás dátumformátum!");
        }

        Console.ReadLine();
    }
}