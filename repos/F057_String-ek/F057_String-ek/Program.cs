using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Adjon meg egy szöveget: ");
        string szoveg = Console.ReadLine();

        string formazottSzoveg = FormazottSzoveg(szoveg);

        Console.WriteLine("A formázott szöveg:");
        Console.WriteLine(formazottSzoveg);

        Console.ReadLine();
    }

    static string FormazottSzoveg(string szoveg)
    {
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string[] szavak = szoveg.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < szavak.Length; i++)
        {
            szavak[i] = textInfo.ToTitleCase(szavak[i]);
        }

        return string.Join(" ", szavak);
    }
}