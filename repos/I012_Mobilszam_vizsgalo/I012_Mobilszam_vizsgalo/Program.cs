using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Mobiltelefonszám ellenőrzése");
        Console.WriteLine("============================");

        // Mobiltelefonszám bekérése
        Console.Write("Kérem, adja meg a mobiltelefonszámot (100000000-999999999): ");
        string telefonszam = Console.ReadLine();

        // Ellenőrzés a körzetszámokra
        if (telefonszam.Contains("20") || telefonszam.Contains("30") || telefonszam.Contains("70"))
        {
            // Körzetszám alapján szolgáltató meghatározása
            string szolgaltato = "";

            if (telefonszam.Contains("20"))
            {
                szolgaltato = "Telenor";
            }
            else if (telefonszam.Contains("30"))
            {
                szolgaltato = "T-Mobile";
            }
            else if (telefonszam.Contains("70"))
            {
                szolgaltato = "Vodafone";
            }

            Console.WriteLine($"A megadott szám a(z) {szolgaltato} szolgáltatóhoz tartozik.");
        }
        else
        {
            Console.WriteLine("A megadott szám nem tartalmazza a 20-as, 30-as vagy 70-es körzetszámot.");
        }

        Console.ReadLine();
    }
}