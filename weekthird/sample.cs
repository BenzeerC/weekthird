﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class sample
    {
        static void Main(string[] args)
        {
            int i, j, n;

            Console.Write("\n\n");
            Console.Write("Display the pattern like pyramid containing odd number of asterisks:\n");
            Console.Write("----------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of rows for this pattern :");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}
