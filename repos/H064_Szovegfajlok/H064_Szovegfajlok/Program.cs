using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Kérjük, írja be a szöveget: ");
        string szoveg = Console.ReadLine();

        try
        {
            // A StreamWriter használatával írunk a fájlba
            using (StreamWriter writer = new StreamWriter("kaptam.txt"))
            {
                writer.WriteLine(szoveg);
            }

            Console.WriteLine("A szöveg sikeresen ki lett írva a 'kaptam.txt' fájlba.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Hiba történt: {ex.Message}");
        }

        Console.ReadLine();
    }
}