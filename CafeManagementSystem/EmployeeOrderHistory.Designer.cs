namespace CafeManagementSystem
{
    partial class EmployeeOrderHistory
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
            this.pnlEmployeeOrderHistory = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvOrderHistory = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlEmployeeOrderHistory.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHistory)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEmployeeOrderHistory
            // 
            this.pnlEmployeeOrderHistory.Controls.Add(this.panel2);
            this.pnlEmployeeOrderHistory.Controls.Add(this.panel1);
            this.pnlEmployeeOrderHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmployeeOrderHistory.Location = new System.Drawing.Point(0, 0);
            this.pnlEmployeeOrderHistory.Name = "pnlEmployeeOrderHistory";
            this.pnlEmployeeOrderHistory.Size = new System.Drawing.Size(1249, 721);
            this.pnlEmployeeOrderHistory.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvOrderHistory);
            this.panel2.Location = new System.Drawing.Point(3, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1243, 530);
            this.panel2.TabIndex = 1;
            // 
            // dgvOrderHistory
            // 
            this.dgvOrderHistory.AllowUserToAddRows = false;
            this.dgvOrderHistory.AllowUserToDeleteRows = false;
            this.dgvOrderHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderHistory.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderHistory.Location = new System.Drawing.Point(0, 3);
            this.dgvOrderHistory.Name = "dgvOrderHistory";
            this.dgvOrderHistory.ReadOnly = true;
            this.dgvOrderHistory.RowHeadersWidth = 51;
            this.dgvOrderHistory.RowTemplate.Height = 24;
            this.dgvOrderHistory.Size = new System.Drawing.Size(1240, 524);
            this.dgvOrderHistory.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 169);
            this.panel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(981, 112);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(238, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order History";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(782, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by invoice";
            // 
            // EmployeeOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlEmployeeOrderHistory);
            this.Name = "EmployeeOrderHistory";
            this.Size = new System.Drawing.Size(1249, 721);
            this.pnlEmployeeOrderHistory.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHistory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmployeeOrderHistory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvOrderHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
