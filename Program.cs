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
            Purchase FirstPurchase = BronzeCard.CalculatePurchase(0, 150);
            Purchase SecondPurchase = SilverCard.CalculatePurchase(600, 850);
            Purchase ThirdPurchase = GoldCard.CalculatePurchase(1500, 1300);
            writer.PrintPurchase(FirstPurchase);
            Console.WriteLine();
            writer.PrintPurchase(SecondPurchase);
            Console.WriteLine();
            writer.PrintPurchase(ThirdPurchase);
        }
    }
}

