using System;
using TheDeliciousFoodPlace.FoodProducts;

namespace TheDeliciousFoodPlace.FoodFactories
{
    public class MorningFoodFactory : IFoodProductFactory
    {
        public FoodProduct GetFoodProduct(string selectedProduct)
        {
            switch (selectedProduct)
            {
                case "Banica":
                    return new Banica();

                case "Boza":
                    return new Boza();

                case "Hotdog":
                    return new Hotdog();

                case "Musli":
                    return new Musli();

                case "Coffee":
                    return new Coffee();

                default:
                    throw new Exception("case not handled");
            }
        }
    }
}