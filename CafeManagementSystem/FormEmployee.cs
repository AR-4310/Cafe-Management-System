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
    public partial class FormEmployee : Form
    {
        private FormLogin Fl { get; set; }
        public FormEmployee()
        {
            InitializeComponent();
        }

        public FormEmployee(string name, FormLogin fl) : this()
        {
            this.lblEmployeeName.Text += name;
            this.Fl = fl;
        }

        private void btnEmployeeDashboard_Click(object sender, EventArgs e)
        {
            employeePlaceOrder1.Hide();
            employeeOrderHistory1.Hide();

            employeeDashboard1.Show();
        }

        private void btnEmployeePlaceOrder_Click(object sender, EventArgs e)
        {
            employeeDashboard1.Hide();
            employeeOrderHistory1.Hide();

            employeePlaceOrder1.Show();
        }

        private void btnEmployeeOrderHistory_Click(object sender, EventArgs e)
        {
            employeeDashboard1.Hide();
            employeePlaceOrder1.Hide();

            employeeOrderHistory1.Show();
        }

        private void btnEmployeeLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MessageBox.Show("Logout successful!");
            this.Close();
            this.Fl.Visible = true;
        }
    }
}
