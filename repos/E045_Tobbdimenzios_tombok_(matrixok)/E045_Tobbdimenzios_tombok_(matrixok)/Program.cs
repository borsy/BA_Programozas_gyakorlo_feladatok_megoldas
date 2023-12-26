using System;

class Program
{
    static void Main()
    {
        int[] A = new int[10];
        int[] B = new int[10];
        Random random = new Random();

        // Tömbök feltöltése véletlenszerű egész számokkal 1 és 100 között
        for (int i = 0; i < 10; i++)
        {
            A[i] = random.Next(1, 101);
            B[i] = random.Next(1, 101);
        }

        Console.WriteLine("A tömb elemei:");
        Array.Sort(A); // A tömb rendezése növekvő sorrendben
        foreach (var szam in A)
        {
            Console.Write(szam + " ");
        }
        Console.WriteLine();

        Console.WriteLine("B tömb elemei:");
        Array.Sort(B); // B tömb rendezése növekvő sorrendben
        foreach (var szam in B)
        {
            Console.Write(szam + " ");
        }
        Console.WriteLine();

        Console.ReadLine();
    }
}