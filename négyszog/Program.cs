using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace négyszog
{
    class negyszog
    {
        //osztályváltozó
        private int a;
        private int b;
        private int terulet;
        private int kerulet;

        //konstruktor
        public negyszog() { }

        public negyszog(int a ,int b)
        {
            this.a = a;
            this.b = b;
        }

        //metódusok
        public void setA(int a)
        {
            if (a> 1000)
            {
                Console.WriteLine("Az oldal nem lehet nagyobb mint 1000.");
            }else
            this.a = a;
        }
        public void setB(int b)
        {
            this.b = b;
        }
        public int getA()
        {
            return this.a;
        }
        public int getB()
        {
            return this.b;
        }public void setTerulet()
        {
            this.terulet = this.a * this.b;
        }
        public int getTerulet()
        {
            return this.terulet;
        }
        public void setKerulet()
        {
            this.kerulet = 2 * (this.a + this.b);
        }
        public int getKerulet()
        {
            return this.kerulet;
        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Első példa
            negyszog n1= new negyszog();

            Console.WriteLine($"Az n1 négyszög oldalai: a={n1.getA()},b={n1.getB()}");
            n1.setA(5);
            n1.setB(6);
            kiir(n1.getA(),n1.getB());
            n1.setTerulet();
            n1.setKerulet();
            kiirkt(n1.getTerulet(), n1.getKerulet());

            //2.feladat
            negyszog n2= new negyszog(6,2);
            kiir(n2.getA(),n2.getB());
            n2.setTerulet();
            n2.setKerulet();
            kiirkt(n2.getTerulet(), n2.getKerulet());

            Console.ReadKey();
        }
        static private void kiir(int a, int b)
        {
            Console.WriteLine($"Az n1 négyszög oldalai: a={a},b={b}");
        }
        static private void kiirkt(int a, int b)
        {
            Console.WriteLine($"A négyszög területe = {a},kerülete = {b}");
        }
    }
}
