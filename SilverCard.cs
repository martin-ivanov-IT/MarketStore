using System;
using System.Collections.Generic;
using System.Text;

namespace Market_Store
{
    public class SilverCard : ICard
    {
        public double DiscountRate { get; set; } = 2.0;

        public Purchase CalculatePurchase(double turnover, double purchaseValue)
        {
            this.DiscountRate = turnover > 300 ? 3.5 : this.DiscountRate;

            return new Purchase(purchaseValue, this.DiscountRate, turnover);
        }
    }
}
