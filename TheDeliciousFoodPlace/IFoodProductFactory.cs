namespace TheDeliciousFoodPlace
{
    public interface IFoodProductFactory
    {
        FoodProduct GetFoodProduct(string selectedProduct);
    }
}