using System;

class Program
{
    static void Main()
    {
        Console.Write("Adjon meg egy szöveget: ");
        string szoveg = Console.ReadLine();

        string[] szavak = SzovegetSzavakraBont(szoveg);

        Console.WriteLine("A szövegben található szavak:");
        foreach (string szo in szavak)
        {
            Console.WriteLine(szo);
        }

        Console.ReadLine();
    }

    static string[] SzovegetSzavakraBont(string szoveg)
    {
        char[] elvalasztoKarakterek = { ' ', ',', '.', '!', '?', ';', ':' };
        return szoveg.Split(elvalasztoKarakterek, StringSplitOptions.RemoveEmptyEntries);
    }
}