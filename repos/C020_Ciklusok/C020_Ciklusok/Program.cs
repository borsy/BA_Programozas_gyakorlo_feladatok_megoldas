using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adjon meg két pozitív egész számot (első szám): ");
        int szam1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Kérem, adjon meg két pozitív egész számot (második szám): ");
        int szam2 = Convert.ToInt32(Console.ReadLine());

        if (szam1 <= 0 || szam2 <= 0)
        {
            Console.WriteLine("Hibás adat! A számoknak pozitívnak kell lenniük.");
        }
        else
        {
            int gcd = CalculateGCD(szam1, szam2);
            int lcm = (szam1 * szam2) / gcd;
            Console.WriteLine($"A legkisebb közös többszörös ({szam1} és {szam2} között): {lcm}");
        }

        Console.ReadLine();
    }

    static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}