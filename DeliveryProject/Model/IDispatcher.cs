namespace DeliveryProject
{
    public interface IDispatcher
    {
        public Order Order(Client client, IEnumerable<Product> product);
    }
}
