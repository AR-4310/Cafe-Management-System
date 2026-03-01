namespace CafeManagementSystem
{
    partial class FormEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            this.pnlEmployeeLeft = new System.Windows.Forms.Panel();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.btnEmployeeLogout = new System.Windows.Forms.Button();
            this.btnEmployeeOrderHistory = new System.Windows.Forms.Button();
            this.btnEmployeePlaceOrder = new System.Windows.Forms.Button();
            this.btnEmployeeDashboard = new System.Windows.Forms.Button();
            this.lblEmployeePortal = new System.Windows.Forms.Label();
            this.pnlEmployeeRight = new System.Windows.Forms.Panel();
            this.employeeDashboard1 = new CafeManagementSystem.EmployeeDashboard();
            this.employeeOrderHistory1 = new CafeManagementSystem.EmployeeOrderHistory();
            this.employeePlaceOrder1 = new CafeManagementSystem.EmployeePlaceOrder();
            this.pnlEmployeeLeft.SuspendLayout();
            this.pnlEmployeeRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEmployeeLeft
            // 
            this.pnlEmployeeLeft.BackColor = System.Drawing.Color.LemonChiffon;
            this.pnlEmployeeLeft.Controls.Add(this.lblEmployeeName);
            this.pnlEmployeeLeft.Controls.Add(this.btnEmployeeLogout);
            this.pnlEmployeeLeft.Controls.Add(this.btnEmployeeOrderHistory);
            this.pnlEmployeeLeft.Controls.Add(this.btnEmployeePlaceOrder);
            this.pnlEmployeeLeft.Controls.Add(this.btnEmployeeDashboard);
            this.pnlEmployeeLeft.Controls.Add(this.lblEmployeePortal);
            this.pnlEmployeeLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEmployeeLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlEmployeeLeft.Name = "pnlEmployeeLeft";
            this.pnlEmployeeLeft.Size = new System.Drawing.Size(233, 721);
            this.pnlEmployeeLeft.TabIndex = 0;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(21, 81);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(75, 16);
            this.lblEmployeeName.TabIndex = 2;
            this.lblEmployeeName.Text = "Employee: ";
            // 
            // btnEmployeeLogout
            // 
            this.btnEmployeeLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnEmployeeLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeLogout.Location = new System.Drawing.Point(41, 478);
            this.btnEmployeeLogout.Name = "btnEmployeeLogout";
            this.btnEmployeeLogout.Size = new System.Drawing.Size(138, 54);
            this.btnEmployeeLogout.TabIndex = 5;
            this.btnEmployeeLogout.Text = "Logout";
            this.btnEmployeeLogout.UseVisualStyleBackColor = false;
            this.btnEmployeeLogout.Click += new System.EventHandler(this.btnEmployeeLogout_Click);
            // 
            // btnEmployeeOrderHistory
            // 
            this.btnEmployeeOrderHistory.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEmployeeOrderHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeOrderHistory.Location = new System.Drawing.Point(41, 295);
            this.btnEmployeeOrderHistory.Name = "btnEmployeeOrderHistory";
            this.btnEmployeeOrderHistory.Size = new System.Drawing.Size(154, 58);
            this.btnEmployeeOrderHistory.TabIndex = 4;
            this.btnEmployeeOrderHistory.Text = "Order History";
            this.btnEmployeeOrderHistory.UseVisualStyleBackColor = false;
            this.btnEmployeeOrderHistory.Click += new System.EventHandler(this.btnEmployeeOrderHistory_Click);
            // 
            // btnEmployeePlaceOrder
            // 
            this.btnEmployeePlaceOrder.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEmployeePlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeePlaceOrder.Location = new System.Drawing.Point(41, 205);
            this.btnEmployeePlaceOrder.Name = "btnEmployeePlaceOrder";
            this.btnEmployeePlaceOrder.Size = new System.Drawing.Size(154, 62);
            this.btnEmployeePlaceOrder.TabIndex = 3;
            this.btnEmployeePlaceOrder.Text = "Place Order";
            this.btnEmployeePlaceOrder.UseVisualStyleBackColor = false;
            this.btnEmployeePlaceOrder.Click += new System.EventHandler(this.btnEmployeePlaceOrder_Click);
            // 
            // btnEmployeeDashboard
            // 
            this.btnEmployeeDashboard.BackColor = System.Drawing.Color.Thistle;
            this.btnEmployeeDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeDashboard.Location = new System.Drawing.Point(41, 129);
            this.btnEmployeeDashboard.Name = "btnEmployeeDashboard";
            this.btnEmployeeDashboard.Size = new System.Drawing.Size(154, 58);
            this.btnEmployeeDashboard.TabIndex = 1;
            this.btnEmployeeDashboard.Text = "Dashboard";
            this.btnEmployeeDashboard.UseVisualStyleBackColor = false;
            this.btnEmployeeDashboard.Click += new System.EventHandler(this.btnEmployeeDashboard_Click);
            // 
            // lblEmployeePortal
            // 
            this.lblEmployeePortal.AutoSize = true;
            this.lblEmployeePortal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmployeePortal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeePortal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEmployeePortal.Location = new System.Drawing.Point(24, 25);
            this.lblEmployeePortal.Name = "lblEmployeePortal";
            this.lblEmployeePortal.Size = new System.Drawing.Size(171, 27);
            this.lblEmployeePortal.TabIndex = 0;
            this.lblEmployeePortal.Text = "Employee Portal";
            // 
            // pnlEmployeeRight
            // 
            this.pnlEmployeeRight.Controls.Add(this.employeeDashboard1);
            this.pnlEmployeeRight.Controls.Add(this.employeeOrderHistory1);
            this.pnlEmployeeRight.Controls.Add(this.employeePlaceOrder1);
            this.pnlEmployeeRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmployeeRight.Location = new System.Drawing.Point(233, 0);
            this.pnlEmployeeRight.Name = "pnlEmployeeRight";
            this.pnlEmployeeRight.Size = new System.Drawing.Size(1249, 721);
            this.pnlEmployeeRight.TabIndex = 1;
            // 
            // employeeDashboard1
            // 
            this.employeeDashboard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("employeeDashboard1.BackgroundImage")));
            this.employeeDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeDashboard1.Location = new System.Drawing.Point(0, 0);
            this.employeeDashboard1.Name = "employeeDashboard1";
            this.employeeDashboard1.Size = new System.Drawing.Size(1249, 721);
            this.employeeDashboard1.TabIndex = 3;
            // 
            // employeeOrderHistory1
            // 
            this.employeeOrderHistory1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeOrderHistory1.Location = new System.Drawing.Point(0, 0);
            this.employeeOrderHistory1.Name = "employeeOrderHistory1";
            this.employeeOrderHistory1.Size = new System.Drawing.Size(1249, 721);
            this.employeeOrderHistory1.TabIndex = 2;
            // 
            // employeePlaceOrder1
            // 
            this.employeePlaceOrder1.CurrentUserId = "u-010";
            this.employeePlaceOrder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeePlaceOrder1.Location = new System.Drawing.Point(0, 0);
            this.employeePlaceOrder1.Name = "employeePlaceOrder1";
            this.employeePlaceOrder1.Size = new System.Drawing.Size(1249, 721);
            this.employeePlaceOrder1.TabIndex = 1;
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 721);
            this.Controls.Add(this.pnlEmployeeRight);
            this.Controls.Add(this.pnlEmployeeLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.pnlEmployeeLeft.ResumeLayout(false);
            this.pnlEmployeeLeft.PerformLayout();
            this.pnlEmployeeRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEmployeeLeft;
        private System.Windows.Forms.Button btnEmployeeLogout;
        private System.Windows.Forms.Button btnEmployeeOrderHistory;
        private System.Windows.Forms.Button btnEmployeePlaceOrder;
        private System.Windows.Forms.Button btnEmployeeDashboard;
        private System.Windows.Forms.Label lblEmployeePortal;
        private System.Windows.Forms.Panel pnlEmployeeRight;
       
        private EmployeeDashboard employeeDashboard1;
        private EmployeeOrderHistory employeeOrderHistory1;
        private EmployeePlaceOrder employeePlaceOrder1;
        private System.Windows.Forms.Label lblEmployeeName;
    }
}

