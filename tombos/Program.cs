using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace tombos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("x");
            int x = int.Parse( Console.ReadLine());

            Console.WriteLine("y");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("z");
            int z = int.Parse(Console.ReadLine());
            if (y > z)
            {
                Console.WriteLine("Csere volt!");
                y = y + z;
                z = y + z;
                x = y + z;
            }
            int[] sz = new int[x];
            for (int i = 0;i < sz.Length; i++)
            {
                sz[i] = rnd.Next(y,z);
            }
            Console.WriteLine("Tömb feltöltve!");
            int max = sz[sz.Max()];
            int min = sz[sz.Min()];
            int ossz = 0;
            for (int i = 0; i < sz.Length; i++)
            {
                ossz = ossz + i;
            }
            int atlag = ossz / sz.Length;

            for (int i = 0; i < sz.Length; i++)
            {
                if (i%1 ==0 && i%i ==0)
                {

                }
            }

                Console.WriteLine("Legnagyobb:{0}",max);
            Console.WriteLine("Legkisebb:{0}", min);
            Console.WriteLine("Összesen:{0}", ossz);
            Console.WriteLine("átlag:{0}", atlag);
            Console.ReadKey();  
        }
    }
}
