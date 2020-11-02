using System;
using System.Collections.Generic;
using System.Text;

namespace Market_Store
{
    public interface ICard
    {
        public double DiscountRate { get; set; }

        Purchase CalculatePurchase(double turnover, double purchaseValue);

    }
}
