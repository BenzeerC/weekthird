using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class nestedloop5
    {
        /*
         * * * *
           * * *
             * *
               *
               */

        static void Main(string[] args)
        {
            for(int i= 1; i <= 5; i++)//row
            {
                for(int j= 1; j<=i-1; j++)//column
                {
                    Console.Write("   ");
                }
                for(int k= 5; k >= i; k--)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}
