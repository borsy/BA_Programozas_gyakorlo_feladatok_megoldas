using System;

class Program
{
    static void Main()
    {
        DateTime maiDatum = DateTime.Now;
        DateTime elozoEvDatum = maiDatum.AddYears(-1);

        string napNev = MeghatarozNapnevet(elozoEvDatum.DayOfWeek);

        Console.WriteLine($"Az aktuális dátum: {maiDatum:yyyy-MM-dd}");
        Console.WriteLine($"Az előző év dátuma: {elozoEvDatum:yyyy-MM-dd}");
        Console.WriteLine($"Az előző évben az aktuális hónap-nap {napNev} napra esett.");

        Console.ReadLine();
    }

    static string MeghatarozNapnevet(DayOfWeek nap)
    {
        switch (nap)
        {
            case DayOfWeek.Sunday:
                return "vasárnap";
            case DayOfWeek.Monday:
                return "hétfő";
            case DayOfWeek.Tuesday:
                return "kedd";
            case DayOfWeek.Wednesday:
                return "szerda";
            case DayOfWeek.Thursday:
                return "csütörtök";
            case DayOfWeek.Friday:
                return "péntek";
            case DayOfWeek.Saturday:
                return "szombat";
            default:
                return "ismeretlen";
        }
    }
}