using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class switchcase2
    {
        static void Main(string[] args)
        {
            //int num;
            //Console.WriteLine("Enter :");
            //num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nChoose your number to print your lucky day:");
            Console.WriteLine("0: Sunday");
            Console.WriteLine("1: Monday");
            Console.WriteLine("2: Tuesday");
            Console.WriteLine("3: Wednesday");
            Console.WriteLine("4: Thursday");
            Console.WriteLine("5: Friday");
            Console.WriteLine("6: Saturday");
            Console.WriteLine("Enter your number:");
            int option = Convert.ToInt32(Console.ReadLine());
            

            switch(option)
            {
                case 0:
                    Console.WriteLine("Sunday  is your lucky day");
                    break;
                case 1:
                    Console.WriteLine("Monday is your lucky day");
                    break;
                case 2:
                    Console.WriteLine("Tuesday is your lucky day");
                    break;
                case 3:
                    Console.WriteLine("Wednesday is your lucky day");
                    break;
                case 4:
                    Console.WriteLine("Thursday is your lucky day");
                    break;  
                case 5:
                    Console.WriteLine("Friday is your lucky day");
                    break;
                case 6:
                    Console.WriteLine("Saturday is your lucky day");
                    break;
                default:
                    Console.WriteLine("ooh wrong number entered");
                    break;
            }
        }
    }
}
