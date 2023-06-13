using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class personal
    {
        /*. Depending on age (decimal number and gender (m / f), print a personal title:

              “Mr.” – a man (gender “m”) – 16 or more years old.
                “Master” – a boy (gender “m”) under 16 years.
                “Ms.” – a woman (gender “f”) – 16 or more years old.
             “Miss” – a girl (gender “f”) under 16 years.*/

        static void Main(string[] args)
        {
            string gender;
            int age;

            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your gender:");
            gender = Convert.ToString( Console.ReadLine());

            if(age <16)
            {
                if (gender == "m")
                    Console.WriteLine("Master");
                else if (gender == "F")
                    Console.WriteLine("Miss");

            }
            else
            {
                if (gender == "m")
                    Console.WriteLine("Mr.");
                else if (gender == "f")
                    Console.WriteLine("Ms.");
            }




        }
    }
}
