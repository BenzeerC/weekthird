using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class swaptwovalues
    {
        //Swap values of two interger variables using third variable
        static void Main(string[] args)
        {
            int val1, val2, swap;
            Console.WriteLine("Enter 1st value:");
            val1 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter 2nd value:");
            val2 = Convert.ToInt32(Console.ReadLine());
            //if (val1 == val2)
            //{
            //    swap = val1;
            //    Console.WriteLine("")
            //}


            swap = val1;
            val1 = val2;
            val2 = swap;
            Console.WriteLine("After swapping:");
            Console.WriteLine($"First no:{val1}");
            Console.WriteLine($"Second no:{val2}");
            Console.ReadLine();




        }
    }
}
