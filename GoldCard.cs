using System;
using System.Collections.Generic;
using System.Text;

namespace Market_Store
{
    public class GoldCard : ICard
    {
        public double DiscountRate { get; set; } = 2.0;

        public Purchase CalculatePurchase(double turnover, double purchaseValue)
        {
            this.DiscountRate = turnover > 100 ? this.DiscountRate += (turnover / 100) : this.DiscountRate;
            this.DiscountRate = this.DiscountRate > 10 ? 10 : this.DiscountRate;

            return new Purchase(purchaseValue, this.DiscountRate, turnover);
        }
    }
}
