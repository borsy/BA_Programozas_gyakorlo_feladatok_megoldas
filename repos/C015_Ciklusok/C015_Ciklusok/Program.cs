using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adjon meg egy pozitív egész számot: ");
        int szam = Convert.ToInt32(Console.ReadLine());

        if (szam < 0)
        {
            Console.WriteLine("Hibás adat! A számnak pozitívnak kell lennie.");
        }
        else
        {
            long faktorialis = SzamolFaktorialis(szam);
            Console.WriteLine($"{szam} faktoriálisa: {faktorialis}");
        }

        Console.ReadLine();
    }

    static long SzamolFaktorialis(int szam)
    {
        if (szam == 0)
        {
            return 1;
        }

        long faktorialis = 1;
        for (int i = 1; i <= szam; i++)
        {
            faktorialis *= i;
        }

        return faktorialis;
    }
}