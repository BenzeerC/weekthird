using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class while_table
    {
        //Accept the number from user and print a table

        static void Main(string[] args)
        {
            int num,i=1;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());

            while(i<=10)
            {
                Console.WriteLine(num * i);
                i++;
            }

        }
    }
}
