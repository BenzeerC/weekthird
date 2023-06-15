using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class looppalindrome
    {
        //Find out given number is palindrome or not
        //121 - output 121 after revrse same no we need to getback then no is palindrome

        static void Main(string[] args)
        {
            int n, i, r, s = 0;

            Console.WriteLine("Enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());

            for(i= n; i > 0;)
            {
                r = i % 10;
                s = s * 10 + r;
                i = i / 10;
            }
            if (s == n)
            {
                Console.WriteLine($"{n} is a Palindrome number.");
            }
            else
            {
                Console.WriteLine($"{n} is not a Palindrome number.");
            }
        }
    }
}
