using System;

class Program
{
    static void Main()
    {
        Console.Write("Adjon meg egy szöveget: ");
        string szoveg = Console.ReadLine();

        bool tartalmazNevelo = TartalmazNevelo(szoveg);

        if (tartalmazNevelo)
        {
            Console.WriteLine("A szöveg tartalmaz névelőt ('a' vagy 'az').");
        }
        else
        {
            Console.WriteLine("A szöveg nem tartalmaz névelőt ('a' vagy 'az').");
        }

        Console.ReadLine();
    }

    static bool TartalmazNevelo(string szoveg)
    {
        return szoveg.Contains(" a ") || szoveg.Contains(" az ");
    }
}