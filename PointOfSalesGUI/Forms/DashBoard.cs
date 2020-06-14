using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSales;

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
                return panelController;
            }
            set
            {
                panelController = value;
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

        public Panel topPanel
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

        public Label topLabel
        {
            get
            {
                return Position;
            }
            set
            {
                Position = value;
            }
        }

        
        public DashBoard()
        {
            InitializeComponent();
            //userControlStock1.Hide();
        }
        
        private void DashBoard_Load(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            dashBoard = this;

            UCHome uCHome = new UCHome();
            uCHome.Dock = DockStyle.Fill;
            panelController.Controls.Add(uCHome);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelController.Controls["UCHome"].BringToFront();
            btnBack.Visible = false;
            topLabel.Text = "Home";
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
