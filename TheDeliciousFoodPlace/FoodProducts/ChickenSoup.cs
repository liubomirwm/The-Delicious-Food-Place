namespace TheDeliciousFoodPlace.FoodProducts
{
    public class ChickenSoup : FoodProduct
    {
        public ChickenSoup() : base("Chicken soup", 2.18m)
        {
        }

        public override string ToString()
        {
            return $"{Name} which costs {Price}";
        }
    }
}