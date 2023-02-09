using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Respirációs_kvóciens_kiszámítása
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írd be a co2-t: ");
            double co2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Írd be au o2-t: ");
            double o2 = Convert.ToDouble(Console.ReadLine());

            double osszeg = co2 / o2;
            Console.WriteLine(osszeg);
            if (osszeg == 0.8) {
                Console.WriteLine("Az érték megfelelő.");
            
            }
            else if (osszeg >0.8)
            {
                Console.WriteLine("A szénhidrátbol nyeri az energiát.");
            }
            else if (osszeg <0.8)
            {
                Console.WriteLine("A zsírbol nyeri az energiát.");
            }
            Console.ReadLine();
        }
    }
}
