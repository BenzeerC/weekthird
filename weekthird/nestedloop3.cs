using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class nestedloop3
    {
        /*
                 *
            
             *   *   *
        
         *   *    *   *   *
      
       *   *  *   *   *   *  *
    
     *  *  *  *  *  *  *   *   *
         
         */

        // 5 rows (for int i= 1; i<=5; i++)                                    
        // space (for int j= 5; j>=i; J--)
        // printing star(for int k= 1; K>=(i * 2)-1; k++)
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write("   ");
                }
                for (int k = 1; k <= (i * 2) - 1; k++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}
