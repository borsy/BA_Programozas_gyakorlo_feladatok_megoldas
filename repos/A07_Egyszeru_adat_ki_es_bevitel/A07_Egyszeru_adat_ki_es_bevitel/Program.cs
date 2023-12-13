using System;

class Program
{
    static void Main()
    {
        Console.Write("Kérem, adja meg a hőmérsékletet Fahrenheitben (°F): ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        double celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine($"A hőmérséklet Celsiusban (°C): {celsius:F2}");

        Console.ReadLine();
    }
}