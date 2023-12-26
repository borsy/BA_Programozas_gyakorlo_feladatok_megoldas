using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg az alapot (a): ");
        int alap = Convert.ToInt32(Console.ReadLine());

        Console.Write("Kérem, adja meg a kitevőt (n): ");
        int kitevo = Convert.ToInt32(Console.ReadLine());

        double hatvany = Math.Pow(alap, kitevo);
        Console.WriteLine($"{alap}^{kitevo} = {hatvany}");

        Console.ReadLine();
    }
}