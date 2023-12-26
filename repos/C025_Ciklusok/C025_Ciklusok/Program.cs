using System;

class Program
{
    static void Main()
    {
        int sorokSzama = 15;

        for (int i = sorokSzama; i >= 1; i--)
        {
            for (int j = 1; j <= sorokSzama - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}