namespace TheDeliciousFoodPlace.FoodProducts
{
    public class Hotdog : FoodProduct
    {
        public Hotdog() : base("Hotdog", 1.74m)
        {
        }

        public override string ToString()
        {
            return $"{Name} which costs {Price}";
        }
    }
}