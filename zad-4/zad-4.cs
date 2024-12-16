using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_4
{
    internal class Program
    {
        static void x(int n, int i)
        {
          i = n % 10; 
           Console.WriteLine(i);
        }

        static void Main(string[] args)
        {
            x(8,4);
        }
    }
}
