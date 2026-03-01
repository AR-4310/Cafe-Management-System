namespace CafeManagementSystem
{
    partial class EmployeeDashboard
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
            this.lblEmployeeDashboard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEmployeeDashboard
            // 
            this.lblEmployeeDashboard.AutoSize = true;
            this.lblEmployeeDashboard.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblEmployeeDashboard.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEmployeeDashboard.Location = new System.Drawing.Point(408, 95);
            this.lblEmployeeDashboard.Name = "lblEmployeeDashboard";
            this.lblEmployeeDashboard.Size = new System.Drawing.Size(347, 56);
            this.lblEmployeeDashboard.TabIndex = 0;
            this.lblEmployeeDashboard.Text = "Welcome to Portal";
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CafeManagementSystem.Properties.Resources.OIP;
            this.Controls.Add(this.lblEmployeeDashboard);
            this.Name = "EmployeeDashboard";
            this.Size = new System.Drawing.Size(1249, 721);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeDashboard;
    }
}
