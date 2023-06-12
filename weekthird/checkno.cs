using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class checkno
    {
        //WAP to accept a number from the user & check number is +ve or -ve or zero.

        static void Main(string[] args)
        {
            int no;
            Console.WriteLine("Enter a no:");
            no = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Entered no is:");
            if (no > 0)
            {
                Console.WriteLine("Entered no is Positive");
            }
            else if (no < 0)
            {
                Console.WriteLine("Entered no is negative");
            }
            else 
            {
                Console.WriteLine("Entered no is zero");
            }
        }
    }
}
