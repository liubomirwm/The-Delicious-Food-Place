namespace TheDeliciousFoodPlace.FoodProducts
{
    public class Boza : FoodProduct
    {
        public Boza() : base("Boza", 0.90m)
        {
        }

        public override string ToString()
        {
            return "Boza which costs " + Price;
        }
    }
}