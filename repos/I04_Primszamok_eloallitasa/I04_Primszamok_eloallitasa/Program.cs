using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Adjon meg egy egész számot: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        int currentNumber = 2; // Az első prímszám, amit megvizsgálunk

        Console.WriteLine($"{n} darab prímszám:");
        while (count < n)
        {
            if (IsPrime(currentNumber))
            {
                Console.Write(currentNumber + " ");
                count++;
            }
            currentNumber++;
        }

        Console.ReadLine();
    }
}