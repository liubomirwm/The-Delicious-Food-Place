using System.Collections.Generic;

namespace TheDeliciousFoodPlace
{
    public interface ITimeState
    {
        List<string> GetMenu();

        IFoodProductFactory GetFoodFactory();
    }
}