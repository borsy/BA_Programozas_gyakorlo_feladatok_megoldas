using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg az alapot (első számot): ");
        double alap = Convert.ToDouble(Console.ReadLine());

        Console.Write("Kérem, adja meg a kitevőt (második számot): ");
        double kitevo = Convert.ToDouble(Console.ReadLine());

        double hatvany = Math.Pow(alap, kitevo);
        Console.WriteLine($"{alap}^{kitevo} = {hatvany}");

        Console.ReadLine();
    }
}