using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace weekthird
{
    internal class findno
    {
        //Write a C# program to find maximum between three numbers (using logical operator)
        static void Main(string[] args)
        {
            int num1, num2, num3, max;
            //max = num1;
            Console.WriteLine("Find the largest of three numbers:");
            Console.WriteLine("Enter the first no:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the secound no:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third no:");
            num3 = Convert.ToInt32(Console.ReadLine());
            //max = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(" Largest no is:");

            if ((num1 > num2) && (num1 > num3))
            {
                max = num1;
            }
            else if ((num2 > num1) && (num2 > num3))
            {
                max = num2;
            }
            else
            {
                max = num3;
            }
        
            
                
            Console.WriteLine("The largest no is {0}",max);






        }
       

        
            
        


    }
}
