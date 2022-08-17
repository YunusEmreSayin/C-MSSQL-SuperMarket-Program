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
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            BsCustomer.DataSource = SuperMarketDal.getCustomers();
            BsOrder.DataSource = SuperMarketDal.getOrders();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerFrm frm = new AddCustomerFrm();
            frm.ShowDialog();
            BsCustomer.DataSource = SuperMarketDal.getCustomers();
        }

        private void btnOrderTimeframe_Click(object sender, EventArgs e)
        {
            OrdersByDateFrm frm = new OrdersByDateFrm();
            frm.Show();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            Customer x = BsCustomer.Current as Customer;
            if (x == null) return;
            CreateOrderFrm frm = new CreateOrderFrm(x);
            frm.ShowDialog();
            BsOrder.DataSource = SuperMarketDal.getOrders();
        }

        private void btnOrderbyCustomer_Click(object sender, EventArgs e)
        {
            Customer x = BsCustomer.Current as Customer;
            if (x == null) return;
            OrdersByCustomerFrm frm = new OrdersByCustomerFrm(x);
            frm.ShowDialog();
            BsCustomer.DataSource = SuperMarketDal.getCustomers();
        }
    }
}
