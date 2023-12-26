using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg hány dobást szeretne végezni: ");
        int dobasokSzama = Convert.ToInt32(Console.ReadLine());

        Random random = new Random();
        Dictionary<int, int> statisztika = new Dictionary<int, int>();

        for (int i = 0; i < dobasokSzama; i++)
        {
            int dobas = random.Next(1, 7); // Véletlenszerű kockadobás (1-től 6-ig)

            // Statisztika frissítése
            if (statisztika.ContainsKey(dobas))
            {
                statisztika[dobas]++;
            }
            else
            {
                statisztika[dobas] = 1;
            }

            Console.WriteLine($"Dobás {i + 1}: {dobas}");
        }

        Console.WriteLine("\nStatisztika:");
        foreach (var kvp in statisztika)
        {
            Console.WriteLine($"Szám {kvp.Key}: {kvp.Value} alkalommal");
        }

        Console.ReadLine();
    }
}