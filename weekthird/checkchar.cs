using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class checkchar
    {
        //Write a C# program to input any character and check whether it is alphabet, digit or special character 
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter any character to check whether it is alphabet, digit or special character ");
            ch = Convert.ToChar(Console.ReadLine());

            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z')) 
            {
                Console.WriteLine(ch + ": Is an alphabet");
            }
            else if(ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + ": Is a digit");
            } 
            else 
            {
                Console.WriteLine(ch + ": Is a special character");
            }
        }
    }
}
