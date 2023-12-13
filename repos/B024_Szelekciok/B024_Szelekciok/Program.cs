using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg egy hónap számát (1-12): ");
        int honap = Convert.ToInt32(Console.ReadLine());

        string evszak;

        switch (honap)
        {
            case 12:
            case 1:
            case 2:
                evszak = "tél";
                break;
            case 3:
            case 4:
            case 5:
                evszak = "tavasz";
                break;
            case 6:
            case 7:
            case 8:
                evszak = "nyár";
                break;
            case 9:
            case 10:
            case 11:
                evszak = "ősz";
                break;
            default:
                evszak = "nincs ilyen hónap";
                break;
        }

        Console.WriteLine($"Az adott hónap {evszak} évszakban van.");

        Console.ReadLine();
    }
}