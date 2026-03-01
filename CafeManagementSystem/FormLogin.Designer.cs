namespace CafeManagementSystem
{
    partial class FormLogin
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
            this.pnlLoginRight = new System.Windows.Forms.Panel();
            this.checkboxShowPassword = new System.Windows.Forms.CheckBox();
            this.btnLoginClear = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblLoginPassword = new System.Windows.Forms.Label();
            this.lblLoginUsername = new System.Windows.Forms.Label();
            this.lblLoginWelcome = new System.Windows.Forms.Label();
            this.pnlLoginLeft = new System.Windows.Forms.Panel();
            this.pnlLoginRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLoginRight
            // 
            this.pnlLoginRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlLoginRight.Controls.Add(this.checkboxShowPassword);
            this.pnlLoginRight.Controls.Add(this.btnLoginClear);
            this.pnlLoginRight.Controls.Add(this.btnLogin);
            this.pnlLoginRight.Controls.Add(this.txtPassword);
            this.pnlLoginRight.Controls.Add(this.txtUserId);
            this.pnlLoginRight.Controls.Add(this.lblLoginPassword);
            this.pnlLoginRight.Controls.Add(this.lblLoginUsername);
            this.pnlLoginRight.Controls.Add(this.lblLoginWelcome);
            this.pnlLoginRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoginRight.Location = new System.Drawing.Point(524, 0);
            this.pnlLoginRight.Name = "pnlLoginRight";
            this.pnlLoginRight.Size = new System.Drawing.Size(571, 511);
            this.pnlLoginRight.TabIndex = 1;
            // 
            // checkboxShowPassword
            // 
            this.checkboxShowPassword.AutoSize = true;
            this.checkboxShowPassword.Location = new System.Drawing.Point(382, 360);
            this.checkboxShowPassword.Name = "checkboxShowPassword";
            this.checkboxShowPassword.Size = new System.Drawing.Size(125, 20);
            this.checkboxShowPassword.TabIndex = 2;
            this.checkboxShowPassword.Text = "Show Password";
            this.checkboxShowPassword.UseVisualStyleBackColor = true;
            this.checkboxShowPassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnLoginClear
            // 
            this.btnLoginClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLoginClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginClear.Location = new System.Drawing.Point(334, 395);
            this.btnLoginClear.Name = "btnLoginClear";
            this.btnLoginClear.Size = new System.Drawing.Size(108, 47);
            this.btnLoginClear.TabIndex = 6;
            this.btnLoginClear.Text = "Clear";
            this.btnLoginClear.UseVisualStyleBackColor = false;
            this.btnLoginClear.Click += new System.EventHandler(this.btnLoginClear_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Peru;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(153, 395);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(108, 47);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(112, 310);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(346, 30);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(112, 188);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(346, 30);
            this.txtUserId.TabIndex = 3;
        
            // 
            // lblLoginPassword
            // 
            this.lblLoginPassword.AutoSize = true;
            this.lblLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginPassword.Location = new System.Drawing.Point(107, 254);
            this.lblLoginPassword.Name = "lblLoginPassword";
            this.lblLoginPassword.Size = new System.Drawing.Size(113, 25);
            this.lblLoginPassword.TabIndex = 2;
            this.lblLoginPassword.Text = "Password:";
            // 
            // lblLoginUsername
            // 
            this.lblLoginUsername.AutoSize = true;
            this.lblLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUsername.Location = new System.Drawing.Point(107, 134);
            this.lblLoginUsername.Name = "lblLoginUsername";
            this.lblLoginUsername.Size = new System.Drawing.Size(84, 25);
            this.lblLoginUsername.TabIndex = 1;
            this.lblLoginUsername.Text = "User ID";
            // 
            // lblLoginWelcome
            // 
            this.lblLoginWelcome.AutoSize = true;
            this.lblLoginWelcome.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLoginWelcome.Location = new System.Drawing.Point(207, 40);
            this.lblLoginWelcome.Name = "lblLoginWelcome";
            this.lblLoginWelcome.Size = new System.Drawing.Size(173, 52);
            this.lblLoginWelcome.TabIndex = 0;
            this.lblLoginWelcome.Text = "CafeEase";
            // 
            // pnlLoginLeft
            // 
            this.pnlLoginLeft.BackgroundImage = global::CafeManagementSystem.Properties.Resources.bg;
            this.pnlLoginLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLoginLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLoginLeft.Name = "pnlLoginLeft";
            this.pnlLoginLeft.Size = new System.Drawing.Size(524, 511);
            this.pnlLoginLeft.TabIndex = 0;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 511);
            this.Controls.Add(this.pnlLoginRight);
            this.Controls.Add(this.pnlLoginLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlLoginRight.ResumeLayout(false);
            this.pnlLoginRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLoginLeft;
        private System.Windows.Forms.Panel pnlLoginRight;
        private System.Windows.Forms.Label lblLoginPassword;
        private System.Windows.Forms.Label lblLoginUsername;
        private System.Windows.Forms.Label lblLoginWelcome;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnLoginClear;
        private System.Windows.Forms.CheckBox checkboxShowPassword;
    }
}