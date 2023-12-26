using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] szamok = new int[40];
        int pozitivSzamokSzama = 0;

        for (int i = 0; i < szamok.Length; i++)
        {
            szamok[i] = random.Next(-100, 101);

            if (szamok[i] > 0)
            {
                pozitivSzamokSzama++;
            }

            Console.Write($"{szamok[i],6}");

            if ((i + 1) % 8 == 0)
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine($"\nPozitív számok száma: {pozitivSzamokSzama}");

        Console.ReadLine();
    }
}