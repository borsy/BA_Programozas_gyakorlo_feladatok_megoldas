using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adjon meg egy pozitív egész számot: ");
        int szam = Convert.ToInt32(Console.ReadLine());

        if (szam <= 0)
        {
            Console.WriteLine("Hibás adat! A számnak pozitívnak kell lennie.");
        }
        else
        {
            Console.WriteLine($"Az {szam} osztói:");

            int osztoSzam = 0; // Az osztók számát tároló változó

            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    Console.WriteLine(i);
                    osztoSzam++;
                }
            }

            // Az 1 és önmaga kivételével hány osztója van
            int kulonbozoOsztoSzam = osztoSzam - 2;

            Console.WriteLine($"Az {szam}-nek összesen {osztoSzam} osztója van.");
            Console.WriteLine($"Az 1-en és önmagán kívül {kulonbozoOsztoSzam} osztója van.");
        }

        Console.ReadLine();
    }
}