using System;

class Program
{
    static void Main()
    {
        int elozoSzam = 0;
        int jelenlegiSzam = 0;

        Console.WriteLine("Kérem, adjon meg egész számokat. Az utolsó két szám meg kell, hogy egyezzenek!");

        do
        {
            elozoSzam = jelenlegiSzam;
            Console.Write("Szám: ");
            jelenlegiSzam = Convert.ToInt32(Console.ReadLine());

        } while (elozoSzam != jelenlegiSzam);

        Console.WriteLine("Az utolsó két szám egyezik!");
        Console.ReadLine();
    }
}