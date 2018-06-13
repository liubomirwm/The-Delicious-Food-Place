namespace TheDeliciousFoodPlace
{
    public abstract class FoodProduct
    {
        public string Name { get; protected set; }

        public decimal Price { get; protected set; }

        public FoodProduct(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}