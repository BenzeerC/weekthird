using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class loopamstrong
    {
        //. Check if given number is Armstrong or not
        // 173 - (1*1*1) +(7*7*7) + (3*3*3)
        //(1*1*1) = 1
        //(7*7*7) = 343
        //(3*3*3) = 27
        //Armstrong no is = 1 + 343 + 27 = 371 (173 is not a armstron no)

        static void Main(string[] args)
        {
            int num, rem, temp, sum = 0;

            Console.WriteLine("Check the given no is Armstrong number or not");

            Console.WriteLine("\nEnter your number to check");
            num = Convert.ToInt32(Console.ReadLine());

           // newnum = num;

           //// while (num > 0)
           // {
           //     rem = num % 10;
           //     sum = sum + (rem * rem * rem);
           //     num = num / 10;
           // }

            for(temp =num; num != 0; num= num / 10)
            {
                rem = num % 10;
                sum = sum + (rem *rem *rem);
            }

            

            if(sum == temp)
            {
                Console.WriteLine(temp +  "\tIs a Armstrong number");
            }
            else 
            {
                Console.WriteLine(temp +  "\tIs not a Armstrong number");
            }
        }
    }
}
