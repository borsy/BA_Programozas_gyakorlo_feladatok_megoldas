using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string folderPath = "Boltok"; // A Boltok mappa elérési útja
        List<Product> products = new List<Product>();

        // Ellenőrizzük, hogy a Boltok mappa létezik-e
        if (Directory.Exists(folderPath))
        {
            // Az összes .txt kiterjesztésű fájl beolvasása a mappából
            string[] files = Directory.GetFiles(folderPath, "*.txt");

            foreach (string filePath in files)
            {
                // Fájl neve alapján kinyerjük a bolt nevét
                string storeName = Path.GetFileNameWithoutExtension(filePath);

                // Fájl sorainak beolvasása és termékek létrehozása
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(';'); // Tegyük fel, hogy a termékek neve és ára pontosvesszővel vannak elválasztva
                    if (parts.Length == 2)
                    {
                        string productName = parts[0];
                        double productPrice;
                        if (double.TryParse(parts[1], out productPrice))
                        {
                            Product product = new Product(storeName, productName, productPrice);
                            products.Add(product);
                        }
                    }
                }
            }

            // Termékek csoportosítása és a legolcsóbbak kiválasztása
            var cheapestProducts = products.GroupBy(p => p.Name)
                .Select(group => group.OrderBy(p => p.Price).First())
                .ToList();

            // Kiírjuk a legolcsóbb termékeket
            Console.WriteLine("Legolcsóbb termékek:");
            foreach (Product product in cheapestProducts)
            {
                Console.WriteLine($"{product.Store}: {product.Name} - {product.Price} Ft");
            }
        }
        else
        {
            Console.WriteLine("A 'Boltok' mappa nem található.");
        }

        Console.ReadLine();
    }
}

class Product
{
    public string Store { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string store, string name, double price)
    {
        Store = store;
        Name = name;
        Price = price;
    }
}