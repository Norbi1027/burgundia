using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cimletOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cimletek c1 = new Cimletek(); //Össze kapcsolás: Item & cs
            Console.WriteLine("Írjon be egy összeget: "); //Adat bekérés
            int pnz = Convert.ToInt32(Console.ReadLine()); //Érték vissza adás
            c1.setCimletHely(pnz); //Kiiratom az érték megoldását
            Console.ReadLine(); //Lezárás
        }
    }
}
