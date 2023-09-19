using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryProject
{
    public partial class OrderCard : UserControl
    {
        private Order? order;

        public Order? Order
        {
            get
            {
                return order;
            }
            set
            {
                if (order != value)
                {
                    if (order is not null)
                    {
                        order.StatusChanged -= Order_StatusChanged;
                    }

                    order = value;

                    if (value is not null)
                    {
                        this.idLabel.Text = value.Id.ToString();
                        this.clientNameLabel.Text = value.Client.Name;
                        this.statusLabel.Text = value.Status.ToString();

                        value.StatusChanged += Order_StatusChanged;

                        ShowProducts(value.Products);
                    }
                    else
                    {
                        this.idLabel.Text = string.Empty;
                        this.statusLabel.Text = string.Empty;
                        this.clientNameLabel.Text = string.Empty;

                        productsPanel.Controls.Clear();
                    }
                }
            }
        }

        private void ShowProducts(IEnumerable<Product> products)
        {
            productsPanel.Controls.Clear();

            foreach (var product in products)
            {
                productsPanel.Controls.Add(new ProductCard(product));
            }
        }

        public OrderCard()
            : this(null)
        {
            this.idLabel.Text = string.Empty;
            this.statusLabel.Text = string.Empty;
            this.clientNameLabel.Text = string.Empty;
        }

        public OrderCard(Order? order)
        {
            InitializeComponent();

            Order = order;
        }

        private void Order_StatusChanged(object? sender, OrderStatus e)
        {
            this.statusLabel.Text = order!.Status.ToString();
        }
    }
}
