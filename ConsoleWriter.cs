using System;
using System.Collections.Generic;
using System.Text;

namespace Market_Store
{
    public class ConsoleWriter : IWriter
    {
        public void PrintPurchase(Purchase purchase)
        {           
            Console.WriteLine($"Purchase value: ${string.Format("{0:0.00}", purchase.PurchaseValue)}");
            Console.WriteLine($"Discount rate: {string.Format("{0:0.0}", purchase.DiscountRate)}%");
            Console.WriteLine($"Discount: ${string.Format("{0:0.00}", purchase.Discount)}");
            Console.WriteLine($"Total: ${string.Format("{0:0.00}", purchase.Total)}");
        }
    }
}
