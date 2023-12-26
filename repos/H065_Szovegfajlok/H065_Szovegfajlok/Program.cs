using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            // A StreamReader használatával olvassuk be a fájl tartalmát
            using (StreamReader reader = new StreamReader("kaptam.txt"))
            {
                string tartalom = reader.ReadToEnd();
                Console.WriteLine("A 'kaptam.txt' fájl tartalma:");
                Console.WriteLine(tartalom);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Hiba történt: {ex.Message}");
        }

        Console.ReadLine();
    }
}