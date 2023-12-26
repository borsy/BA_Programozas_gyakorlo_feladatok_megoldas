using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Testtömegindex (BMI) számítása");
        Console.WriteLine("=============================");

        // Testsúly és testmagasság bekérése
        Console.Write("Adja meg a testsúlyát kg-ban: ");
        double testsuly = Convert.ToDouble(Console.ReadLine());

        Console.Write("Adja meg a testmagasságát méterben: ");
        double magassag = Convert.ToDouble(Console.ReadLine());

        // BMI számítás
        double bmi = testsuly / (magassag * magassag);

        // BMI érték kiíratása
        Console.WriteLine($"Az Ön testtömegindexe (BMI): {bmi:F2}");

        // BMI alapján testsúly kategória meghatározása
        string testsulyKategoria = "";
        if (bmi < 16)
        {
            testsulyKategoria = "Súlyos soványság";
        }
        else if (bmi >= 16 && bmi < 17)
        {
            testsulyKategoria = "Mérsékelt soványság";
        }
        else if (bmi >= 17 && bmi < 18.5)
        {
            testsulyKategoria = "Enyhe soványság";
        }
        else if (bmi >= 18.5 && bmi < 25)
        {
            testsulyKategoria = "Normál testsúly";
        }
        else if (bmi >= 25 && bmi < 30)
        {
            testsulyKategoria = "Túlsúlyos";
        }
        else if (bmi >= 30 && bmi < 35)
        {
            testsulyKategoria = "I. fokú elhízás";
        }
        else if (bmi >= 35 && bmi < 40)
        {
            testsulyKategoria = "II. fokú elhízás";
        }
        else
        {
            testsulyKategoria = "III. fokú (súlyos) elhízás";
        }

        // Testsúly kategória kiíratása
        Console.WriteLine($"Testsúly kategória: {testsulyKategoria}");

        Console.ReadLine();
    }
}