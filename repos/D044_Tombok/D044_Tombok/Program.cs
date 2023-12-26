using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int[] lottoSzamok = new int[5];

        for (int i = 0; i < 5; i++)
        {
            int szam;
            do
            {
                szam = random.Next(1, 91);
            } while (Array.Exists(lottoSzamok, x => x == szam));

            lottoSzamok[i] = szam;
        }

        Console.WriteLine("Az öt lottószám tippek:");
        foreach (var szam in lottoSzamok)
        {
            Console.Write(szam + " ");
        }
        Console.WriteLine();

        Console.ReadLine();
    }
}