namespace TheDeliciousFoodPlace.FoodProducts
{
    public class Banica : FoodProduct
    {
        public Banica() : base("Banica", 1.00m)
        {
        }

        public override string ToString()
        {
            return $"{Name} which costs {Price}";
        }
    }
}