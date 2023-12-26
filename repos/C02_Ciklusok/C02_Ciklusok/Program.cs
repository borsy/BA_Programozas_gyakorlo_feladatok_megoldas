using System;

class Program
{
    static void Main()
    {
        for (int i = 10; i <= 30; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadLine();
    }
}