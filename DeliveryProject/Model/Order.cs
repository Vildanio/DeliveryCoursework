using DeliveryProject;

namespace DeliveryProject
{
    public record Order
    {
        private OrderStatus status;

#if DEBUG
        internal static Order Debug => new Order(0, new Client("DEBUG_CLIENT", "DEBUG_LOCATION"), Array.Empty<Product>());
#endif

        public int Id { get; }

        public Client Client { get; }

        public IEnumerable<Product> Products { get; }

        public OrderStatus Status
        {
            get
            {
                return status;
            }
            internal set
            {
                if(status != value)
                {
                    status = value;

                    StatusChanged?.Invoke(this, status);
                }
            }
        }

        public event EventHandler<OrderStatus>? StatusChanged;

        public Order(int id, Client client, IEnumerable<Product> products)
        {
            Id = id;
            Client = client;
            Products = products;
        }
    }
}
