using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg az első egész számot (a): ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Kérem, adja meg a második egész számot (b): ");
        int b = Convert.ToInt32(Console.ReadLine());

        double szorzat = a * b;
        double hanyados = (double)a / b;

        Console.WriteLine($"A szorzatuk: {szorzat:F2}");
        Console.WriteLine($"A hányadosuk: {hanyados:F2}");

        Console.ReadLine();
    }
}