using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adjon meg egy pozitív egész számot: ");
        int szam = Convert.ToInt32(Console.ReadLine());

        if (szam <= 1)
        {
            Console.WriteLine("Hibás adat! A számnak nagyobbnak kell lennie, mint 1.");
        }
        else if (IsPrime(szam))
        {
            Console.WriteLine($"{szam} prím szám.");
        }
        else
        {
            Console.WriteLine($"{szam} nem prím szám.");
        }

        Console.ReadLine();
    }

    static bool IsPrime(int szam)
    {
        if (szam <= 1)
        {
            return false;
        }

        for (int i = 2; i * i <= szam; i++)
        {
            if (szam % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}