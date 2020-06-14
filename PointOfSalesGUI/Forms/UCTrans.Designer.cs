namespace PointOfSalesGUI.Forms
{
    partial class UCTrans
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
            this.dataGridViewTrans = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTrans
            // 
            this.dataGridViewTrans.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dataGridViewTrans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrans.Location = new System.Drawing.Point(38, 157);
            this.dataGridViewTrans.Name = "dataGridViewTrans";
            this.dataGridViewTrans.ReadOnly = true;
            this.dataGridViewTrans.Size = new System.Drawing.Size(1207, 538);
            this.dataGridViewTrans.TabIndex = 1;
            // 
            // UCTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(255)))), ((int)(((byte)(235)))));
            this.Controls.Add(this.dataGridViewTrans);
            this.Name = "UCTrans";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.UCTrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTrans;
    }
}
