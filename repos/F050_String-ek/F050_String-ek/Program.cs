using System;

class Program
{
    static void Main()
    {
        Console.Write("Adjon meg egy szöveget: ");
        string szoveg = Console.ReadLine();

        Console.WriteLine("A szöveg betűnként új sorba írva:");

        foreach (char karakter in szoveg)
        {
            Console.WriteLine(karakter);
        }

        Console.ReadLine();
    }
}