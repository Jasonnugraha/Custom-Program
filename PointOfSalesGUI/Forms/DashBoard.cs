using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSalesGUI.Forms
{
    public partial class DashBoard : Form
    {
        static DashBoard dashBoard;

        public static DashBoard Instance
        {
            get
            {
                if(dashBoard == null)
                {
                    dashBoard = new DashBoard();
                }
                return dashBoard;
            }
        }

        public Panel pnlController
        {
            get
            {
                return panel;
            }
            set
            {
                panel = value;
            }
        }
        
        public Button BackButton
        {
            get
            {
                return btnBack;
            }
            set
            {
                btnBack = value;
            }
        }
        
        public DashBoard()
        {
            InitializeComponent();
            userControlStock1.Hide();
        }

        private void btnCust_Click(object sender, EventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            userControlStock1.Show();
            userControlStock1.BringToFront();
            btnBack.Visible = true;
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {

        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            dashBoard = this;

            UserControlStock userControlStock = new UserControlStock();
            //userControlStock.Dock = DockStyle.Fill;
            //panelController.Controls.Add(userControlStock);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //panelController.Controls["userControlStock"].BringToFront();
            btnBack.Visible = false;
            userControlStock1.Hide();
        }

        private void userControlStock1_Load(object sender, EventArgs e)
        {

        }
    }
}
