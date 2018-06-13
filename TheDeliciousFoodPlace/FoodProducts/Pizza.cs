namespace TheDeliciousFoodPlace.FoodProducts
{
    public class Pizza : FoodProduct
    {
        public Pizza() : base("Pizza", 1.99m)
        {
        }

        public override string ToString()
        {
            return $"{Name} which costs {Price}";
        }
    }
}