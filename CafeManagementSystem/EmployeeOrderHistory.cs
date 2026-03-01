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
    public partial class EmployeeOrderHistory : UserControl
    {
        private DataAccess Da { get; set; }
        public EmployeeOrderHistory()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            string sql = "select SaleId,Quantity,SalePrice,SaleDate from Sales;";
            var ds = this.Da.ExecuteQuery(sql);
            this.dgvOrderHistory.DataSource = ds.Tables[0];
        }
        private void PopulateGridViewDynamic()
        {
            string sqlDynamic = "select SaleId,Quantity,SalePrice,SaleDate from sales where SaleId like '" + this.txtSearch.Text + "%';";
            var ds = this.Da.ExecuteQuery(sqlDynamic);
            this.dgvOrderHistory.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select SaleId,Quantity,SalePrice,SaleDate from sales where SaleId like '" + this.txtSearch.Text + "%';";
            this.PopulateGridViewDynamic();
        }
    }
}
