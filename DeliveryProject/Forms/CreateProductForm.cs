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
    public partial class CreateProductForm : Form
    {
        public event EventHandler<Product>? ProductCreated;

        public CreateProductForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click_1(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            int count = (int)countBox.Value;
            double price = (double)priceBox.Value;

            Product product = new Product(name, price, count);

            ProductCreated?.Invoke(this, product);
        }
    }
}
