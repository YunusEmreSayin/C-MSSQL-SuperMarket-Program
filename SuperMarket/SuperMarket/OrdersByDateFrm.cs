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
    public partial class OrdersByDateFrm : Form
    {
        public OrdersByDateFrm()
        {
            InitializeComponent();
        }

        private void btnGetOrders_Click(object sender, EventArgs e)
        {
            DateTime FirstDate = dtpFirstDate.Value;
            DateTime SecondDate = dtpSecondDate.Value;
            bsOrder.DataSource = SuperMarketDal.getOrdersTimeFrame(FirstDate,SecondDate);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
