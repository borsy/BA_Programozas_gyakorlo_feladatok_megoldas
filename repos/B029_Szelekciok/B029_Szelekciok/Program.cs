using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg a hónap számát (1-12): ");
        int honapSzama = Convert.ToInt32(Console.ReadLine());

        string honapSzoveg = HonapNeve(honapSzama);

        if (honapSzoveg != null)
        {
            Console.WriteLine($"A hónap neve: {honapSzoveg}");
        }
        else
        {
            Console.WriteLine("Érvénytelen hónap szám.");
        }

        Console.ReadLine();
    }

    static string HonapNeve(int honapSzama)
    {
        switch (honapSzama)
        {
            case 1:
                return "január";
            case 2:
                return "február";
            case 3:
                return "március";
            case 4:
                return "április";
            case 5:
                return "május";
            case 6:
                return "június";
            case 7:
                return "július";
            case 8:
                return "augusztus";
            case 9:
                return "szeptember";
            case 10:
                return "október";
            case 11:
                return "november";
            case 12:
                return "december";
            default:
                return null;
        }
    }
}