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
    public partial class ProductCard : UserControl
    {
        private Product? product;

        public Product? Product
        {
            get
            {
                return product;
            }
            set
            {
                if(product != value)
                {
                    product = value;

                    if(product is not null)
                    {
                        this.nameLabel.Text = product.Name;
                        this.priceLabel.Text = product.Price.ToString();
                        this.countLabel.Text = product.Count.ToString();
                    }
                    else
                    {
                        this.nameLabel.Text = string.Empty;
                        this.priceLabel.Text = string.Empty;
                        this.countLabel.Text = string.Empty;
                    }
                }
            }
        }

        public ProductCard(Product? product)
        {
            InitializeComponent();

            Product = product;
        }
    }
}
