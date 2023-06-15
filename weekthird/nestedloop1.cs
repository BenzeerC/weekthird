using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class nestedloop1
    {
        /*
         1
         12
         123
         1234
         12345 
         */
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)//row
            {
                for(int j = 1; j <= i; j++)//column
                {
                    Console.Write(j);
                }
                Console.WriteLine( );
            }
        }
       

    }
}
