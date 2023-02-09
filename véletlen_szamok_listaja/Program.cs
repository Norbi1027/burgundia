using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace véletlen_szamok_listaja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c1 = 0;
            Console.WriteLine("Első szám: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("második szám: ");
            int b = int.Parse(Console.ReadLine());
            Random random1 = new Random();
            c1 = random1.Next(a,b);
            for (int j = 0; j <3; j++)
            {
                Console.WriteLine(random1.Next(a,b));
            }
            Console.ReadLine();

        }
    }
}
