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
    public partial class AdminDashboard : UserControl
    {
        public AdminDashboard()
        {
            InitializeComponent();
            this.Load += AdminDashboard_Load; 
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            LoadTotalEmployees();
            LoadTotalOrders();
            LoadTotalIncome();
        }

        private void LoadTotalEmployees()
        {
            DataAccess da = new DataAccess();
            string sql = "SELECT COUNT(*) AS TotalEmployees FROM UserInfo WHERE role = 'employee'";
            DataTable dt = da.ExecuteQueryTable(sql);

            if (dt.Rows.Count > 0)
            {
                lblTotalEmployee.Text = dt.Rows[0]["TotalEmployees"].ToString();
            }
            else
            {
                lblTotalEmployee.Text = "0";
            }
        }

        private void LoadTotalOrders()
        {
            DataAccess da = new DataAccess();
            string sql = "SELECT COUNT(*) AS TotalOrders FROM Sales";
            DataTable dt = da.ExecuteQueryTable(sql);

            if (dt.Rows.Count > 0)
            {
                lblTotalOrders.Text = dt.Rows[0]["TotalOrders"].ToString();
            }
            else
            {
                lblTotalOrders.Text = "0";
            }
        }

        private void LoadTotalIncome()
        {
            DataAccess da = new DataAccess();
            string sql = "SELECT SUM(SalePrice) AS TotalIncome FROM Sales";
            DataTable dt = da.ExecuteQueryTable(sql);

            if (dt.Rows.Count > 0 && dt.Rows[0]["TotalIncome"] != DBNull.Value)
            {
                decimal income = Convert.ToDecimal(dt.Rows[0]["TotalIncome"]);
                lblTotalIncome.Text = income.ToString("C"); // currency format
            }
            else
            {
                lblTotalIncome.Text = "$0.00";
            }
        }
    }
}