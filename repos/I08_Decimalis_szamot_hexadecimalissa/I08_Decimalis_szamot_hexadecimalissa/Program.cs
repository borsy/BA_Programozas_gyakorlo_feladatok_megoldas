using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Tízes számrendszerből hexadecimális számrendszerbe");
        Console.WriteLine("==============================================");

        // Tízes szám bekérése
        Console.Write("Adja meg a tízes számot: ");
        int decimalisSzam = Convert.ToInt32(Console.ReadLine());

        // Tízes szám átalakítása hexadecimális számrendszerbe
        string hexaSzam = DecimalToHexadecimal(decimalisSzam);

        // Eredmény kiíratása
        Console.WriteLine($"A megadott tízes szám hexadecimálisan: {hexaSzam}");

        Console.ReadLine();
    }

    // Tízes szám átalakítása hexadecimális számrendszerbe
    static string DecimalToHexadecimal(int decimalisSzam)
    {
        if (decimalisSzam == 0)
        {
            return "0";
        }

        string hexa = "";
        while (decimalisSzam > 0)
        {
            int maradek = decimalisSzam % 16;
            if (maradek < 10)
            {
                hexa = maradek + hexa;
            }
            else
            {
                char hexaKarakter = (char)('A' + (maradek - 10));
                hexa = hexaKarakter + hexa;
            }
            decimalisSzam = decimalisSzam / 16;
        }

        return hexa;
    }
}