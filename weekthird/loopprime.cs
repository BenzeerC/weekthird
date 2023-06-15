using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class loopprime
    {
        //Find if given number is prime or not.
        static void Main(string[] args)
        {
            int n, a=0;
            Console.WriteLine("Enter the number to check number is prime or not: ");
            n = Convert.ToInt32(Console.ReadLine());
            //a = Convert.ToInt32(Console.ReadLine());
           // Console.WriteLine("Number to check");

            for(int i = 2; i<= n/2; i++)
            {
                if (n % i == 0)
                    a++;
            }
            if(a == 0)
            {
                Console.WriteLine($"{n} This number is Prime.");
            }
            else
            {
                Console.WriteLine($"{n} This number is not a prime number.");
            }
        }
    }
}
