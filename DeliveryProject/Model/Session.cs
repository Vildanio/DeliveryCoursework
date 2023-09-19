namespace DeliveryProject
{
    public static class Session
    {
        public static Account Account { get; internal set; }

        public static ICourier? Courier { get; internal set; }

        public static Queue<Order> Orders { get; internal set; }

        public static IDispatcher? Dispatcher { get; internal set; }

        public static IStorekeeper? Storekeeper { get; internal set; }

        public static IProductStorage ProductStorage { get; internal set; }

        public static IAccountManager AccountManager { get; internal set; }

        static Session()
        {
            Orders = new Queue<Order>();
        }
    }
}
