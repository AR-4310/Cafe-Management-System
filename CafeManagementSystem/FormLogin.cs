using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class FormLogin : Form
    {
        private DataAccess da;
        public FormLogin()
        {
            InitializeComponent();
            this.da = new DataAccess();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtUserId.Text) || string.IsNullOrEmpty(this.txtPassword.Text))
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }
                string sql = "select * from UserInfo where userId = '" + this.txtUserId.Text + "' and password = '" + this.txtPassword.Text + "'";
                DataSet ds = this.da.ExecuteQuery(sql);
                var name = ds.Tables[0].Rows[0][1].ToString();
                var id = ds.Tables[0].Rows[0][0].ToString();//id on 0 column
                if (ds.Tables[0].Rows.Count == 1)
                {
                    //Admin
                    if (ds.Tables[0].Rows[0][3].ToString().Trim().Equals("admin"))
                    {
                        this.txtUserId.Clear();
                        this.txtPassword.Clear();
                        this.Visible = false;
                        new FormAdmin(name, this).Show();
                    }
                    //Employee
                    else if (ds.Tables[0].Rows[0][3].ToString().Trim().Equals("employee"))
                    {

                        this.txtUserId.Clear();
                        this.txtPassword.Clear();
                        this.Visible = false;
                        new FormEmployee(name, this).Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User");
                }
            }
            //exception big error
            catch (Exception exc)
            {
                MessageBox.Show("Invalid User Info " + exc.Message);
            }
        }

        private void btnLoginClear_Click(object sender, EventArgs e)
        {
            this.txtUserId.Clear();
            this.txtPassword.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowPassword.Checked)
            {
                // Show password
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                // Hide password
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
