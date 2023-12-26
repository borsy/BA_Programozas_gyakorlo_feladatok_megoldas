using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Tízes számrendszerből bináris számrendszerbe");
        Console.WriteLine("==========================================");

        // Tízes szám bekérése
        Console.Write("Adja meg a tízes számot: ");
        int decimalisSzam = Convert.ToInt32(Console.ReadLine());

        // Tízes szám átalakítása bináris számrendszerbe
        string binarisSzam = DecimalToBinary(decimalisSzam);

        // Eredmény kiíratása
        Console.WriteLine($"A megadott tízes szám binárisan: {binarisSzam}");

        Console.ReadLine();
    }

    // Tízes szám átalakítása bináris számrendszerbe
    static string DecimalToBinary(int decimalisSzam)
    {
        if (decimalisSzam == 0)
        {
            return "0";
        }

        string binaris = "";
        while (decimalisSzam > 0)
        {
            int maradek = decimalisSzam % 2;
            binaris = maradek + binaris;
            decimalisSzam = decimalisSzam / 2;
        }

        return binaris;
    }
}