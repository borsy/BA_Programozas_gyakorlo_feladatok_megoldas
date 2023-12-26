using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("10-es szorzótábla:");

        for (int i = 1; i <= 10; i++)
        {
            int eredmeny = 10 * i;
            Console.WriteLine($"10 * {i} = {eredmeny}");
        }

        Console.ReadLine();
    }
}