namespace DeliveryProject
{
    public interface IProductStorage
    {
        public IList<Product> Products { get; }

        public void SaveProductData();
    }
}
