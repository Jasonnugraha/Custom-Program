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
    public partial class UCFinalize : UserControl
    {
        static UCFinalize uCFinalize;
        public static UCFinalize Instance
        {
            get
            {
                if (uCFinalize == null)
                {
                    uCFinalize = new UCFinalize();
                }
                return uCFinalize;
            }
        }

       

        public TextBox TextBoxResult
        {
            get
            {
                return textBoxResult;
            }
            set
            {
                textBoxResult = value;
            }
        }
        public UCFinalize()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            DashBoard.Instance.pnlController.Controls["UCHome"].BringToFront();
            DashBoard.Instance.BackButton.Visible = false;
            DashBoard.Instance.topLabel.Text = "Home";

            textBoxResult.Clear();
            UCCart.Instance.Cart.Clear();
        }

        private void UCFinalize_Load(object sender, EventArgs e)
        {
            uCFinalize = this;
        }
    }
}
