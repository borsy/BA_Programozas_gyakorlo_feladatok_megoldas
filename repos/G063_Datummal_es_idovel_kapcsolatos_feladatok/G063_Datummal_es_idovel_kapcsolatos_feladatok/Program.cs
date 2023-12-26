using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérjük, adja meg a születési dátumot (éééé-hh-nn): ");
        string szuletesiDatumString = Console.ReadLine();

        if (DateTime.TryParse(szuletesiDatumString, out DateTime szuletesiDatum))
        {
            TimeSpan elteltIdo = DateTime.Now - szuletesiDatum;
            int eletkor = (int)(elteltIdo.TotalDays / 365.25); // Átlagosan 365.25 nap egy évben

            Console.WriteLine($"Az Ön életkora: {eletkor} év");
        }
        else
        {
            Console.WriteLine("Hibás dátumformátum!");
        }

        Console.ReadLine();
    }
}