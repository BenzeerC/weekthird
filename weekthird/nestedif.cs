using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class nestedif
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            int n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    Console.WriteLine($"{n1} is greatest");
                }
                else
                {
                    Console.WriteLine($"{n3} is greatest");
                }
            }
            else if (n2 > n3)
            {
                Console.WriteLine($"{n2} is greatest");
            }
            else
            {
                Console.WriteLine($"{n3} is greatest");
            }





        }
    }
}
