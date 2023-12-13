using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg a hőmérsékletet Celsiusban (°C): ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = celsius * 9 / 5 + 32;

        Console.WriteLine($"A hőmérséklet Fahrenheitben (°F): {fahrenheit:F2}");

        Console.ReadLine();
    }
}