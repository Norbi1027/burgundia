using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tömbp0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sor = 10;
            int oszlop = 10;
            int felso = 1000;
            int[] tomb = new int[sor,oszlop];
            Random rnd = new Random();

           // tömb feltöltése
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(oszlop, felso);
            }
            //tömb kiiratása
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }
            //tömb kiiratása máshogy

            foreach  (int i in tomb)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
