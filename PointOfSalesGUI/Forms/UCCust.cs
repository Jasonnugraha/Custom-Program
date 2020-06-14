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
    public partial class UCCust : UserControl
    {
        BindingList<Person> customers = Customers.GetCustomers;

        public UCCust()
        {
            InitializeComponent();
        }

        private void UCCust_Load(object sender, EventArgs e)
        {
            btnAddCust.Enabled = false;
            FetchData();
        }

        private void FetchData()
        {
            dataGridViewCust.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCust.RowsDefaultCellStyle.BackColor = Color.FromArgb(224, 242, 241);
            dataGridViewCust.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(77, 182, 172);
            dataGridViewCust.DefaultCellStyle.Font = new Font("Verdana", 8);
            dataGridViewCust.DataSource = customers;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Action";
            btn.Name = "btnDelete";
            btn.Text = "Delete";
            btn.CellTemplate.Style.BackColor = Color.FromArgb(255, 82, 82);
            btn.FlatStyle = FlatStyle.Flat;
            btn.UseColumnTextForButtonValue = true;
            dataGridViewCust.Columns.Add(btn);

           
            
        }

        private void dataGridViewCust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                customers.RemoveAt(e.RowIndex);
            }
        }

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            string id = comboBoxId.SelectedItem.ToString();
            string name = textName.Text;
            string address = textAddress.Text;
            string phone = textPhone.Text;


            if (id == "Online Customer")
            {
                Customers.AddCustomer(new OnlineCustomer(name, address, phone));
            }
            else
            {
                Customers.AddCustomer(new OfflineCustomer(name, address, phone));
            }
            
            comboBoxId.SelectedItem = "";
            textName.Text = "";
            textAddress.Text = "";
            textPhone.Text = "";
        }

        private void textId_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textName.Text) ||
                String.IsNullOrEmpty(textAddress.Text) ||
                String.IsNullOrEmpty(textPhone.Text))
                btnAddCust.Enabled = false;
            else
                btnAddCust.Enabled = true;
        }
    }
}
