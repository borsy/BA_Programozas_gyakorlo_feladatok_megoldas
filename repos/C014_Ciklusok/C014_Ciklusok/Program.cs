using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Kérem, adjon meg egész számokat. A program addig fut, amíg nullát nem kap.");

        int szam;
        do
        {
            Console.Write("Kérem, adja meg egy egész számot: ");
            szam = Convert.ToInt32(Console.ReadLine());
        } while (szam != 0);

        Console.WriteLine("Elég.");

        Console.ReadLine();
    }
}