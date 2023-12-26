using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Szám | Négyzet");
        Console.WriteLine("-------------");

        for (int i = 1; i <= 20; i++)
        {
            int negyzet = i * i;
            Console.WriteLine($"{i,-4} | {negyzet}");
        }

        Console.ReadLine();
    }
}