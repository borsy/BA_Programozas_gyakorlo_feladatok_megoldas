using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Összeadás és kivonás gyakorlása");
        Console.WriteLine("===============================");

        Random random = new Random();
        int correctAnswers = 0;

        for (int i = 0; i < 10; i++)
        {
            int number1 = random.Next(-5, 16); // Véletlen szám az intervallumból -5 és 15 között
            int number2 = random.Next(-5, 16);
            int result;

            // Véletlenszerűen választjuk ki, hogy összeadás vagy kivonás feladatot generálunk
            bool isAddition = random.Next(2) == 0;

            if (isAddition)
            {
                result = number1 + number2;
                Console.Write($"{number1} + {number2} = ");
            }
            else
            {
                result = number1 - number2;
                Console.Write($"{number1} - {number2} = ");
            }

            int userAnswer;
            if (int.TryParse(Console.ReadLine(), out userAnswer) && userAnswer == result)
            {
                Console.WriteLine("Helyes!");
                correctAnswers++;
            }
            else
            {
                Console.WriteLine("Helytelen!");
            }
        }

        Console.WriteLine($"Feladatok száma: 10, Helyes válaszok száma: {correctAnswers}");

        // Osztályzat kiszámítása és kiírása
        int score = correctAnswers;
        string grade;

        if (score >= 0 && score <= 2)
        {
            grade = "Elégtelen";
        }
        else if (score <= 4)
        {
            grade = "Elégséges";
        }
        else if (score <= 6)
        {
            grade = "Közepes";
        }
        else if (score <= 8)
        {
            grade = "Jó";
        }
        else
        {
            grade = "Jeles";
        }

        Console.WriteLine($"Osztályzat: {grade}");
        Console.ReadLine();
    }
}