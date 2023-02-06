﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            if (args.Length == 0)
            {
                Random random= new Random();
                number = random.Next(100);
            }
            else
            {
                number = int.Parse(args[0]);
            }
            for (int i = 1; i <= 10; ++i)
            {
                Console.WriteLine("{0} x {1} = {2}",i,number,i * number);
            }
            Console.ReadKey();
        }
    }
}
