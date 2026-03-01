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
    public partial class FormAdmin : Form
    {
        //connected with formlogin
        private FormLogin Fl { get; set; }
        private DataAccess Da { get; set; }
        public FormAdmin()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        public FormAdmin(string name, FormLogin fl) : this()
        {
            this.lblAdminName.Text += name;
            this.Fl = fl;
        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            adminManageAccount1.Hide();
            adminManageProduct1.Hide();
            employeeOrderHistory1.Hide();
            employeePlaceOrder1.Hide();

            adminDashboard1.Show();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            adminManageAccount1.Hide();
            adminManageProduct1.Hide();
            employeeOrderHistory1.Hide();
            adminDashboard1.Hide();

            employeePlaceOrder1.Show();
        }

        private void btnAdminManageProduct_Click(object sender, EventArgs e)
        {
            adminManageAccount1.Hide();
            employeePlaceOrder1.Hide();
            employeeOrderHistory1.Hide();
            adminDashboard1.Hide();

            adminManageProduct1.Show();
        }

        private void btnAdminManageAccount_Click(object sender, EventArgs e)
        {
            adminManageProduct1.Hide();
            employeePlaceOrder1.Hide();
            employeeOrderHistory1.Hide();
            adminDashboard1.Hide();

            adminManageAccount1.Show();
        }

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            adminManageProduct1.Hide();
            employeePlaceOrder1.Hide();
            adminManageAccount1.Hide();
            adminDashboard1.Hide();

            employeeOrderHistory1.Show();
        }

        private void lblAdminName_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MessageBox.Show("Admin Logged out from the system");
            this.Close();
            this.Fl.Visible = true;
        }

       
    }
}
