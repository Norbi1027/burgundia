using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    internal class Program
    {
        enum Animal {cat = 2,wolf = 5,tiger = 10,dog = 3 };

        static void Main(string[] args)
        {
            Animal a = Animal.wolf;
            Animal b = Animal.tiger;

            int c = 0;
            string s = " ";

            int? x = null;
            

            if (a != b)
            {
                Console.WriteLine("Az egér nem macska");
            }
            Console.WriteLine("Macska indexe: {0}",(int)Animal.cat);
            Console.WriteLine("Macska indexe: {0}", (int)Animal.wolf);
            Console.WriteLine("Macska indexe: {0}", (int)Animal.tiger);
            Console.WriteLine("Macska indexe: {0}", (int)Animal.dog);
            Console.ReadKey();
        }
    }
}
