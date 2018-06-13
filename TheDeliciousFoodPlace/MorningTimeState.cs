using System.Collections.Generic;
using TheDeliciousFoodPlace.FoodFactories;

namespace TheDeliciousFoodPlace
{
    public class MorningTimeState : ITimeState
    {
        private List<string> menu = new List<string>()
        {
            "Banica", "Boza", "Hotdog", "Musli", "Coffee"
        };

        public IFoodProductFactory GetFoodFactory()
        {
            return new MorningFoodFactory();
        }

        public List<string> GetMenu()
        {
            return this.menu;
        }
    }
}