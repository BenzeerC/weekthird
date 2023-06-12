using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class bill
    {
        /*Write a C# program to input electricity consumption unit and calculate total electricity bill according to the given condition: 
         * For first 50 units Rs. 0.50/unit For next 100 units Rs. 0.75/unit For next 100 units Rs. 1.20/unit For unit above 250 Rs. 1.50/unit An additional surcharge of
         * 20% is added to the bill */
        static void Main(string[] args)
        {
            double unit;
            double amt, total, surcharges;
            Console.WriteLine("Enter total units consumed:");
            unit = Convert.ToDouble(Console.ReadLine());

            if(unit <= 50)
            {
                amt = unit * 0.50;
            }
            else if (unit <= 150)
            {
                amt = 25+((unit - 50) * 0.75);
            }
            else if (unit <= 250)
            {
                amt = 100 + ((unit - 150) * 1.20);
            }
            else 
            {
                amt = 220 + ((unit - 200) * 1.50);
            }
            surcharges = amt * 0.20;
            total = amt + surcharges;
            Console.WriteLine($"Electricity bill: {total}");

        }
        


    }
}
