using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int gondoltSzam = random.Next(1, 101); // Véletlenszerű szám generálása 1 és 100 között
        int tipp = 0;
        int probalkozasokSzama = 0;

        Console.WriteLine("Gondoltam egy számra 1 és 100 között. Próbálja meg kitalálni!");

        while (tipp != gondoltSzam)
        {
            Console.Write("Tipp: ");
            tipp = Convert.ToInt32(Console.ReadLine());
            probalkozasokSzama++;

            if (tipp < gondoltSzam)
            {
                Console.WriteLine("A gondolt szám nagyobb!");
            }
            else if (tipp > gondoltSzam)
            {
                Console.WriteLine("A gondolt szám kisebb!");
            }
            else
            {
                Console.WriteLine($"Gratulálok! Eltalálta a számot {probalkozasokSzama} próbálkozásból!");
            }
        }

        Console.ReadLine();
    }
}