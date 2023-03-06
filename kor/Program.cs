using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kor
{
    class Kor
    {
        private int r;
        private double terulet;
        private double kerulet;


        public Kor() { }

        public Kor(int r)
        {
            this.r = r;
        }
        public void setR(int r)
        {
            this.r = r;
        }
        public int getR()
        {
            return this.r;
        }
        public void setTerulet()
        {
            this.terulet = this.r * this.r * Math.PI;
        }
        public double getTerulet()
        {
            return this.terulet;
        }
        public void setKerulet()
        {
            this.kerulet = 2 * (this.r * Math.PI);
        }
        public double getKerulet()
        {
            return this.kerulet;
        }
    }
        class Henger : Kor
        {
            private int m;
            private double felszin;
            private double terfogat;

            public Henger() : base() { }
            public Henger(int r, int m) : base(r)
            {
                this.m = m;
            }
            public void setM(int m) { this.m = m; }
            public void setKor()
            {
                base.setKerulet();
                base.setTerulet();
            }
            public void setTerfogat()
            {
                this.terfogat = base.setTerulet * this.m();
            }
            public void setFelszin()
            {
                this.felszin = (2 * Math.Pow(r, 2) * Math.PI) + (2 * this.r * Math.PI * this.m);
            }

            public double getTerfogat() { return this.terfogat; }
            public double getFelszin() { return this.felszin; }


        }




    internal class Program
    {
        static void Main(string[] args)
        {
            Kor k = new Kor();
            k.setR(3);
            k.setTerulet();
            k.setKerulet();

            Console.WriteLine();
            Console.WriteLine("niu");
             Henger h = new Henger(); 
            h.setM(3);
            h.setTerfogat();
            h.setFelszin();

            Console.WriteLine($"A kör területe:{k.getTerulet()},kerülete:{k.getKerulet()}");
            Console.WriteLine($"A kör területe:{h.getTerulet()},kerülete:{h.getFelszin()}");
            Console.ReadKey();
        }
    }
}

