﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            int n1 = n;
            int i = 0;
            double c = 0;
            while (n1 > 0)
            {
                n1 = n1 / 10;
                i++;
            }
            i = i - 1;
            while (n > 0)
            {
                int r = n % 10;
                n = n / 10;
                c = c + Math.Pow(10, i) * r;
                i--;
            }
            Console.WriteLine("c= " + c);
        }
    }
}
