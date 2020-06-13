namespace PointOfSalesGUI.Forms
{
    partial class DashBoard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.panel = new System.Windows.Forms.Panel();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnTrans = new System.Windows.Forms.Button();
            this.btnCust = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnBack = new System.Windows.Forms.Button();
            this.userControlStock1 = new PointOfSalesGUI.Forms.UserControlStock();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.panel.Controls.Add(this.btnBack);
            this.panel.Controls.Add(this.btnPower);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(784, 82);
            this.panel.TabIndex = 0;
            // 
            // btnPower
            // 
            this.btnPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.btnPower.FlatAppearance.BorderSize = 0;
            this.btnPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPower.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPower.ForeColor = System.Drawing.Color.White;
            this.btnPower.Image = ((System.Drawing.Image)(resources.GetObject("btnPower.Image")));
            this.btnPower.Location = new System.Drawing.Point(676, 0);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(108, 81);
            this.btnPower.TabIndex = 5;
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
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
            this.btnCart.Location = new System.Drawing.Point(216, 110);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(364, 88);
            this.btnCart.TabIndex = 1;
            this.btnCart.Text = "     Shopping Cart";
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.Image")));
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStock.Location = new System.Drawing.Point(216, 204);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(180, 132);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "Warehouse";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnTrans
            // 
            this.btnTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.btnTrans.FlatAppearance.BorderSize = 0;
            this.btnTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrans.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrans.ForeColor = System.Drawing.Color.White;
            this.btnTrans.Image = ((System.Drawing.Image)(resources.GetObject("btnTrans.Image")));
            this.btnTrans.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTrans.Location = new System.Drawing.Point(402, 204);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(178, 270);
            this.btnTrans.TabIndex = 3;
            this.btnTrans.Text = "Transactions";
            this.btnTrans.UseVisualStyleBackColor = false;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // btnCust
            // 
            this.btnCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.btnCust.FlatAppearance.BorderSize = 0;
            this.btnCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCust.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCust.ForeColor = System.Drawing.Color.White;
            this.btnCust.Image = ((System.Drawing.Image)(resources.GetObject("btnCust.Image")));
            this.btnCust.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCust.Location = new System.Drawing.Point(216, 342);
            this.btnCust.Name = "btnCust";
            this.btnCust.Size = new System.Drawing.Size(180, 132);
            this.btnCust.TabIndex = 4;
            this.btnCust.Text = "Customers";
            this.btnCust.UseVisualStyleBackColor = false;
            this.btnCust.Click += new System.EventHandler(this.btnCust_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(108, 81);
            this.btnBack.TabIndex = 6;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // userControlStock1
            // 
            this.userControlStock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userControlStock1.Location = new System.Drawing.Point(0, 80);
            this.userControlStock1.Name = "userControlStock1";
            this.userControlStock1.Size = new System.Drawing.Size(784, 482);
            this.userControlStock1.TabIndex = 5;
            this.userControlStock1.Load += new System.EventHandler(this.userControlStock1_Load);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.userControlStock1);
            this.Controls.Add(this.btnCust);
            this.Controls.Add(this.btnTrans);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.Button btnCust;
        private System.Windows.Forms.Button btnPower;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnBack;
        private UserControlStock userControlStock1;
    }
}