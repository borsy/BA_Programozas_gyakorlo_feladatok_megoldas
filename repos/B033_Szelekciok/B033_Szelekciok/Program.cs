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
            string osztalyozasSzoveg = OsztalyozSzoveg(pontszam);
            int osztalyozasSzam = OsztalyozSzam(pontszam);
            Console.WriteLine($"Pontszám: {pontszam}");
            Console.WriteLine($"Jegy (szövegesen): {osztalyozasSzoveg}");
            Console.WriteLine($"Jegy (számszerűen): {osztalyozasSzam}");
        }

        Console.ReadLine();
    }

    static string OsztalyozSzoveg(int pontszam)
    {
        if (pontszam >= 90)
        {
            return "kitűnő";
        }
        else if (pontszam >= 80)
        {
            return "jó";
        }
        else if (pontszam >= 65)
        {
            return "közepes";
        }
        else if (pontszam >= 50)
        {
            return "elégséges";
        }
        else
        {
            return "elégtelen";
        }
    }

    static int OsztalyozSzam(int pontszam)
    {
        if (pontszam >= 90)
        {
            return 5;
        }
        else if (pontszam >= 80)
        {
            return 4;
        }
        else if (pontszam >= 65)
        {
            return 3;
        }
        else if (pontszam >= 50)
        {
            return 2;
        }
        else
        {
            return 1;
        }
    }
}