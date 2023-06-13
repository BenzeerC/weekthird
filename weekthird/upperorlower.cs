using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class upperorlower
    {
        //Write C# Program to check uppercase or lowercase alphabets
        static void Main(string[] args)
        {
            char chr;
            Console.WriteLine("Enter any alphabet to check weather it is Uppercase or Lowercase:");
            Console.WriteLine("-----------------------------------------------------------------");
            chr = Convert.ToChar(Console.ReadLine());

           
            if (chr >= 'A' && chr <= 'Z')
            {
                Console.WriteLine($"Entered alphabet {chr} is Uppercase. ");
            }
            else if (chr >= 'a' && chr <='z')
            {
                Console.WriteLine($"Entered alphabet is {chr} is lowercase.");

            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
