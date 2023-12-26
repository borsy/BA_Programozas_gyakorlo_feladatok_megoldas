using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg az évszámot (1901-2099): ");
        int evszam = Convert.ToInt32(Console.ReadLine());

        if (evszam < 1901 || evszam > 2099)
        {
            Console.WriteLine("Az évszámnak 1901 és 2099 között kell lennie.");
        }
        else
        {
            int M, N, A, B, C, D, E, H;

            if (evszam >= 1583 && evszam <= 1699)
            {
                M = 22;
                N = 2;
            }
            else if (evszam >= 1700 && evszam <= 1799)
            {
                M = 23;
                N = 3;
            }
            else if (evszam >= 1800 && evszam <= 1899)
            {
                M = 23;
                N = 4;
            }
            else if (evszam >= 1900 && evszam <= 2099)
            {
                M = 24;
                N = 5;
            }
            else if (evszam >= 2100 && evszam <= 2199)
            {
                M = 24;
                N = 6;
            }
            else
            {
                M = 25;
                N = 0;
            }

            A = evszam % 19;
            B = evszam % 4;
            C = evszam % 7;
            D = (19 * A + M) % 30;
            E = (2 * B + 4 * C + 6 * D + N) % 7;
            H = 22 + D + E;

            if (D == 29 && E == 6)
            {
                H = 50;
            }
            else if (D == 28 && E == 6 && A > 10)
            {
                H = 49;
            }

            if (H <= 31)
            {
                Console.WriteLine($"Húsvét: március {H}");
                Console.WriteLine($"Pünkösd: május {H + 49}");
            }
            else
            {
                Console.WriteLine($"Húsvét: április {H - 31}");
                Console.WriteLine($"Pünkösd: május {H - 31 + 49}");
            }
        }

        Console.ReadLine();
    }
}