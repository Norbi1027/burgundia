using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sziget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = "01110101010111011110101011010101";
            int islandCount = 0; //szigetek száma
            int maxIslandLength = 0; //legnagyobb sziget hossza
            int i = 0; //vízről szigetre lép
            while (i < data.Length)
            {
                if (data[i] == '1')
                {
                    ++islandCount;
                    int j = i;
                    int tmp = 0;
                    while (j < data.Length && data[j] == '1')
                    {
                        ++j;
                        ++tmp;
                    }
                    i = j;
                    if (tmp > maxIslandLength)
                    { maxIslandLength = tmp; 
                    } 
                } 
                else 
                { ++i; 
                } 
              
            }
            Console.WriteLine("Szigetek száma:{0}",islandCount);
            Console.WriteLine("leghosszabb sziget:{0}",maxIslandLength);
            Console.ReadKey();
        }

    }
}
