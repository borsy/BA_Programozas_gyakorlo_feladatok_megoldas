using System;

class Program
{
    static void Main()
    {
        Console.Write("Adjon meg egy szöveget: ");
        string szoveg = Console.ReadLine();

        string maganhangzok = KivalogatMaganhangzok(szoveg);

        Console.WriteLine("A szöveg magánhangzói: " + maganhangzok);

        Console.ReadLine();
    }

    static string KivalogatMaganhangzok(string szoveg)
    {
        string maganhangzok = "";
        foreach (char karakter in szoveg)
        {
            if (IsMaganhangzo(karakter))
            {
                maganhangzok += karakter;
            }
        }
        return maganhangzok;
    }

    static bool IsMaganhangzo(char karakter)
    {
        char kisbetu = char.ToLower(karakter);
        return "aeiouáéíóöőúüű".Contains(kisbetu);
    }
}