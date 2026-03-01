using CafeManagementSystem;
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
    public partial class AdminManageAccount : UserControl
    {
        private DataAccess Da { get; set; }
        public AdminManageAccount()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.AutoIdGenerate();

            this.dgvAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.MultiSelect = false;

            this.dgvAccount.CellDoubleClick += dgvAccount_CellDoubleClick; //attaching
            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from UserInfo where role='employee';")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvAccount.AutoGenerateColumns = true;
            this.dgvAccount.DataSource = ds.Tables[0];
        }
        private void AutoIdGenerate()
        {
            var query = "select MAX(userId) from UserInfo;";
            var dt = this.Da.ExecuteQueryTable(query);

            if (dt.Rows[0][0] == DBNull.Value)
            {
                this.txtId.Text = "E-001";
            }
            else
            {
                var oldId = dt.Rows[0][0].ToString();
                var s = oldId.Split('-');
                var temp = Convert.ToInt32(s[1]);
                var newId = "E-" + (++temp).ToString("d3");
                this.txtId.Text = newId;
            }
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtId.Text) ||
                string.IsNullOrEmpty(this.txtName.Text) ||
                string.IsNullOrEmpty(this.cmbRole.Text) ||
                string.IsNullOrEmpty(this.txtPassword.Text))
                return false; //empty

            return true; //filled
        }
        private void ClearAll()
        {
            this.txtId.Clear();
            this.txtName.Clear();
            this.cmbRole.SelectedIndex = -1; //nothing selected in the combobox
            this.txtPassword.Clear();
            this.dgvAccount.ClearSelection(); //clearing highlighted row in datagridview
            this.AutoIdGenerate();
        }



        private void txtDynamicSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM userinfo WHERE Role = 'employee' AND userId LIKE '" + this.txtDynamicSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all fields correctly.");
                    return;
                }

                var query = "select * from UserInfo where userId = '" + this.txtId.Text + "';";
                var dt = this.Da.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1) //user exists so update info
                {
                    var sql = @"update UserInfo
                                set name = '" + this.txtName.Text + @"',
                                    password = '" + this.txtPassword.Text + @"',
                                    role = '" + this.cmbRole.Text + @"'
                                where userId = '" + this.txtId.Text + "';";

                    var count = this.Da.ExecuteDMLQuery(sql);
                    if (count == 1)
                        MessageBox.Show("Data has been updated");
                    else
                        MessageBox.Show("Data hasn't been updated");
                }
                else //user doesnt exist so insert
                {
                    var sql = "insert into UserInfo (userId, name, password, role) " + "values ('" + this.txtId.Text + "', '" + this.txtName.Text + "', '" + this.txtPassword.Text + "', '" + this.cmbRole.Text + "');";

                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)

                        MessageBox.Show("Data has been added");
                    else

                        MessageBox.Show("Insert failed");

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
                if (this.dgvAccount.SelectedRows.Count < 1) //no row selected
                {
                    MessageBox.Show("Please select a row first to delete.");
                    return;
                }

                var id = this.dgvAccount.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvAccount.CurrentRow.Cells[1].Value.ToString();

                DialogResult res = MessageBox.Show("Are you sure to remove " + name + "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.No)
                    return;

                var sql = "delete from UserInfo where userId = '" + id + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been removed");
                else
                    MessageBox.Show(name.ToUpper() + "Delete failed");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
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

        private void dgvAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // make sure it's not the header row
            {
                DataGridViewRow row = this.dgvAccount.Rows[e.RowIndex];

                this.txtId.Text = row.Cells["userId"].Value.ToString();
                this.txtName.Text = row.Cells["name"].Value.ToString();
                this.cmbRole.Text = row.Cells["role"].Value.ToString();
                this.txtPassword.Text = row.Cells["password"].Value.ToString();
            }

        }
    }
}
