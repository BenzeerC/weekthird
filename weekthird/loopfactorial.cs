using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class loopfactorial
    {
        //Find the factorial of a given number.
        // 6!- 6 factorial 6*5*4*3*2*1=
        static void Main(string[] args)
        {
            int i, num, fact = 1;

            Console.WriteLine("Enter a number to calculate factorial of that number");
            num = Convert.ToInt32(Console.ReadLine());

            for(i =1; i<= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Given number factorial is: " + fact);
        }
    }
}
