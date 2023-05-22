using System;
using System.IO;

class Program
{

    static void Main()
    {
        bool vege = false;
        while (vege != true)
        {


            Console.WriteLine("Válassz műveletet:");
            Console.WriteLine("1 - Létrehozás és Írás a fájlba");
            Console.WriteLine("2 - Olvasás a fájlból");
            Console.WriteLine("3 - Fájl törlése");
            Console.WriteLine("4 - Meglévő Fájlba írás");
            Console.WriteLine("5 - Kilépés");

            int valasztas = Convert.ToInt32(Console.ReadLine());

            switch (valasztas)
            {
                case 1:
                    Iras();
                    break;
                case 2:
                    Olvasas();
                    break;
                case 3:
                    Torles();
                    break;
                case 4:
                    Hozzaad();
                    break;
                case 5:
                    vege = true;
                    break;
                default:
                    Console.WriteLine("Érvénytelen választás!");
                    break;
            }

            Console.ReadKey();
        }
    }
    static void Iras()
    {
        Console.WriteLine("Add meg a fájlnevet:");
        string fajlnev = Console.ReadLine();

        Console.WriteLine("Írj valamit a fájlba:");
        string tartalom = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(fajlnev))
            {
                writer.WriteLine(tartalom);
            }

            Console.WriteLine("Sikeresen írva a fájlba!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hiba történt az írás során: " + ex.Message);
        }
    }

    static void Olvasas()
    {
        Console.WriteLine("Add meg a fájlnevet:");
        string fajlnev = Console.ReadLine();

        try
        {
            using (StreamReader reader = new StreamReader(fajlnev))
            {
                string tartalom = reader.ReadToEnd();
                Console.WriteLine("A fájl tartalma:");
                Console.WriteLine(tartalom);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hiba történt az olvasás során: " + ex.Message);
        }
    }
    static void Torles()
    {
        Console.WriteLine("Add meg a fájlnevet:");
        string fajlnev = Console.ReadLine();

        File.Delete(fajlnev);
        Console.WriteLine("A file sikeresen törölve.");
    }
    static void Hozzaad()
    {
        Console.WriteLine("Add meg a fájlnevet:");
        string fajlnev = Console.ReadLine();

        Console.WriteLine("Mit szertnél hozzá adni?");
        string hozzaad = Console.ReadLine();

        using (StreamWriter sw = File.AppendText(fajlnev))
        {
            sw.WriteLine(hozzaad);
        }

    }
}
