using System;

class Program
{
    static void Main()
    {
        int[] tomb = new int[10];
        Random random = new Random();

        // Tömb feltöltése véletlenszerű egész számokkal 20 és 60 között
        for (int i = 0; i < 10; i++)
        {
            tomb[i] = random.Next(20, 61);
        }

        Console.WriteLine("Tömb elemei:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(tomb[i] + " ");
        }
        Console.WriteLine();

        int legnagyobb = tomb[0];
        int legkisebb = tomb[0];
        int legnagyobbIndex = 0;
        int legkisebbIndex = 0;

        for (int i = 1; i < 10; i++)
        {
            if (tomb[i] > legnagyobb)
            {
                legnagyobb = tomb[i];
                legnagyobbIndex = i;
            }

            if (tomb[i] < legkisebb)
            {
                legkisebb = tomb[i];
                legkisebbIndex = i;
            }
        }

        Console.WriteLine($"A legnagyobb érték: {legnagyobb}, indexe: {legnagyobbIndex}");
        Console.WriteLine($"A legkisebb érték: {legkisebb}, indexe: {legkisebbIndex}");

        Console.ReadLine();
    }
}