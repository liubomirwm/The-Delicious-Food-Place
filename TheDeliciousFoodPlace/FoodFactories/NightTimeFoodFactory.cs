using System;
using TheDeliciousFoodPlace.FoodProducts;

namespace TheDeliciousFoodPlace.FoodFactories
{
    internal class NightTimeFoodFactory : IFoodProductFactory
    {
        public FoodProduct GetFoodProduct(string selectedProduct)
        {
            switch (selectedProduct)
            {
                case "Spaghetti":
                    return new Spaghetti();

                case "Salmon":
                    return new Salmon();

                case "Beef":
                    return new Beef();

                case "Caberne Sauvignon":
                    return new CaberneSauvignon();

                case "Coca Cola":
                    return new CocaCola();

                case "Heineken":
                    return new Heineken();

                default:
                    throw new Exception("case not handled");
            }
        }
    }
}