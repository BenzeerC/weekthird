using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class table
    {
        //accept the no and print it,s table
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a no to print a table");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            for(int i =1; i<=10;  i++)
            {
                
                    Console.WriteLine($"{num*i}");
            }
        }
    }
}
