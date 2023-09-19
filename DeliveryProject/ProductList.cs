namespace DeliveryProject
{
    public partial class ProductList : UserControl
    {
        private IEnumerable<Product> products;

        public IEnumerable<Product> Products
        {
            get
            {
                return products;
            }
            set
            {
                products = value;

                ShowProducts(value);
            }
        }

        public ProductList()
        {
            InitializeComponent();

            products = Array.Empty<Product>();
        }

        private void ShowProducts(IEnumerable<Product> products)
        {
            productPanel.Controls.Clear();

            foreach (var product in products)
            {
                Control productControl = new ProductCard(product);

                productPanel.Controls.Add(productControl);
            }
        }
    }
}
