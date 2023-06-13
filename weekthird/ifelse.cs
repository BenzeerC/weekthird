using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class ifelse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st no:");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd no:");
            int n2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1 Addition");
            Console.WriteLine("2 Subtraction");
            Console.WriteLine("3 Multiplication");
            Console.WriteLine("4 Division");
            Console.WriteLine("Please select your option");
            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                int sum = n1+ n2;
                Console.WriteLine($"Addition is:{sum}");
            }
            else if (option == 2)
            {
                int sub = 0;
                if(n1 > n2)
                    sub = n1 -n2;
                else
                    sub = n2 - n1;
                Console.WriteLine($"Subtraction is:{sub}");
            }
            else if (option == 3)
            {
                int mul = n2 * n1;
                Console.WriteLine($"Multiplication is {mul}");
            }
            else if(option == 4)
            {
                double div = (double) n1 / n2;
                Console.WriteLine($"Division is: {div}");
            }
            else
            {
                Console.WriteLine(" Invalid Option");
            }
        }
    }
}
