using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg a számot: ");
        int szam = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"A(z) {szam} osztói:");

        for (int i = 1; i <= szam; i++)
        {
            if (szam % i == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadLine();
    }
}