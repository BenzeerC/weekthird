using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class transpotation
    {
        /* A student has to travel n kilometers. He can choose between three types of transportation:

                 Taxi. Starting fee: 0.70 EUR. Day rate: 0.79 EUR/km. Night rate: 0.90 EUR/km.
                 Bus. Day / Night rate: 0.09 EUR/km. Can be used for distances of minimum 20 km.
                Train. Day / Night rate: 0.06 EUR/km. Can be used for distances of minimum 100 km.
                Write a program that reads the number of kilometers n and period of the day (day or night) and calculates the fare amount*/

        static void Main(string[] args)
        {
            double totalamt;
            Console.WriteLine("1. Taxi");
            Console.WriteLine("2. Bus");
            Console.WriteLine("3. Train");
            Console.WriteLine("select any one option");
            int op1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. Day ");
            Console.WriteLine("2. Night ");
            Console.WriteLine("select any one option");
            int op2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter KM to trvel");
            int km = Convert.ToInt32(Console.ReadLine());

            if (op1 == 1)//taxi
            {
                if (op2 == 1)//day
                {
                    totalamt = km * 2.5;
                    Console.WriteLine($"Transport by taxi day charge is {totalamt}");
                }
                else if (op2 == 2)
                {
                    totalamt = km * 4.5;
                    Console.WriteLine($"Transport by taxi night charge is {totalamt}");
                }
            }
            else if (op1 == 2)// bus
            {
                if (km >= 20 && op2 == 1)//day
                {
                    totalamt = km * 3.5;
                    Console.WriteLine($"Transport by bus day charge is {totalamt}");
                }
                else if (km >= 20 && op2 == 2)//night
                {
                    totalamt = km * 5.5;
                    Console.WriteLine($"Transport by bus night charge is {totalamt}");
                }
                else
                {
                    Console.WriteLine("No transport available");
                }
            }
            else if (op1 == 3)// train
            {
                if (km >= 100 && op2 == 1)//day
                {
                    totalamt = km * 6.5;
                    Console.WriteLine($"Transport by train day charge is {totalamt}");
                }
                else if (km >= 100 && op2 == 2)//night
                {
                    totalamt = km * 8.5;
                    Console.WriteLine($"Transport by train night charge is {totalamt}");
                }
                else
                {
                    Console.WriteLine("No transport available");
                }
            }
            else
            {
                Console.WriteLine("Wrong option selected..");
            }
        }

    }
}