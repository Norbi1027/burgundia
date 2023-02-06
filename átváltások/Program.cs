using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace átváltások
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add meg a hőmérséklet értékét.");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Add meg mibe szertnéd válatni.(c/f)");
            string b = Console.ReadLine();

        if (b == "c")
            {
                int c =(a - 32) / 9 * 5;
                Console.WriteLine($"A kapott érték:{c}fok");
                    }
        else if (b == "f"){
                int f = a / 5 * 9 + 32;
                Console.WriteLine($"A kapott érték:{f}fahrenheit");
          
            }
            Console.ReadKey();
        }
    }
}
