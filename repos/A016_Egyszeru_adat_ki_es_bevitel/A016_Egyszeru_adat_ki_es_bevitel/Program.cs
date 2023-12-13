using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg az \"A\" pont koordinátáit (a1 a2): ");
        string[] pontA = Console.ReadLine().Split(' ');
        double a1 = Convert.ToDouble(pontA[0]);
        double a2 = Convert.ToDouble(pontA[1]);

        Console.Write("Kérem, adja meg a \"B\" pont koordinátáit (b1 b2): ");
        string[] pontB = Console.ReadLine().Split(' ');
        double b1 = Convert.ToDouble(pontB[0]);
        double b2 = Convert.ToDouble(pontB[1]);

        double tavolsag = Math.Sqrt(Math.Pow(b1 - a1, 2) + Math.Pow(b2 - a2, 2));

        Console.WriteLine($"Az \"A\" és \"B\" pont távolsága: {tavolsag:F2}");

        Console.ReadLine();
    }
}