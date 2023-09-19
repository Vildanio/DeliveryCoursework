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
    public partial class CourierPage : Form, ICourier
    {
        public Order? Order
        {
            get
            {
                return orderCard.Order;
            }
            set
            {
                orderCard.Order = value;
            }
        }

        public CourierPage()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (Order is not null)
            {
                Order.Status = OrderStatus.Delivered;
                Order = null;
            }
        }
    }
}
