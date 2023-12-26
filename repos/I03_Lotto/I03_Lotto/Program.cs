using System;

class Program
{
    static void Main()
    {
        // Nyerőszámok generálása
        Random random = new Random();
        int[] nyeroszamok = new int[5];
        for (int i = 0; i < 5; i++)
        {
            nyeroszamok[i] = random.Next(1, 91); // Véletlen számok 1 és 90 között
        }

        Console.WriteLine("Üdvözöljük a lottójátékban!");
        Console.WriteLine("A nyerőszámokat generáltuk. Most adja meg az öt tippjét.");

        // Felhasználó tippjeinek bekérése
        int[] tippek = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Adja meg a(z) {i + 1}. tippjét (1-90): ");
            tippek[i] = Convert.ToInt32(Console.ReadLine());

            // Ellenőrzés, hogy az érték a megfelelő tartományban van-e
            if (tippek[i] < 1 || tippek[i] > 90)
            {
                Console.WriteLine("Hibás érték! Az értéknek 1 és 90 között kell lennie.");
                i--; // Visszalépés a helyes érték bekéréséhez
            }
        }

        // Találatok számolása
        int talalatok = 0;
        foreach (int tipp in tippek)
        {
            if (Array.IndexOf(nyeroszamok, tipp) != -1)
            {
                talalatok++;
            }
        }

        // Nyeremény kiszámítása
        int nyeremeny = 0;
        switch (talalatok)
        {
            case 0:
                nyeremeny = 0;
                break;
            case 1:
                nyeremeny = 10;
                break;
            case 2:
                nyeremeny = 50;
                break;
            case 3:
                nyeremeny = 100;
                break;
            case 4:
                nyeremeny = 1000;
                break;
            case 5:
                nyeremeny = 10000;
                break;
        }

        // Eredmények kiírása
        Console.WriteLine($"Nyerőszámok: {string.Join(", ", nyeroszamok)}");
        Console.WriteLine($"Tippjei: {string.Join(", ", tippek)}");
        Console.WriteLine($"Találatok száma: {talalatok}");
        Console.WriteLine($"Nyereménye: {nyeremeny} Ft");

        Console.ReadLine();
    }
}