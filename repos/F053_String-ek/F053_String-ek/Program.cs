using System;

class Program
{
    static void Main()
    {
        Console.Write("Adjon meg egy szöveget: ");
        string szoveg = Console.ReadLine();

        string szovegEvel = SzovegEKivetele(szoveg, 'e');

        Console.WriteLine("A szöveg 'e' betűk nélkül: " + szovegEvel);

        Console.ReadLine();
    }

    static string SzovegEKivetele(string eredetiSzoveg, char betu)
    {
        return new string(eredetiSzoveg.Where(c => c != betu).ToArray());
    }
}