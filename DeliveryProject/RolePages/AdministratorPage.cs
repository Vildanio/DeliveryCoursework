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
    public partial class AdministratorPage : Form
    {
        public AdministratorPage()
        {
            InitializeComponent();

            UpdateProducts();
        }

        #region ButtonClicks

        private void CreateProductButton_Click(object sender, EventArgs e)
        {
            CreateProductForm form = new CreateProductForm();

            form.ProductCreated += CreateProductForm_ProductCreated;

            form.ShowDialog();
        }

        private void CreateProductForm_ProductCreated(object? sender, Product product)
        {
            if (sender is not CreateProductForm createProductForm)
                throw new ArgumentException(null, nameof(sender));

            createProductForm.Close();

            Session.ProductStorage.Products.Add(product);

            UpdateProducts();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm form = new SignUpForm(Session.AccountManager);
            form.ShowDialog();
        }

        #endregion

        private void UpdateProducts()
        {
            productList.Products = Session.ProductStorage.Products;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Session.ProductStorage.SaveProductData();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            UpdateProducts();
        }
    }
}
