using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class swapno
    {
        //Swap values of two integer variables without using a third variable.
        static void Main(string[] args)
        {
            int val1=7, val2=10;
            Console.WriteLine("Before swap val1:"+val1);
            
            Console.WriteLine("Before swap val2:"+val2);
            

            val1 = val1 * val2;// val1=70 (7*10)
            val2 = val1 / val2;// val2=7  (70/10)
            val1 = val1 / val2;// val1=10 ( 70/7)
            Console.WriteLine($"After swap no 1 is:{val1}");
            Console.WriteLine($"After swap no 2 is:{val2}");
        }
    }
}
