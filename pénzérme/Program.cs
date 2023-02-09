using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pénzérme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a pénz értékét: ");
            int penz = int.Parse(Console.ReadLine());
            while (penz > 0)
            {
                if (penz / 20000 > 1)
                {
                    int ertek1 = penz / 20000;
                    penz = penz - (ertek1 * 20000);
                    Console.WriteLine(penz);
                    Console.WriteLine($"{ertek1}darab 20ezres.");
                }
                else if (penz / 10000 > 1)
                {
                    int ertek2 = penz / 10000;
                    penz = penz - (ertek2 * 10000);
                    Console.WriteLine(penz);
                    Console.WriteLine($"{ertek2}darab 10ezres.");
                }
            }

            Console.ReadKey();
        }
    }
}
