using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimletekOOP
{
    internal class CimletekOOP2
    {
        static void Main(string[] args)
        {
            Console.Write("Írjon be egy összeget: ");
            int osszeg = Convert.ToInt32(Console.ReadLine());

            var Penz = new Penz();
            var penzek = Penz.getCimleth();

            Console.WriteLine("\n címletek :):");
            Console.WriteLine(Penz.setCimleth(osszeg));

            Console.ReadKey();

        }
    }
}