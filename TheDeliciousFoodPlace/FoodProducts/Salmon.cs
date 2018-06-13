namespace TheDeliciousFoodPlace.FoodProducts
{
    public class Salmon : FoodProduct
    {
        public Salmon() : base("Salmon", 3.18m)
        {
        }

        public override string ToString()
        {
            return $"{Name} which costs {Price}";
        }
    }
}