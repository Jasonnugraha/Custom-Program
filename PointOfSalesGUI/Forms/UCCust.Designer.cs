namespace PointOfSalesGUI.Forms
{
    partial class UCCust
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
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.dataGridViewCust = new System.Windows.Forms.DataGridView();
            this.comboBoxId = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCust)).BeginInit();
            this.SuspendLayout();
            // 
            // textPhone
            // 
            this.textPhone.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhone.Location = new System.Drawing.Point(604, 283);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(146, 21);
            this.textPhone.TabIndex = 27;
            this.textPhone.TextChanged += new System.EventHandler(this.textId_TextChanged);
            // 
            // textAddress
            // 
            this.textAddress.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddress.Location = new System.Drawing.Point(604, 223);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(146, 21);
            this.textAddress.TabIndex = 26;
            this.textAddress.TextChanged += new System.EventHandler(this.textId_TextChanged);
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(604, 165);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(146, 21);
            this.textName.TabIndex = 25;
            this.textName.TextChanged += new System.EventHandler(this.textId_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(517, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(517, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(517, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(517, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID";
            // 
            // btnAddCust
            // 
            this.btnAddCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.btnAddCust.FlatAppearance.BorderSize = 0;
            this.btnAddCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCust.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCust.ForeColor = System.Drawing.Color.White;
            this.btnAddCust.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCust.Location = new System.Drawing.Point(539, 453);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(199, 44);
            this.btnAddCust.TabIndex = 18;
            this.btnAddCust.Text = "+   Add Cust";
            this.btnAddCust.UseVisualStyleBackColor = false;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // dataGridViewCust
            // 
            this.dataGridViewCust.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dataGridViewCust.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCust.Location = new System.Drawing.Point(62, 104);
            this.dataGridViewCust.Name = "dataGridViewCust";
            this.dataGridViewCust.ReadOnly = true;
            this.dataGridViewCust.Size = new System.Drawing.Size(435, 393);
            this.dataGridViewCust.TabIndex = 17;
            this.dataGridViewCust.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCust_CellContentClick);
            // 
            // comboBoxId
            // 
            this.comboBoxId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxId.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxId.FormattingEnabled = true;
            this.comboBoxId.Items.AddRange(new object[] {
            "Offline Customer",
            "Online Customer"});
            this.comboBoxId.Location = new System.Drawing.Point(604, 116);
            this.comboBoxId.Name = "comboBoxId";
            this.comboBoxId.Size = new System.Drawing.Size(146, 21);
            this.comboBoxId.TabIndex = 29;
            this.comboBoxId.TextChanged += new System.EventHandler(this.textId_TextChanged);
            // 
            // UCCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.comboBoxId);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.dataGridViewCust);
            this.Name = "UCCust";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.UCCust_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.DataGridView dataGridViewCust;
        private System.Windows.Forms.ComboBox comboBoxId;
    }
}
