namespace TheDeliciousFoodPlace.FoodProducts
{
    public class Musli : FoodProduct
    {
        public Musli() : base("Musli", 4.79m)
        {
        }

        public override string ToString()
        {
            return $"{Name} which costs {Price}";
        }
    }
}