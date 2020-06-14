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
    public partial class UCTrans : UserControl
    {
        BindingList<Transaction> transactions = AllTransactions.GetTransactions;
        
        public UCTrans()
        {
            InitializeComponent();
        }

        private void UCTrans_Load(object sender, EventArgs e)
        {
            FetchData();
        }

        private void FetchData()
        {
            dataGridViewTrans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTrans.RowsDefaultCellStyle.BackColor = Color.FromArgb(224, 242, 241);
            dataGridViewTrans.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(77, 182, 172);
            dataGridViewTrans.DefaultCellStyle.Font = new Font("Verdana", 8);
            dataGridViewTrans.DataSource = transactions;
            dataGridViewTrans.AutoGenerateColumns = true;

            

        }
    }
}
