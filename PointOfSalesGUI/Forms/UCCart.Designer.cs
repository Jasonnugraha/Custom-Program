namespace PointOfSalesGUI.Forms
{
    partial class UCCart
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCart));
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.comboBoxCust = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPayment = new System.Windows.Forms.ComboBox();
            this.btnCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dataGridViewStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Location = new System.Drawing.Point(41, 148);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.ReadOnly = true;
            this.dataGridViewStock.Size = new System.Drawing.Size(500, 400);
            this.dataGridViewStock.TabIndex = 1;
            this.dataGridViewStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStock_CellContentClick);
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dataGridViewCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Location = new System.Drawing.Point(621, 148);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.ReadOnly = true;
            this.dataGridViewCart.Size = new System.Drawing.Size(600, 400);
            this.dataGridViewCart.TabIndex = 2;
            this.dataGridViewCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCart_CellContentClick);
            this.dataGridViewCart.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCart_CellValueChanged);
            this.dataGridViewCart.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewCart_CurrentCellDirtyStateChanged);
            this.dataGridViewCart.SelectionChanged += new System.EventHandler(this.dataGridViewCart_SelectionChanged);
            this.dataGridViewCart.TabIndexChanged += new System.EventHandler(this.CheckInput);
            // 
            // comboBoxCust
            // 
            this.comboBoxCust.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCust.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCust.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCust.FormattingEnabled = true;
            this.comboBoxCust.Location = new System.Drawing.Point(253, 98);
            this.comboBoxCust.Name = "comboBoxCust";
            this.comboBoxCust.Size = new System.Drawing.Size(146, 21);
            this.comboBoxCust.TabIndex = 30;
            this.comboBoxCust.TextChanged += new System.EventHandler(this.CheckInput);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Select Customer :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Payment Method :";
            // 
            // comboBoxPayment
            // 
            this.comboBoxPayment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPayment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPayment.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPayment.FormattingEnabled = true;
            this.comboBoxPayment.Items.AddRange(new object[] {
            "Card",
            "Cash"});
            this.comboBoxPayment.Location = new System.Drawing.Point(253, 579);
            this.comboBoxPayment.Name = "comboBoxPayment";
            this.comboBoxPayment.Size = new System.Drawing.Size(146, 21);
            this.comboBoxPayment.TabIndex = 33;
            this.comboBoxPayment.TextChanged += new System.EventHandler(this.CheckInput);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.White;
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.Location = new System.Drawing.Point(621, 599);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(600, 82);
            this.btnCart.TabIndex = 34;
            this.btnCart.Text = "     Proceed Transaction";
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // UCCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.comboBoxPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCust);
            this.Controls.Add(this.dataGridViewCart);
            this.Controls.Add(this.dataGridViewStock);
            this.Name = "UCCart";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.UCCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.ComboBox comboBoxCust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPayment;
        private System.Windows.Forms.Button btnCart;
    }
}
