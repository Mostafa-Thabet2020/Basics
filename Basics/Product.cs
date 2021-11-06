using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class Product
    {
        public string name;
        public DateTime prudactionDate;
        public int ExpireAfter;
        public double Price;
        public double Cost;

        private double profit;
        // function to cal net profit
        public double CalProfit()
        {
            profit = Price - Cost;
            return profit;
        }
    }
}
