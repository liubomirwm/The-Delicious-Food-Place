namespace TheDeliciousFoodPlace.FoodProducts
{
    public class CaberneSauvignon : FoodProduct
    {
        public CaberneSauvignon() : base("Caberne Sauvignon", 18.00m)
        {
        }

        public override string ToString()
        {
            return $"{Name} which costs {Price}";
        }
    }
}