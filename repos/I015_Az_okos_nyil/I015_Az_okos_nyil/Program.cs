using System;

class DartsJatek
{
    static void Main()
    {
        // Darts tábla inicializálása
        DartTabla dartTabla = new DartTabla();

        // Játékosok inicializálása
        Jatekos jatekos1 = new Jatekos();
        Jatekos jatekos2 = new Jatekos();

        // Játék ciklus
        while (!jatekos1.JatekVege && !jatekos2.JatekVege)
        {
            // Játékos 1 dobása
            Console.WriteLine("Játékos 1 dob...");
            jatekos1.Dobas(dartTabla);

            // Játékos 2 dobása
            Console.WriteLine("Játékos 2 dob...");
            jatekos2.Dobas(dartTabla);

            // Játékosok pontjainak kiírása
            Console.WriteLine($"Játékos 1 pontszáma: {jatekos1.Pontszam}");
            Console.WriteLine($"Játékos 2 pontszáma: {jatekos2.Pontszam}");
        }

        // Győztes kijelölése és kiíratása
        if (jatekos1.JatekVege)
        {
            Console.WriteLine("Játékos 2 győzött!");
        }
        else
        {
            Console.WriteLine("Játékos 1 győzött!");
        }
    }
}

class DartTabla
{
    public int Dobas()
    {
        // Egyszerűen visszaad egy véletlenszerű pontszámot
        Random random = new Random();
        return random.Next(1, 101);
    }
}

class Jatekos
{
    private int pontszam;
    private bool jatekVege;

    public int Pontszam
    {
        get { return pontszam; }
    }

    public bool JatekVege
    {
        get { return jatekVege; }
    }

    public Jatekos()
    {
        pontszam = 0;
        jatekVege = false;
    }

    public void Dobas(DartTabla dartTabla)
    {
        int dobasEredmeny = dartTabla.Dobas();
        Console.WriteLine($"Dobás eredménye: {dobasEredmeny}");

        // Itt implementálhatod a pontszámítást és a játék vége ellenőrzést
        // Például: pontszam += dobasEredmeny;
        // Ha elérte a győzelmi pontszámot, akkor jatekVege = true;
    }
}
