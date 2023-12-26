using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Adjon meg egy szöveget: ");
        string szoveg = Console.ReadLine();

        Dictionary<char, int> betuSzamlalo = new Dictionary<char, int>();

        foreach (char karakter in szoveg)
        {
            if (char.IsLetter(karakter))
            {
                char kisbetu = char.ToLower(karakter);
                if (betuSzamlalo.ContainsKey(kisbetu))
                {
                    betuSzamlalo[kisbetu]++;
                }
                else
                {
                    betuSzamlalo[kisbetu] = 1;
                }
            }
        }

        Console.WriteLine("Betűk és a hozzájuk tartozó számok:");

        foreach (var kvp in betuSzamlalo.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        Console.ReadLine();
    }
}