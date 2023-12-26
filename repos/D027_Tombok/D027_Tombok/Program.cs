using System;

class Program
{
    static void Main()
    {
        int[] szamok = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Kérem, adjon meg egy számot ({i + 1}. szám): ");
            szamok[i] = Convert.ToInt32(Console.ReadLine());
        }

        int legnagyobbSzam = szamok[0];

        for (int i = 1; i < 5; i++)
        {
            if (szamok[i] > legnagyobbSzam)
            {
                legnagyobbSzam = szamok[i];
            }
        }

        Console.WriteLine($"A legnagyobb szám a megadottak között: {legnagyobbSzam}");
        Console.ReadLine();
    }
}