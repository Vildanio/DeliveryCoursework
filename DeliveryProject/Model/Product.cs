namespace DeliveryProject
{
    public record Product
    {
        internal static Product Debug => new Product("DEBUG_PRODUCT", 10, 100);

        public int Count { get; set; }

        public string Name { get; init; }

        public double Price { get; init; }

        public Product(string name, double price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }
    }
}
