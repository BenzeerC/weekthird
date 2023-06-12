using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class vowel
    {
        //WAP to accept a character from user & check whether it is vowel or not
        static void Main(string[] args)
        {
            char letter;
            Console.WriteLine("Enter a charater");
            letter = char.Parse(Console.ReadLine());
            Console.WriteLine("Entered Character is:");
            //letter = Convert.ToChar(Console.ReadKey(true));
            if (letter == 'A' || letter == 'a' || letter =='E' || letter == 'e' || letter == 'I' || letter == 'i' || letter == 'O' || letter =='o' || letter =='U' || letter=='u')
            {
                Console.WriteLine("Vowel{0}",letter);

            }
            
            else
            {
                Console.WriteLine("Not a vowel{0}",letter);
            }
            
            

        
        }
    }
}
