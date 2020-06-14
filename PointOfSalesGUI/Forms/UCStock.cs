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
using Microsoft.VisualBasic;
using System.Security.Cryptography;

namespace PointOfSalesGUI.Forms
{
    public partial class UCStock : UserControl
    {
        BindingList<Item> warehouse = Warehouse.Stocks;

        public UCStock()
        {
            InitializeComponent();
        }

        private void UCStock_Load(object sender, EventArgs e)
        {
            btnAddItems.Enabled = false;
            FetchData();
        }

        public void NumericInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void FetchData()
        {
            dataGridViewStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStocks.RowsDefaultCellStyle.BackColor = Color.FromArgb(224, 242, 241);
            dataGridViewStocks.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(77, 182, 172);
            dataGridViewStocks.DefaultCellStyle.Font = new Font("Verdana",8);
            dataGridViewStocks.DataSource = warehouse;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Action";
            btn.Name = "btnDelete";
            btn.Text = "Delete";
            btn.CellTemplate.Style.BackColor = Color.FromArgb(255, 82, 82);
            btn.FlatStyle = FlatStyle.Flat;
            btn.UseColumnTextForButtonValue = true;
            dataGridViewStocks.Columns.Add(btn);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                warehouse.RemoveAt(e.RowIndex);
            }

        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            string id = textId.Text;
            string name = textName.Text;
            string desc = textDesc.Text;
            int qty = Int32.Parse(textQty.Text);
            int price = Int32.Parse(textPrice.Text);

            Warehouse.AddItem(new Item(id, name, desc, qty, price));

            textId.Text = "";
            textName.Text = "";
            textDesc.Text = "";
            textQty.Text = "";
            textPrice.Text = "";
        }

        private void textQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericInput(sender, e);
        }

        private void textPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumericInput(sender, e);
        }

        private void textId_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textId.Text) ||
                String.IsNullOrEmpty(textName.Text) ||
                String.IsNullOrEmpty(textDesc.Text) ||
                String.IsNullOrEmpty(textQty.Text)||
                String.IsNullOrEmpty(textPrice.Text))
                btnAddItems.Enabled = false;
            else
                btnAddItems.Enabled = true;
        }

    }
}
