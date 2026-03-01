using CafeManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class AdminManageProduct : UserControl
    {
        private DataAccess Da { get; set; }
        public AdminManageProduct()
        {
            InitializeComponent();
            this.Da = new DataAccess(); 
            this.AutoIdGenerate();
            this.dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.CellDoubleClick += dgvProduct_CellDoubleClick;
            this.PopulateGridView();

        }

        private void PopulateGridView(string sql = "select * from ProductInfo;")
        {
            var ds = this.Da.ExecuteQueryTable(sql);
            this.dgvProduct.AutoGenerateColumns = true; 
            this.dgvProduct.DataSource = ds; 
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtId.Text) ||
                string.IsNullOrEmpty(this.txtProductName.Text) ||
                string.IsNullOrEmpty(this.cmbCatagory.Text) ||
                  string.IsNullOrEmpty(this.txtProductPrice.Text) ||
                   string.IsNullOrEmpty(this.txtProductStock.Text) ||
                    string.IsNullOrEmpty(this.txtProductDescription.Text)
                )
                return false; //is it null
            else
                return true; // have value
        }
        private void AutoIdGenerate()
        {
            var query = "select MAX(ProductId) from ProductInfo;";
            var dt = this.Da.ExecuteQueryTable(query);


            if (dt.Rows[0][0] == DBNull.Value)
            {
                this.txtId.Text = "P-001";
            }
            else
            {
                var oldId = dt.Rows[0][0].ToString();
                var s = oldId.Split('-');
                var temp = Convert.ToInt32(s[1]);
                var newId = "P-" + (++temp).ToString("d3");
                this.txtId.Text = newId;
            }
        }
        private void ClearAll()
        {
            this.txtId.Clear();
            this.txtProductName.Clear();
            this.cmbCatagory.SelectedIndex = -1;
            this.txtProductPrice.Clear();
            this.txtProductStock.Clear();
            this.txtProductDescription.Clear();

            this.txtDynamicSearch.Clear();
            this.dgvProduct.ClearSelection(); 
            this.AutoIdGenerate();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty firelds");
                    return;
                }

                var query = "select * from ProductInfo where ProductId = '" + this.txtId.Text + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    var sql = @"update ProductInfo
                                set ProductName = '" + this.txtProductName.Text + @"',
                                Catagory = '" + this.cmbCatagory.Text + @"',
                                Price = " + this.txtProductPrice.Text + @",
                                Stock = " + this.txtProductStock.Text + @",
                                Description = '" + this.txtProductDescription.Text + @"'
                                where ProductId = '" + this.txtId.Text + "';";

                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated");
                    else
                        MessageBox.Show("Data hasn't been updated");
                }
                else
                {
                    var sql = "insert into ProductInfo (ProductId, ProductName, Catagory, Price, Stock, Description) " + "values ('" + this.txtId.Text + "', '" + this.txtProductName.Text + "', '" + this.cmbCatagory.Text + "', " + this.txtProductPrice.Text + ", " + this.txtProductStock.Text + ", '" + this.txtProductDescription.Text + "');";


                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been added");
                    else
                        MessageBox.Show("Data hasn't been added");

                }

                this.PopulateGridView();
                this.ClearAll();


            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvProduct.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                var id = this.dgvProduct.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvProduct.CurrentRow.Cells[1].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + name + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;

                var sql = "delete from ProductInfo where ProductId = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed from the list");
                else
                    MessageBox.Show("Data hasn't been deleted");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void txtDynamicSearch_TextChanged_1(object sender, EventArgs e)
        {
            var sql = "select * from ProductInfo where ProductName like '" + this.txtDynamicSearch.Text + "%';";

            this.PopulateGridView(sql);
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // make sure it's not the header row
            {
                DataGridViewRow row = this.dgvProduct.Rows[e.RowIndex];

                this.txtId.Text = row.Cells["ProductId"].Value.ToString();
                this.txtProductName.Text = row.Cells["ProductName"].Value.ToString();
                this.cmbCatagory.Text = row.Cells["Catagory"].Value.ToString();
                this.txtProductPrice.Text = row.Cells["Price"].Value.ToString();
                this.txtProductStock.Text = row.Cells["Stock"].Value.ToString();
                this.txtProductDescription.Text = row.Cells["Description"].Value.ToString();
            }
        }
    }
}
