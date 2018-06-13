namespace TheDeliciousFoodPlace.FoodProducts
{
    public class Beef : FoodProduct
    {
        public Beef() : base("Beef", 3.00m)
        {
        }

        public override string ToString()
        {
            return $"{Name} which costs {Price}";
        }
    }
}