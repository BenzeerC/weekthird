using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class percentage
    {
        /*Accept marks of 3 subjects physics ,chemistry , maths out of 100. Calculate percentage.
        Display grade as below.
        Percentage > 80% - Grade A
        Percentage > 70% - Grade B
        Percentage > 60% - Grade C
        Percentage< 60% - Grade D*/
        static void Main(string[] args)
        {
            int phy, che, math, total;
            double per;
            Console.WriteLine("Enter physics marks:");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter chemistry marks:");
            che = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter maths marks:");
            math = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Total");
            //total = Convert.ToInt32(Console.ReadLine());
            total = phy + che + math;
            per = total / 3.0;
            Console.WriteLine("Percentage:"+ per);
           // per = Convert.ToDouble(Console.ReadLine());
            

            if (per > 80)
            {
                Console.WriteLine("Excellent: Grade A");
            }
            else if (per > 70)
            {
                Console.WriteLine("Very Good: Grade B");
                 
            }
            else if (per > 60)
            {
                Console.WriteLine("Good: Grade C");
            }
           
            else if(per < 60)
            {
                Console.WriteLine("Average: Grade D");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            
            
        }
            
                
        
        



    }
}
