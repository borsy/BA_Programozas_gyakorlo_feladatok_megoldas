using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg a pontszámot (0-100): ");
        int pontszam = Convert.ToInt32(Console.ReadLine());

        if (pontszam < 0 || pontszam > 100)
        {
            Console.WriteLine("Hibás adat! A pontszámnak 0 és 100 között kell lennie.");
        }
        else
        {
            string osztalyozas = Osztalyoz(pontszam);
            Console.WriteLine($"Pontszám: {pontszam}, Jegy: {osztalyozas}");
        }

        Console.ReadLine();
    }

    static string Osztalyoz(int pontszam)
    {
        if (pontszam >= 90)
        {
            return "A (Jeles)";
        }
        else if (pontszam >= 80)
        {
            return "B (Jó)";
        }
        else if (pontszam >= 65)
        {
            return "C (Közepes)";
        }
        else if (pontszam >= 50)
        {
            return "D (Elégséges)";
        }
        else
        {
            return "F (Elégtelen)";
        }
    }
}