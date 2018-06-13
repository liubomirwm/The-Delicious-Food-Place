using System.Collections.Generic;
using TheDeliciousFoodPlace.FoodFactories;

namespace TheDeliciousFoodPlace
{
    public class NightTimeState : ITimeState
    {
        private List<string> menu = new List<string>()
        {
            "Spaghetti", "Salmon", "Beef", "Caberne Sauvignon", "Coca Cola", "Heineken"
        };

        public IFoodProductFactory GetFoodFactory()
        {
            return new NightTimeFoodFactory();
        }

        public List<string> GetMenu()
        {
            return this.menu;
        }
    }
}