using System.Collections.Generic;

namespace TheDeliciousFoodPlace
{
    public class LunchTimeState : ITimeState
    {
        private List<string> menu = new List<string>()
        {
            "Chicken soup", "Summer salad", "Hotdog", "Shopska salad", "Pizza"
        };

        public IFoodProductFactory GetFoodFactory()
        {
            return new LunchFoodFactory();
        }

        public List<string> GetMenu()
        {
            return this.menu;
        }
    }
}