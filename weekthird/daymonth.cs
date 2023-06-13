using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace weekthird
{
    internal class daymonth
    {
        //Write C# Sharp program to read any Month Number in integer and display Month name(use switch case)
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any month number and you will get month name:");
            Console.WriteLine("---------------------------------------------------");
            //int num = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("1: January");
            //Console.WriteLine("2: February");
            //Console.WriteLine("3: March");
            //Console.WriteLine("4: April");
            //Console.WriteLine("5: May");
            //Console.WriteLine("6: June");
            //Console.WriteLine("7: July");
            //Console.WriteLine("8: August");
            //Console.WriteLine("9: September");
            //Console.WriteLine("10: October");
            //Console.WriteLine("11 : November");
            //Console.WriteLine("12: December");
            int num = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"You have choose the number {num} month is:");

            switch(num)
            {
                case 1: Console.WriteLine("January");
                    break; 
                case 2: Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine(" Invalied number entered.");
                    break;

            }
        }
    }
}
