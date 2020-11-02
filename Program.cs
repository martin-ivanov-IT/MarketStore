using System;

namespace Market_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            IWriter writer = new ConsoleWriter();
            ICard BronzeCard = new BronzeCard();
            ICard SilverCard = new SilverCard();
            ICard GoldCard = new GoldCard();
            Purchase firstPurchase = BronzeCard.CalculatePurchase(0, 150);
            Purchase secondPurchase = SilverCard.CalculatePurchase(600, 850);
            Purchase thirdPurchase = GoldCard.CalculatePurchase(1500, 1300);
            writer.PrintPurchase(firstPurchase);
            Console.WriteLine();
            writer.PrintPurchase(secondPurchase);
            Console.WriteLine();
            writer.PrintPurchase(thirdPurchase);
        }
    }
}

