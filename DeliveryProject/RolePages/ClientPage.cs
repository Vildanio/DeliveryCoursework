using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryProject.RolePages
{
    public partial class ClientPage : Form
    {
        private readonly Client client;
        private List<Product> products;

        public ClientPage()
        {
            InitializeComponent();

            client = new Client("DebugClient", "DebugPlace");
            products = new List<Product>();

            foreach (var product in Session.ProductStorage.Products)
            {
                productComboBox.Items.Add(product.Name);
            }

            ShowProducts();
        }

        private void ShowProduct(Product product)
        {
            productsPanel.Controls.Add(new ProductCard(product));
        }

        private void ShowProducts()
        {
            productsPanel.Controls.Clear();

            foreach (var product in products)
            {
                ShowProduct(product);
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            string productName = productComboBox.Text;
            Product? product = Session.ProductStorage.Products.FirstOrDefault(x => x.Name == productName);

            if (product is not null)
            {
                int count = (int)countBox.Value;
                product = product with { Count = count };

                products.Add(product);
                ShowProduct(product);
            }

            ResetFields();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            if (Session.Dispatcher is not null)
            {
                if (products.Any())
                {
                    Order order = Session.Dispatcher.Order(client, products);

                    order.StatusChanged += Order_StatusChanged;

                    ResetFields();
                    products = new List<Product>();
                    productsPanel.Controls.Clear();

                    ToReadyOrders(order);
                }
            }
            else
            {
                MessageBox.Show("Диспетчер отдыхает");
            }
        }

        private void Order_StatusChanged(object? sender, OrderStatus e)
        {
            if (sender is not Order order)
                throw new ArgumentException(null, nameof(sender));

            if (order.Status == OrderStatus.Delivered)
            {
                ToDeliveredOrders(order);
            }
        }

        private void ToDeliveredOrders(Order order)
        {
            for (int i = 0; i < readyOrdersPanel.Controls.Count; i++)
            {
                if (readyOrdersPanel.Controls[i] is OrderCard orderCard && orderCard.Order == order)
                {
                    readyOrdersPanel.Controls.RemoveAt(i);
                    break;
                }
            }

            deliveredProductsPanel.Controls.Add(new OrderCard(order));
        }

        private void ToReadyOrders(Order order)
        {
            readyOrdersPanel.Controls.Add(new OrderCard(order));
        }

        private void ResetFields()
        {
            productComboBox.Text = string.Empty;
            countBox.Value = 0;
        }
    }
}
