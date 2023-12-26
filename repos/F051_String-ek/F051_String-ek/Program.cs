using System;

class Program
{
    static void Main()
    {
        Console.Write("Adjon meg egy szöveget: ");
        string szoveg = Console.ReadLine();

        char[] karakterTomb = szoveg.ToCharArray();

        Array.Reverse(karakterTomb);

        string fordítottSzöveg = new string(karakterTomb);

        Console.WriteLine("A szöveg fordított sorrendben: " + fordítottSzöveg);

        Console.ReadLine();
    }
}