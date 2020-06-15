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
using Microsoft.VisualBasic.ApplicationServices;

namespace PointOfSalesGUI.Forms
{
    public partial class UCCart : UserControl
    {
        static UCCart uCCart;
        int count = 0;


        public static UCCart Instance
        {
            get
            {
                if(uCCart == null)
                {
                    uCCart = new UCCart();
                }
                return uCCart;
            }
        }


        BindingList<Item> warehouse = Warehouse.Stocks;
        BindingList<Item> cart = new BindingList<Item>();
        
        

        string comboboxSelectedValue = string.Empty;
        string selectedId = string.Empty;

        public BindingList<Item> Cart
        {
            get
            {
                return cart;
            }
            set
            {
                cart = value;
            }
        }

        public UCCart()
        {
            
            InitializeComponent();
        }

        private void UCCart_Load(object sender, EventArgs e)
        {
            

            uCCart = this;
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
            dataGridViewCart.ReadOnly = false;

            DataGridViewComboBoxColumn comboBox = new DataGridViewComboBoxColumn();
            int[] value = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            comboBox.Name = "Qty";
            comboBox.MaxDropDownItems = 10;
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.ReadOnly = false;

            foreach (int i in value)
            {
                comboBox.Items.Add(i.ToString());
            }
            dataGridViewCart.Columns.Add(comboBox);
        }

        private void dataGridViewStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                    cart.Add(Warehouse.FetchAnItem(senderGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString()).ShallowCopy());
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

            CreateNewTrans();
        }

        public void CreateNewTrans()
        {
            foreach (Item item in cart)
            {
                Warehouse.ReduceItemStock(item.Id, item.Qty);
            }
            string custName = comboBoxCust.Text;
            string transId = comboBoxCust.Text;
            transId = transId.Substring(0, 3);
            count++;
            transId = transId + count.ToString("000");

            string paymentMethod = comboBoxPayment.Text;

            UCFinalize.Instance.TextBoxResult.Text += "Hi " + custName + Environment.NewLine;

            UCFinalize.Instance.TextBoxResult.Text += "Your Trans id is " + transId + Environment.NewLine;

            UCFinalize.Instance.TextBoxResult.Text += "Listed Item that you buy : " + Environment.NewLine;

            foreach(Item item in cart)
            {
                UCFinalize.Instance.TextBoxResult.Text += item.Name + " " + item.Qty + " pcs A$ " + item.Price + Environment.NewLine;
            }

            UCFinalize.Instance.TextBoxResult.Text += "Total Price " + GetPaymentAmount();



            Payment payment;

            if (paymentMethod == "card")
            {
                payment = new Card(GetPaymentAmount(), "", DateTime.Now);
            }
            else
            {
                payment = new Cash(GetPaymentAmount(), 100);
            }

            AllTransactions.AddTransactions(new Transaction(transId, DateTime.Now, payment, Customers.GetPerson(custName)));
        }

        private int GetPaymentAmount()
        {
            int result = 0;
            foreach(Item item in cart)
            {
                result += (item.Qty * item.Price);
            }
            return result;
        }

        private void CheckInput(object sender, EventArgs e)
        {

            if (comboBoxPayment.SelectedItem == null ) 
            {
                btnCart.Enabled = false;
            }
            else
            {
                btnCart.Enabled = true;
            }

        }

        private void dataGridViewCart_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dataGridViewCart.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCart.Columns[e.ColumnIndex].GetType() == typeof(DataGridViewComboBoxColumn))
            {
                comboboxSelectedValue = dataGridViewCart.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }

            UpdateCartQty(selectedId, Int32.Parse(comboboxSelectedValue));
        }

        private void UpdateCartQty(string id, int value)
        {
            foreach(Item item in cart)
            {
                if (item.Id == id)
                {
                    item.Qty = value;
                }
            }
        }


        private void dataGridViewCart_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCart.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewCart.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridViewCart.Rows[selectedrowindex];
                selectedId = Convert.ToString(selectedRow.Cells["Id"].Value);
            }

        }
    }
}
