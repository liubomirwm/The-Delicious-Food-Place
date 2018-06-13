namespace TheDeliciousFoodPlace.FoodProducts
{
    public class Heineken : FoodProduct
    {
        public Heineken() : base("Heineken", 3.14m)
        {
        }

        public override string ToString()
        {
            return $"{Name} which costs {Price}";
        }
    }
}