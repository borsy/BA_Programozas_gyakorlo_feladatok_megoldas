using System;

class Program
{
    static void Main()
    {
        int[] szamok = new int[10];
        Random random = new Random();

        // Tömb feltöltése véletlenszerű egész számokkal
        for (int i = 0; i < 10; i++)
        {
            szamok[i] = random.Next(1, 101); // Véletlenszerű számok 1 és 100 között
        }

        Console.WriteLine("Véletlen számok:");
        foreach (var szam in szamok)
        {
            Console.Write(szam + " ");
        }
        Console.WriteLine();

        int osszeg = 0;
        int szorzat = 1;

        foreach (var szam in szamok)
        {
            osszeg += szam;
            szorzat *= szam;
        }

        double atlag = (double)osszeg / szamok.Length;

        Console.WriteLine($"Összeg: {osszeg}");
        Console.WriteLine($"Szorzat: {szorzat}");
        Console.WriteLine($"Átlag: {atlag:F2}"); // Két tizedesjegy pontossággal kiírva

        Console.ReadLine();
    }
}