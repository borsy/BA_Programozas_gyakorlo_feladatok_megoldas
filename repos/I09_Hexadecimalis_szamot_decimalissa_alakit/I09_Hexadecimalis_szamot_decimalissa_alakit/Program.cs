using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hexadecimális számból tízes számba");
        Console.WriteLine("===================================");

        // Hexadecimális szám bekérése
        Console.Write("Adja meg a hexadecimális számot: ");
        string hexaSzam = Console.ReadLine();

        // Hexadecimális szám átalakítása tízes számrendszerbe
        int decimalisSzam = HexadecimalToDecimal(hexaSzam);

        // Eredmény kiíratása
        Console.WriteLine($"A megadott hexadecimális szám tízes számrendszerben: {decimalisSzam}");

        Console.ReadLine();
    }

    // Hexadecimális szám átalakítása tízes számrendszerbe
    static int HexadecimalToDecimal(string hexaSzam)
    {
        int decimalisSzam = 0;
        int helyiErtek = 1;

        for (int i = hexaSzam.Length - 1; i >= 0; i--)
        {
            char karakter = hexaSzam[i];
            int szam;

            if (char.IsDigit(karakter))
            {
                szam = karakter - '0';
            }
            else if (char.IsLetter(karakter))
            {
                szam = char.ToUpper(karakter) - 'A' + 10;
            }
            else
            {
                throw new ArgumentException("Érvénytelen karakter a hexadecimális számban.");
            }

            decimalisSzam += szam * helyiErtek;
            helyiErtek *= 16;
        }

        return decimalisSzam;
    }
}