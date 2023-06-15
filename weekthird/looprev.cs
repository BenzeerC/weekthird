using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class looprev
    {//Accept the number from user & print it in reverse order  – > 123  o/p -> 321
        static void Main(string[] args)
        {
            int num, rev_num = 0, rem;
            Console.WriteLine("Enter a number which you like to reverse: ");
            num = Convert.ToInt32(Console.ReadLine());

            while(num != 0)
            {
                rem = num % 10;
                rev_num = rev_num * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("Reversed number is: " + rev_num);
        }
    }
}
