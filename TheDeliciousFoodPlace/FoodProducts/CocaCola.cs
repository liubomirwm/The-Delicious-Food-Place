namespace TheDeliciousFoodPlace.FoodProducts
{
    public class CocaCola : FoodProduct
    {
        public CocaCola() : base("Coca Cola", 1.20m)
        {
        }

        public override string ToString()
        {
            return $"{Name} which costs {Price}";
        }
    }
}