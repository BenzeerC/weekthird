using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class loopfibo
    {
        //Generate Fibonacci series. 0,1, 1, 2, 3, 5,8 ….. k. where k < n . n is entered by use
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 1, num3, i, number;
            Console.WriteLine("Enter a number of element:");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + " \n" + num2 + "");

            for(i =2; i < number; ++i)// loop start from 2

            {
                num3 = num1 + num2;

                Console.WriteLine(num3);

                num1 = num2;

                num2 = num3;
            }
        }
    }
}
