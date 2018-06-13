using System;
using TheDeliciousFoodPlace.FoodProducts;

namespace TheDeliciousFoodPlace
{
    public class LunchFoodFactory : IFoodProductFactory
    {
        public FoodProduct GetFoodProduct(string selectedProduct)
        {
            switch (selectedProduct)
            {
                case "Chicken soup":
                    return new ChickenSoup();

                case "Summer salad":
                    return new SummerSalad();

                case "Hotdog":
                    return new Hotdog();

                case "Shopska salad":
                    return new ShopskaSalad();

                case "Pizza":
                    return new Pizza();

                default:
                    throw new Exception("case not handled");
            }
        }
    }
}