using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    internal class zad_2
    { 
       
        static void X(int x, int y, int z)
        { 
           x += 5;
           y *= x;
           z = 10*y;
          Console.WriteLine(x);
          Console.WriteLine(y);
           Console.WriteLine(z);
        } 
       
      
        static void Main(string[] args)
        {
            X(7,8,4);
          
        }
         
    }
}
