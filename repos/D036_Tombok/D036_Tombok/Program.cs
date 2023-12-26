using System;

class Program
{
    static void Main()
    {
        int[] tomb = new int[10];
        Random random = new Random();

        // Tömb feltöltése véletlenszerű egész számokkal 100 és 200 között
        for (int i = 0; i < 10; i++)
        {
            tomb[i] = random.Next(100, 201);
        }

        // Három legnagyobb érték kiválasztása
        int[] legnagyobbHarom = KivalasztHarmasLegnagyobb(tomb);

        Console.WriteLine("Tömb elemei:");
        foreach (var szam in tomb)
        {
            Console.Write(szam + " ");
        }
        Console.WriteLine();

        Console.WriteLine("A három legnagyobb érték:");
        foreach (var szam in legnagyobbHarom)
        {
            Console.Write(szam + " ");
        }

        Console.ReadLine();
    }

    static int[] KivalasztHarmasLegnagyobb(int[] tomb)
    {
        Array.Sort(tomb);
        int[] legnagyobbHarom = new int[3];

        int index = tomb.Length - 1;
        for (int i = 0; i < 3; i++)
        {
            legnagyobbHarom[i] = tomb[index];
            index--;
        }

        return legnagyobbHarom;
    }
}