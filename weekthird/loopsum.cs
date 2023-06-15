using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace weekthird
{
    internal class loopsum
    {
        //Find sum of all digits of a number.
        static void Main(string[] args)
        {
            int n, r, sum = 0;
            Console.WriteLine("Enter a number:");
            n = int.Parse(Console.ReadLine());

            while(n > 0)
            {
                r = n % 10;
                sum = sum + r;
                n = n / 10;
            }
            Console.WriteLine("Sum is " + sum);
        }
        

        
    }
}
