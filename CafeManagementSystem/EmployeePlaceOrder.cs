using CafeManagementSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CafeManagementSystem
{
    public partial class EmployeePlaceOrder: UserControl
    {
        private FormLogin Fl { get; set; }
        private DataAccess Da { get; set; }

        private DataTable productsDt;
        public string CurrentUserId { get; set; } = "u-010";


        public EmployeePlaceOrder()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            string todayDate = GetTodayDateString();
            this.lblDate.Text = todayDate;
            this.AutoInvoiceGenerate();
            this.PopulateGridView();
            this.UpdateGrandTotal();

            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.MultiSelect = false;


        }

        private string GetTodayDateString()
        {
            string todayDate = DateTime.Now.ToString("yyyy-MM-dd");
            return todayDate;
        }
        // Load products
        private void PopulateGridView(string sql = "select ProductId, ProductName, Price, Stock from ProductInfo;")
        {
            productsDt = this.Da.ExecuteQueryTable(sql);
            this.dgvProduct.AutoGenerateColumns = true;
            this.dgvProduct.DataSource = productsDt;
        }

        // Search
        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            var sql = "select ProductId, ProductName, Price, Stock from ProductInfo where ProductName like '" + this.txtSearchProduct.Text + "%';";
            PopulateGridView(sql);
        }

        // New invoice id
        private void AutoInvoiceGenerate()
        {
            var query = "select MAX(SaleId) from Sales;";
            var dt = this.Da.ExecuteQueryTable(query);

            if (dt.Rows[0][0] == DBNull.Value)
            {
                this.lblInvoice.Text = "S-001";
            }
            else
            {
                var oldId = dt.Rows[0][0].ToString();
                var s = oldId.Split('-');
                var temp = Convert.ToInt32(s[1]);
                var newId = "S-" + (++temp).ToString("d3");
                this.lblInvoice.Text = newId;
            }
        }

        // Add product into cart (only memory, not DB yet)
        private void btnIncreaseQty_Click(object sender, EventArgs e)
        {
            if (dgvProduct.CurrentRow == null)
                return;

            int stock = Convert.ToInt32(dgvProduct.CurrentRow.Cells["Stock"].Value);
            if (stock <= 0)
            {
                MessageBox.Show("Out of stock!");
                return;
            }

            string pid = dgvProduct.CurrentRow.Cells["ProductId"].Value.ToString();
            string pname = dgvProduct.CurrentRow.Cells["ProductName"].Value.ToString();
            decimal price = Convert.ToDecimal(dgvProduct.CurrentRow.Cells["Price"].Value);

            var existing = lvCart.Items.Cast<ListViewItem>().FirstOrDefault(i => i.SubItems[0].Text == pid);

            if (existing != null)
            {
                int qty = Convert.ToInt32(existing.SubItems[3].Text);
                qty++;
                existing.SubItems[3].Text = qty.ToString();
            }
            else
            {
                var item = new ListViewItem(pid);
                item.SubItems.Add(pname);
                item.SubItems.Add(price.ToString("F2"));
                item.SubItems.Add("1");
                lvCart.Items.Add(item);
            }

            // decrease stock AFTER adding
            dgvProduct.CurrentRow.Cells["Stock"].Value = stock - 1;

            UpdateGrandTotal();
        }

        // Remove product from the list view
        private void btnDecreaseQty_Click(object sender, EventArgs e)
        {
            // require a selected item in the cart (lvCart)
            if (lvCart.SelectedItems.Count == 0) return;

            var selectedItem = lvCart.SelectedItems[0];

            // defensive: ensure quantity subitem exists
            if (selectedItem.SubItems.Count < 4) return;

            var pid = selectedItem.SubItems[0].Text;

            // find corresponding row in dgvProducts by PId
            DataGridViewRow row = null;

            foreach (DataGridViewRow r in dgvProduct.Rows)
            {
                if (r.Cells["ProductId"].Value != null && r.Cells["ProductId"].Value.ToString() == pid)
                {
                    row = r;
                    break; // stop after first match
                }
            }

            if (row == null) return; // nothing to update in grid

            // read product info from the found dgv row (same fields as in Increase)
            string pname = "";
            if (row.Cells["ProductName"].Value != null)
            {
                pname = row.Cells["ProductName"].Value.ToString();
            }
            var price = Convert.ToDecimal(row.Cells["Price"].Value);
            var stock = Convert.ToInt32(row.Cells["Stock"].Value);

            int qty = Convert.ToInt32(selectedItem.SubItems[3].Text);

            if (qty > 1)
            {
                qty--;
                selectedItem.SubItems[3].Text = qty.ToString();

                // Increase stock dynamically in dgv (UI only)
                row.Cells["Stock"].Value = stock + 1;
            }
            else
            {
                // Remove from cart and return one to stock
                lvCart.Items.Remove(selectedItem);
                row.Cells["Stock"].Value = stock + 1;
            }

            UpdateGrandTotal();
        }


        // Grand total update
        private void UpdateGrandTotal()
        {
            decimal total = 0;
            foreach (ListViewItem it in lvCart.Items)
            {
                var price = Convert.ToDecimal(it.SubItems[2].Text);
                var qty = Convert.ToInt32(it.SubItems[3].Text);
                total += price * qty;
            }
            lblGrandTotal.Text = total.ToString("F2"); //show 2 digits after the decimal
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (lvCart.Items.Count == 0) return;

            var saleId = this.lblInvoice.Text;
            var date = DateTime.Now.ToString("yyyy-MM-dd");
            var userId = this.CurrentUserId;

            List<string> pidList = new List<string>();
            int totalQty = 0;
            decimal totalPrice = 0;

            foreach (ListViewItem it in lvCart.Items)
            {
                var pid = it.SubItems[0].Text;
                var qty = Convert.ToInt32(it.SubItems[3].Text);
                var price = Convert.ToDecimal(it.SubItems[2].Text);

                pidList.Add(pid);
                totalQty += qty;
                totalPrice += price * qty;

                string sqlUpdate = "UPDATE ProductInfo SET Stock = Stock - " + qty + " WHERE ProductId = '" + pid + "';";
                Da.ExecuteDMLQuery(sqlUpdate);
            }


            string combinedPIds = string.Join(",", pidList);

            string sqlSales = "INSERT INTO Sales (SaleId, SaleDate, PTotalId, Quantity, SalePrice, Id) VALUES ('" + saleId + "', '" + date + "', '" + combinedPIds + "', '" + totalQty + "', " + totalPrice + ", '" + userId + "');";
            Da.ExecuteDMLQuery(sqlSales);
            DialogResult result = MessageBox.Show("Do you want to confirm this order?", "Confirm Order?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                MessageBox.Show("Order has been confirmed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Order has not been confirmed.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ClearCart();
            AutoInvoiceGenerate();
            PopulateGridView();
            UpdateGrandTotal();
        }


        private void btnClearCart_Click(object sender, EventArgs e)
        {
            ClearCart();
            UpdateGrandTotal();
        }

        private void ClearCart()
        {
            this.lvCart.Items.Clear();
            this.dgvProduct.ClearSelection();
        }
    }
}
