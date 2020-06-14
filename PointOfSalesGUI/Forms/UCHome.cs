using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSalesGUI.Forms
{
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            if (!DashBoard.Instance.pnlController.Controls.ContainsKey("UCCart"))
            {
                UCCart uCCart = new UCCart();
                uCCart.Dock = DockStyle.Fill;
                DashBoard.Instance.pnlController.Controls.Add(uCCart);
            }
            DashBoard.Instance.pnlController.Controls["UCCart"].BringToFront();
            DashBoard.Instance.BackButton.Visible = true;
            DashBoard.Instance.topLabel.Text = "Shopping Cart";
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            if (!DashBoard.Instance.pnlController.Controls.ContainsKey("UCStock"))
            {
                UCStock uCStock = new UCStock();
                uCStock.Dock = DockStyle.Fill;
                DashBoard.Instance.pnlController.Controls.Add(uCStock);
            }
            DashBoard.Instance.pnlController.Controls["UCStock"].BringToFront();
            DashBoard.Instance.BackButton.Visible = true;
            DashBoard.Instance.topLabel.Text = "Stock";

        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            if (!DashBoard.Instance.pnlController.Controls.ContainsKey("UCTrans"))
            {
                UCTrans uCTrans = new UCTrans();
                uCTrans.Dock = DockStyle.Fill;
                DashBoard.Instance.pnlController.Controls.Add(uCTrans);
            }
            DashBoard.Instance.pnlController.Controls["UCTrans"].BringToFront();
            DashBoard.Instance.BackButton.Visible = true;
            DashBoard.Instance.topLabel.Text = "Transaction";

        }

        private void btnCust_Click(object sender, EventArgs e)
        {
            if (!DashBoard.Instance.pnlController.Controls.ContainsKey("UCCust"))
            {
                UCCust uCCust= new UCCust();
                uCCust.Dock = DockStyle.Fill;
                DashBoard.Instance.pnlController.Controls.Add(uCCust);
            }
            DashBoard.Instance.pnlController.Controls["UCCust"].BringToFront();
            DashBoard.Instance.BackButton.Visible = true;
            DashBoard.Instance.topLabel.Text = "Customer";

        }
    }
}
