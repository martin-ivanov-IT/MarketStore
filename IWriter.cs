using System;
using System.Collections.Generic;
using System.Text;

namespace Market_Store
{
    public interface IWriter
    {
        void PrintPurchase(Purchase purchase);
    }
}
