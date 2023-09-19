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
    public partial class StorekeeperPage : Form, IStorekeeper
    {
        private readonly Queue<Order> orders;

        public StorekeeperPage()
        {
            InitializeComponent();

            orders = new Queue<Order>();
        }

        public void AddOrder(Order order)
        {
            ShowOrder(order);
            orders.Enqueue(order);
        }

        public void CollectOrder(Order order)
        {
            if (orders.Contains(order))
            {
                return;
            }

            foreach (var orderProduct in order.Products)
            {
                var productInStorage = Session.ProductStorage.Products.FirstOrDefault(x => x.Name == orderProduct.Name);

                if (productInStorage is not null && productInStorage.Count > orderProduct.Count)
                {
                    productInStorage.Count -= orderProduct.Count;
                    order.Status = OrderStatus.Ready;
                }
            }
        }

        public bool CanCollect(Order order)
        {
            foreach (var orderProduct in order.Products)
            {
                var productInStorage = Session.ProductStorage.Products.FirstOrDefault(x => x.Name == orderProduct.Name);

                if (productInStorage is null || productInStorage.Count < orderProduct.Count)
                {
                    return false;
                }
            }

            return true;
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

        private void CollectOrderButton_Click(object sender, EventArgs e)
        {
            if (orders.TryDequeue(out Order? order))
            {
                if (CanCollect(order))
                {
                    CollectOrder(order);
                    HideOrder(order);
                }
            }
        }
    }
}
