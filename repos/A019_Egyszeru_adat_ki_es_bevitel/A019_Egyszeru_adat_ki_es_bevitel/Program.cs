using System;

class Program
{
    static void Main()
    {
        int[] bankjegyek = { 500, 1000, 2000, 5000, 10000, 20000 };
        int[] darabszam = new int[6];
        int osszesBevetel = 0;

        for (int i = 0; i < bankjegyek.Length; i++)
        {
            Console.Write($"Hány darab {bankjegyek[i]} Ft-os bankjegyből van? ");
            darabszam[i] = Convert.ToInt32(Console.ReadLine());
            osszesBevetel += bankjegyek[i] * darabszam[i];
        }

        Console.WriteLine($"Az összes bevétel: {osszesBevetel} Ft");

        Console.ReadLine();
    }
}