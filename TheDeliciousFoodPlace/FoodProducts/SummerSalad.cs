namespace TheDeliciousFoodPlace.FoodProducts
{
    public class SummerSalad : FoodProduct
    {
        public SummerSalad() : base("Summer salad", 1.95m)
        {
        }

        public override string ToString()
        {
            return $"{Name} which costs {Price}";
        }
    }
}