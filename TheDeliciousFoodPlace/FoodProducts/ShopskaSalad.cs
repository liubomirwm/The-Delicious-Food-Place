namespace TheDeliciousFoodPlace.FoodProducts
{
    public class ShopskaSalad : FoodProduct
    {
        public ShopskaSalad() : base("Shopska salad", 2.45m)
        {
        }

        public override string ToString()
        {
            return $"{Name} which costs {Price}";
        }
    }
}