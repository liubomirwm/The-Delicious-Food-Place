namespace TheDeliciousFoodPlace.FoodProducts
{
    public class Coffee : FoodProduct
    {
        public Coffee() : base("Coffee", 1.39m)
        {
        }

        public override string ToString()
        {
            return $"{Name} which costs + {Price}";
        }
    }
}