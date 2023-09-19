using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeliveryProject;

namespace DeliveryProject.Pages
{
    public partial class DispatcherPage : Form, IDispatcher
    {
        // Диспетчер обрабатывает заказы по очереди

        private int orderCount;

        public Queue<Order> Orders => Session.Orders;

        public DispatcherPage()
        {
            InitializeComponent();

            foreach (var order in Orders)
            {
                ShowOrder(order);
            }
        }

        public Order Order(Client client, IEnumerable<Product> products)
        {
            Order order = new Order(orderCount, client, products);

            order.StatusChanged += Order_StatusChanged;

            orderCount++;

            Orders.Enqueue(order);

            ShowOrder(order);

            return order;
        }

        private void Order_StatusChanged(object? sender, OrderStatus e)
        {
            if (sender is not Order order)
                throw new ArgumentException(null, nameof(sender));

            if (e == OrderStatus.Delivered)
            {
                HideOrder(order);

                DeliverLastOrder();
            }
        }

        private void DeliverLastOrder()
        {
            if (Orders.TryDequeue(out Order? lastOrder))
            {
                // Если есть курьер
                // И последний заказ собран
                if (Session.Courier is not null && lastOrder.Status == OrderStatus.Ready)
                {
                    // Поручаем курьеру доставить заказ
                    Session.Courier.Order = lastOrder;
                }
            }
        }

        private void ShowOrder(Order order)
        {
            OrderCard card = new OrderCard(order);

            orderPanel.Controls.Add(card);
        }

        private void HideOrder(Order order)
        {
            for (int i = 0; i < orderPanel.Controls.Count; i++)
            {
                if (orderPanel.Controls[i] is OrderCard card && card.Order == order)
                {
                    orderPanel.Controls.RemoveAt(i);
                }
            }
        }

        private void AcceptOrderButton_Click(object sender, EventArgs e)
        {
            if (!Orders.Any())
            {
                return;
            }

            if (Session.Storekeeper is null)
            {
                MessageBox.Show("Отсутствует кладовщик для сборки заказа");
                return;
            }

            if (Orders.TryPeek(out var order))
            {
                Session.Storekeeper.AddOrder(order);
            }
        }

        private void SendOrder(Order order)
        {
            if (order.Status == OrderStatus.Ready)
            {
                if (Session.Courier is not null)
                {
                    if (Session.Courier.Order is not null && Session.Courier.Order.Status != OrderStatus.Delivered)
                    {
                        MessageBox.Show("Курьер пока занят");
                    }
                    else
                    {
                        Session.Courier.Order = order;
                    }
                }
                else
                {
                    MessageBox.Show("Курьер на отдыхе");
                }
            }
        }

        private void SendOrderButton_Click(object sender, EventArgs e)
        {
            foreach (var order in Orders)
            {
                if (order.Status == OrderStatus.Ready)
                {
                    SendOrder(order);
                }
            }
        }
    }
}
