using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class switchcase
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Enter 1st no:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd no:");
            n2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");
            Console.WriteLine("5: Module");
            
            Console.WriteLine("Select your option:");
            int op = Convert.ToInt32(Console.ReadLine());

            switch(op)
            {
                case 1:
                    Console.WriteLine("You have selected Addition");
                   int sum = n1 + n2;
                    Console.WriteLine($"sum is:{sum}");
                    break;

                case 2:
                    Console.WriteLine("You have selected Subtraction");
                    int sub = n1 - n2;
                    Console.WriteLine($"Sub is:{sub}");
                    break;

                case 3:
                    Console.WriteLine("You have selected Multiplication");
                    int mul = n1 * n2;
                    Console.WriteLine($"Mul is: {mul}");
                    break;

                case 4:
                    Console.WriteLine("You have selected division");
                    double div =(double) n1 / n2;
                    Console.WriteLine($"Div is: {div}");
                    break;

                case 5:
                    Console.WriteLine("You have selected module");
                    int mod = n1 % n2;
                    Console.WriteLine($"Mod is: {mod}");
                    break;

                default:
                    Console.WriteLine(" Default option");

                    break;



            }
        }
    }
}
