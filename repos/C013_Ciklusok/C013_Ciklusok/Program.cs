using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Az összes pozitív, 3-al osztható szám 99-től csökkenő sorrendben:");

        for (int i = 99; i >= 1; i--)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadLine();
    }
}