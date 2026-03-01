namespace CafeManagementSystem
{
    partial class FormAdmin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.btnAdminLogout = new System.Windows.Forms.Button();
            this.btnAdminManageAccount = new System.Windows.Forms.Button();
            this.btnAdminManageProduct = new System.Windows.Forms.Button();
            this.btnAdminDashboard = new System.Windows.Forms.Button();
            this.lblEmployeePortal = new System.Windows.Forms.Label();
            this.adminDashboard1 = new CafeManagementSystem.AdminDashboard();
            this.employeePlaceOrder1 = new CafeManagementSystem.EmployeePlaceOrder();
            this.adminManageProduct1 = new CafeManagementSystem.AdminManageProduct();
            this.adminManageAccount1 = new CafeManagementSystem.AdminManageAccount();
            this.employeeOrderHistory1 = new CafeManagementSystem.EmployeeOrderHistory();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lblAdminName);
            this.panel1.Controls.Add(this.btnOrderDetails);
            this.panel1.Controls.Add(this.btnAdminLogout);
            this.panel1.Controls.Add(this.btnAdminManageAccount);
            this.panel1.Controls.Add(this.btnAdminManageProduct);
            this.panel1.Controls.Add(this.btnAdminDashboard);
            this.panel1.Controls.Add(this.lblEmployeePortal);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 721);
            this.panel1.TabIndex = 0;
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Location = new System.Drawing.Point(46, 96);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(51, 16);
            this.lblAdminName.TabIndex = 6;
            this.lblAdminName.Text = "Admin: ";
            this.lblAdminName.Click += new System.EventHandler(this.lblAdminName_Click);
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDetails.ForeColor = System.Drawing.Color.Black;
            this.btnOrderDetails.Location = new System.Drawing.Point(12, 380);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(188, 59);
            this.btnOrderDetails.TabIndex = 8;
            this.btnOrderDetails.Text = "Order History";
            this.btnOrderDetails.UseVisualStyleBackColor = false;
            this.btnOrderDetails.Click += new System.EventHandler(this.btnOrderDetails_Click);
            // 
            // btnAdminLogout
            // 
            this.btnAdminLogout.BackColor = System.Drawing.Color.Red;
            this.btnAdminLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogout.ForeColor = System.Drawing.Color.Black;
            this.btnAdminLogout.Location = new System.Drawing.Point(28, 608);
            this.btnAdminLogout.Name = "btnAdminLogout";
            this.btnAdminLogout.Size = new System.Drawing.Size(158, 51);
            this.btnAdminLogout.TabIndex = 7;
            this.btnAdminLogout.Text = "Logout";
            this.btnAdminLogout.UseVisualStyleBackColor = false;
            this.btnAdminLogout.Click += new System.EventHandler(this.btnAdminLogout_Click);
            // 
            // btnAdminManageAccount
            // 
            this.btnAdminManageAccount.BackColor = System.Drawing.Color.Yellow;
            this.btnAdminManageAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminManageAccount.ForeColor = System.Drawing.Color.Black;
            this.btnAdminManageAccount.Location = new System.Drawing.Point(12, 298);
            this.btnAdminManageAccount.Name = "btnAdminManageAccount";
            this.btnAdminManageAccount.Size = new System.Drawing.Size(188, 59);
            this.btnAdminManageAccount.TabIndex = 5;
            this.btnAdminManageAccount.Text = "Manage Account";
            this.btnAdminManageAccount.UseVisualStyleBackColor = false;
            this.btnAdminManageAccount.Click += new System.EventHandler(this.btnAdminManageAccount_Click);
            // 
            // btnAdminManageProduct
            // 
            this.btnAdminManageProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdminManageProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminManageProduct.ForeColor = System.Drawing.Color.Black;
            this.btnAdminManageProduct.Location = new System.Drawing.Point(12, 219);
            this.btnAdminManageProduct.Name = "btnAdminManageProduct";
            this.btnAdminManageProduct.Size = new System.Drawing.Size(188, 59);
            this.btnAdminManageProduct.TabIndex = 4;
            this.btnAdminManageProduct.Text = "Manage Product";
            this.btnAdminManageProduct.UseVisualStyleBackColor = false;
            this.btnAdminManageProduct.Click += new System.EventHandler(this.btnAdminManageProduct_Click);
            // 
            // btnAdminDashboard
            // 
            this.btnAdminDashboard.BackColor = System.Drawing.Color.LightCoral;
            this.btnAdminDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnAdminDashboard.Location = new System.Drawing.Point(12, 138);
            this.btnAdminDashboard.Name = "btnAdminDashboard";
            this.btnAdminDashboard.Size = new System.Drawing.Size(188, 59);
            this.btnAdminDashboard.TabIndex = 2;
            this.btnAdminDashboard.Text = "Dashboard";
            this.btnAdminDashboard.UseVisualStyleBackColor = false;
            this.btnAdminDashboard.Click += new System.EventHandler(this.btnAdminDashboard_Click);
            // 
            // lblEmployeePortal
            // 
            this.lblEmployeePortal.AutoSize = true;
            this.lblEmployeePortal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmployeePortal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeePortal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmployeePortal.Location = new System.Drawing.Point(40, 45);
            this.lblEmployeePortal.Name = "lblEmployeePortal";
            this.lblEmployeePortal.Size = new System.Drawing.Size(137, 27);
            this.lblEmployeePortal.TabIndex = 1;
            this.lblEmployeePortal.Text = "Admin Portal";
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.Location = new System.Drawing.Point(221, 0);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(1249, 721);
            this.adminDashboard1.TabIndex = 5;
            
            // 
            // employeePlaceOrder1
            // 
            this.employeePlaceOrder1.CurrentUserId = "u-010";
            this.employeePlaceOrder1.Location = new System.Drawing.Point(221, 0);
            this.employeePlaceOrder1.Name = "employeePlaceOrder1";
            this.employeePlaceOrder1.Size = new System.Drawing.Size(1249, 721);
            this.employeePlaceOrder1.TabIndex = 4;
            // 
            // adminManageProduct1
            // 
            this.adminManageProduct1.Location = new System.Drawing.Point(221, 0);
            this.adminManageProduct1.Name = "adminManageProduct1";
            this.adminManageProduct1.Size = new System.Drawing.Size(1249, 721);
            this.adminManageProduct1.TabIndex = 3;
            // 
            // adminManageAccount1
            // 
            this.adminManageAccount1.Location = new System.Drawing.Point(221, 0);
            this.adminManageAccount1.Name = "adminManageAccount1";
            this.adminManageAccount1.Size = new System.Drawing.Size(1249, 721);
            this.adminManageAccount1.TabIndex = 2;
            // 
            // employeeOrderHistory1
            // 
            this.employeeOrderHistory1.Location = new System.Drawing.Point(221, 0);
            this.employeeOrderHistory1.Name = "employeeOrderHistory1";
            this.employeeOrderHistory1.Size = new System.Drawing.Size(1249, 721);
            this.employeeOrderHistory1.TabIndex = 1;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 721);
            this.Controls.Add(this.adminDashboard1);
            this.Controls.Add(this.employeePlaceOrder1);
            this.Controls.Add(this.adminManageProduct1);
            this.Controls.Add(this.adminManageAccount1);
            this.Controls.Add(this.employeeOrderHistory1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmployeePortal;
        private System.Windows.Forms.Button btnAdminDashboard;
        private System.Windows.Forms.Button btnAdminManageAccount;
        private System.Windows.Forms.Button btnAdminManageProduct;
        private System.Windows.Forms.Button btnAdminLogout;
        private System.Windows.Forms.Button btnOrderDetails;
        private EmployeeOrderHistory employeeOrderHistory1;
        private AdminManageAccount adminManageAccount1;
        private AdminManageProduct adminManageProduct1;
        private EmployeePlaceOrder employeePlaceOrder1;
        private AdminDashboard adminDashboard1;
        private System.Windows.Forms.Label lblAdminName;
    }
}