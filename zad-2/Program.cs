using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    internal class Program
    {
        static void x()
        {
            Console.WriteLine("x=");
            Console.WriteLine("x+=5");
        }
        static void y()
        {
            Console.WriteLine("y=");
            Console.WriteLine("y*=x");
        }
        static void z()
        {
            Console.WriteLine("z=");
            Console.WriteLine("z= 10*y");
        }
        static void Main(string[] args)
        {
            x();
            y();
            z();

        }
    }
}
