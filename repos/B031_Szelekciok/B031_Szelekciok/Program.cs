using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg a csapat által szerzett pontok számát: ");
        int pontok = Convert.ToInt32(Console.ReadLine());

        string jatekEredmeny = MitJatszottAcsapat(pontok);

        if (jatekEredmeny != null)
        {
            Console.WriteLine($"A csapat a fordulóban {jatekEredmeny} játszott.");
        }
        else
        {
            Console.WriteLine("Az érvénytelen pontszám.");
        }

        Console.ReadLine();
    }

    static string MitJatszottAcsapat(int pontok)
    {
        if (pontok == 0)
        {
            return "vereség";
        }
        else if (pontok == 1)
        {
            return "döntetlen";
        }
        else if (pontok == 3)
        {
            return "győzelem";
        }
        else
        {
            return null;
        }
    }
}