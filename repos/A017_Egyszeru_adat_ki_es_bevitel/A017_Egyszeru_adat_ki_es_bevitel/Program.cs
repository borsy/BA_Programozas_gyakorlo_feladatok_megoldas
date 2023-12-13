using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg a napi bevételt: ");
        double bevetel = Convert.ToDouble(Console.ReadLine());

        double jutalom = Math.Round(bevetel * 0.05);

        Console.WriteLine($"A pénztáros jutalma: {jutalom}");

        Console.ReadLine();
    }
}