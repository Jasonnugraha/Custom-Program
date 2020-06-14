using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSales;

namespace PointOfSalesGUI.Forms
{
    public partial class UCCart : UserControl
    {
        BindingList<Item> warehouse = Warehouse.Stocks;
        BindingList<Item> cart = new BindingList<Item>();

        public UCCart()
        {
            InitializeComponent();
        }

        private void UCCart_Load(object sender, EventArgs e)
        {
            setUp();
            FetchStock();
            FetchCart();
        }

        private void setUp()
        {
            comboBoxCust.DataSource = Customers.GetCustomers;

            comboBoxCust.DisplayMember = "Name";

            btnCart.Enabled = false;

        }

        private void FetchStock()
        {
            dataGridViewStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStock.RowsDefaultCellStyle.BackColor = Color.FromArgb(224, 242, 241);
            dataGridViewStock.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(77, 182, 172);
            dataGridViewStock.DefaultCellStyle.Font = new Font("Verdana", 8);
            dataGridViewStock.DataSource = warehouse;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Action";
            btn.Name = "btnAdd";
            btn.Text = "Add";
            btn.CellTemplate.Style.BackColor = Color.FromArgb(0, 229, 255);
            btn.FlatStyle = FlatStyle.Flat;
            btn.UseColumnTextForButtonValue = true;
            dataGridViewStock.Columns.Add(btn);


        }

        private void FetchCart()
        {
            dataGridViewCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCart.RowsDefaultCellStyle.BackColor = Color.FromArgb(224, 242, 241);
            dataGridViewCart.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(77, 182, 172);
            dataGridViewCart.DefaultCellStyle.Font = new Font("Verdana", 8);
            dataGridViewCart.DataSource = cart;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Action";
            btn.Name = "btnDelete";
            btn.Text = "Delete";
            btn.CellTemplate.Style.BackColor = Color.FromArgb(255, 82, 82);
            btn.FlatStyle = FlatStyle.Flat;
            btn.UseColumnTextForButtonValue = true;
            dataGridViewCart.Columns.Add(btn);
            dataGridViewCart.Columns[3].Visible = false;
        }

        private void dataGridViewStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                    cart.Add(Warehouse.FetchAnItem(senderGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString()));
            }
        }

        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                cart.RemoveAt(e.RowIndex);
            }
        }

        

        private void btnCart_Click(object sender, EventArgs e)
        {
            if (!DashBoard.Instance.pnlController.Controls.ContainsKey("UCFinalize"))
            {
                UCFinalize uCFinalize = new UCFinalize();
                uCFinalize.Dock = DockStyle.Fill;
                DashBoard.Instance.pnlController.Controls.Add(uCFinalize);
            }
            DashBoard.Instance.pnlController.Controls["UCFinalize"].BringToFront();
            DashBoard.Instance.BackButton.Visible = false;
            DashBoard.Instance.topLabel.Text = "Invoice";

            

            ShoppingCart copy = new ShoppingCart();

            Item _temp = null;
            foreach(Item item in cart)
            {
                if (!copy.ShoppingList.Contains(item))
                {
                    _temp = item.ShallowCopy();
                    _temp.Qty = 1;
                }
                    copy.AddCopy(_temp);
            }

            ShoppingCart results = new ShoppingCart();

            int result = 0;
            foreach(Item item in copy.ShoppingList)
            {
                if (results.ShoppingList.Contains(item))
                {
                    result++;
                }
                else
                {
                    result = item.Qty;
                    results.ShoppingList.Add(item);
                }
            }
            UCFinalize.Instance.TextBoxResult.Text = result.ToString();

        }

        private void CheckInput(object sender, EventArgs e)
        {
            if (comboBoxPayment.SelectedItem == null) 
            {
                btnCart.Enabled = false;
            }
            else
            {
                btnCart.Enabled = true;
            }

        }


    }
}
