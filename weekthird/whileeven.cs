using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class whileeven
    {
        //print all even numbers from 1-100

        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 100)
            {
                if(i%2 == 0)
                    Console.WriteLine(i);
                i++;
            }
        }
    }
}
