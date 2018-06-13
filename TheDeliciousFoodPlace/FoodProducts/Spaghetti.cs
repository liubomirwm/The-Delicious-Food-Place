namespace TheDeliciousFoodPlace.FoodProducts
{
    public class Spaghetti : FoodProduct
    {
        public Spaghetti() : base("Spaghetti", 2.00m)
        {
        }

        public override string ToString()
        {
            return $"{Name} which costs {Price}";
        }
    }
}