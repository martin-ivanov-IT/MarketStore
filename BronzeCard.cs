using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Market_Store
{
    public class BronzeCard : ICard
    {
        public double DiscountRate { get; set; }

        public Purchase CalculatePurchase(double turnover, double purchaseValue)
        {
            if (turnover > 300)
            {
                this.DiscountRate = 2.5;
            }
            else if (turnover < 100)
            {
                this.DiscountRate = 0.0;
            }
            else 
            {
                this.DiscountRate = 1.0;
            }

            return new Purchase(purchaseValue, this.DiscountRate, turnover);
        }
    }
}
