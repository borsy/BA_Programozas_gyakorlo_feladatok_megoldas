using System;

class Program
{
    static void Main()
    {
        int[] tomb = new int[10];
        Random random = new Random();

        // Tömb feltöltése véletlenszerű egész számokkal 200 és 300 között
        for (int i = 0; i < 10; i++)
        {
            tomb[i] = random.Next(200, 301);
        }

        Console.WriteLine("Tömb elemei:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(tomb[i] + " ");
        }
        Console.WriteLine();

        int legnagyobb = tomb[0];
        int legnagyobbIndex = 0;

        for (int i = 1; i < 10; i++)
        {
            if (tomb[i] > legnagyobb)
            {
                legnagyobb = tomb[i];
                legnagyobbIndex = i;
            }
        }

        Console.WriteLine($"A legnagyobb érték: {legnagyobb}");
        Console.WriteLine($"A legnagyobb érték indexe: {legnagyobbIndex + 1}");

        Console.ReadLine();
    }
}