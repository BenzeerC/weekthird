using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekthird
{
    internal class profitloss
    {
        //Write a C# Sharp program to calculate profit and loss on a transaction
        // Formula  ** Profit= SellingPrice-Costprice   
        //          ** Loss = CostPrice - SellingPrice
        static void Main(string[] args)
        {
            double sellingPrice, costPrice, profit;
            Console.WriteLine("Calculate Profit and Loss");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Enter selling price:");
            sellingPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter cost price: ");
            costPrice = double.Parse(Console.ReadLine());

            if (sellingPrice > costPrice)
            {
                profit = sellingPrice - costPrice;
                Console.WriteLine("Profit amount:{0}", profit);
            }
            else if(costPrice > sellingPrice)
            {
                profit = costPrice - sellingPrice;
                Console.WriteLine("Loss amount:{0}", profit);
            }
            else
            {
                Console.WriteLine("You are running in no profit and no loss condition.");
            }
        }
    }
}
