using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adjon meg egy számot: ");
        int szam = Convert.ToInt32(Console.ReadLine());

        string szamBetulevel = SzamBetulevel(szam);

        Console.WriteLine($"{szam} betűvel: {szamBetulevel}");
    }

    static string SzamBetulevel(int szam)
    {
        if (szam == 0)
        {
            return "nulla";
        }

        string[] egyesek = { "", "egy", "kettő", "három", "négy", "öt", "hat", "hét", "nyolc", "kilenc" };
        string[] tizesek = { "", "tíz", "huszon", "harminc", "negyven", "ötven", "hatvan", "hetven", "nyolcvan", "kilencven" };
        string[] szazasok = { "", "száz", "kétszáz", "háromszáz", "négyszáz", "ötszáz", "hatszáz", "hétszáz", "nyolcszáz", "kilencszáz" };

        string[] ezreseket = { "", "ezer", "millió", "milliárd" };

        string szamBetulevel = "";

        // Tízesek és egyesek
        int egyesSzamjegy = szam % 10;
        int tizesSzamjegy = (szam / 10) % 10;
        int szazasSzamjegy = szam / 100;

        // Tízesek és egyesek lefordítása
        if (tizesSzamjegy == 1)
        {
            szamBetulevel = tizesek[tizesSzamjegy] + egyesek[egyesSzamjegy];
        }
        else
        {
            szamBetulevel = tizesek[tizesSzamjegy] + egyesek[egyesSzamjegy];
        }

        // Százasok lefordítása
        szamBetulevel = szazasok[szazasSzamjegy] + szamBetulevel;

        // Ezerrel való kezelés
        int ezerSzamlalo = 0;
        while (szam >= 1000)
        {
            int szamresz = szam % 1000;
            if (szamresz != 0)
            {
                szamBetulevel = SzamBetulevel(szamresz) + ezreseket[ezerSzamlalo] + szamBetulevel;
            }
            szam /= 1000;
            ezerSzamlalo++;
        }

        if (szam != 0)
        {
            szamBetulevel = SzamBetulevel(szam) + ezreseket[ezerSzamlalo] + szamBetulevel;
        }

        return szamBetulevel;
    }
}