using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bináris számból tízes számba");
        Console.WriteLine("============================");

        // Bináris szám bekérése
        Console.Write("Adja meg a bináris számot: ");
        string binarisSzam = Console.ReadLine();

        // Bináris szám átalakítása tízes számrendszerbe
        int decimalisSzam = BinaryToDecimal(binarisSzam);

        // Eredmény kiíratása
        Console.WriteLine($"A megadott bináris szám tízes számrendszerben: {decimalisSzam}");

        Console.ReadLine();
    }

    // Bináris szám átalakítása tízes számrendszerbe
    static int BinaryToDecimal(string binarisSzam)
    {
        int decimalisSzam = 0;
        int helyiErtek = 1;

        for (int i = binarisSzam.Length - 1; i >= 0; i--)
        {
            char karakter = binarisSzam[i];

            if (karakter == '0' || karakter == '1')
            {
                int szam = karakter - '0';
                decimalisSzam += szam * helyiErtek;
                helyiErtek *= 2;
            }
            else
            {
                throw new ArgumentException("Érvénytelen karakter a bináris számban.");
            }
        }

        return decimalisSzam;
    }
}