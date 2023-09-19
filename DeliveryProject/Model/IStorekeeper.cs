namespace DeliveryProject
{
    public interface IStorekeeper
    {
        /// <summary>
        /// Добавляет заказ в очередь сборки
        /// </summary>
        /// <param name="order"></param>
        public void AddOrder(Order order);
    }
}
