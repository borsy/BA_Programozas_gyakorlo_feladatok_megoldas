using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg a nem negatív egész számot: ");
        int szam = Convert.ToInt32(Console.ReadLine());

        if (szam < 0)
        {
            Console.WriteLine("Hibás adat! A számnak nem negatívnak kell lennie.");
        }
        else if (szam == 0)
        {
            Console.WriteLine("A szám egyjegyű (0).");
        }
        else
        {
            int jegyekSzama = SzamJegyekSzama(szam);
            Console.WriteLine($"A szám {szam} {jegyekSzama} jegyű.");
        }

        Console.ReadLine();
    }

    static int SzamJegyekSzama(int szam)
    {
        int jegyekSzama = 0;
        while (szam > 0)
        {
            szam /= 10;
            jegyekSzama++;
        }
        return jegyekSzama;
    }
}