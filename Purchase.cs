using System;
using System.Collections.Generic;
using System.Text;

namespace Market_Store
{
    public class Purchase
    {
        public Purchase(double purchaseValue, double discountRate, double turnover)
        {
            if (purchaseValue < 0)
            {
                throw new ArgumentException("Parameter can not be negative", "purchaseValue");
            };
            if (turnover < 0)
            {
                throw new ArgumentException("Parameter can not be negative", "turnover");
            };
            this.PurchaseValue = purchaseValue;
            this.DiscountRate = discountRate;
            this.Discount = purchaseValue * (discountRate/100);
            this.Total = purchaseValue - this.Discount;
            this.Turnover = turnover;
        }
        public double PurchaseValue { get; }

        public double DiscountRate { get; }

        public double Discount { get; }

        public double Total { get; }

        public double Turnover { get; }

    }
}
