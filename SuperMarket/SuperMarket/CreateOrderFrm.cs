using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class CreateOrderFrm : Form
    {
        Customer _x;
        public CreateOrderFrm()
        {
            InitializeComponent();
            _x = new Customer();
        }
        public CreateOrderFrm(Customer x)
        {
            InitializeComponent();
            _x = x;
        }

        private void CreateOrderFrm_Load(object sender, EventArgs e)
        {
            txtCustomer.Text = $"Id: {_x.CustomerId}, {_x.CName} {_x.CSurname}";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.CustomerId = _x.CustomerId;
            order.OrderDate = datepickerOrder.Value;
            order.OrderNote = richtxtNote.Text;
            SuperMarketDal.add(order);
            MessageBox.Show("Order created Successfully");
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
