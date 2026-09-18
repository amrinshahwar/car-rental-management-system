using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem
{
    public partial class Expense : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private string userRole;
        private string accId;
        public Expense(string role, string empId)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.userRole = role;

            if (userRole != "Admin")
            {
                GenerateExpenseId();
            }
            else
            {
                txtExpId.Clear();
            }

            this.accId = empId;

            PopulateGridView();
            LoadMaintenanceId();
            ConfigureRole();
        }
        private void ConfigureRole()
        {
            if (userRole.ToLower() == "admin")
            {
                btnAddExp.Visible = false;
                btnUpdateExp.Visible = false;
                btnDltExp.Visible = false;
                btnClear.Visible = false;

                cmbMId.Enabled = false;
                cmbExpCarReg.Enabled = false;
                cmbExpCarModel.Enabled = false;
                cmbExpMaintenanceType.Enabled = false;
                dtpExpDate.Enabled = false;
                txtExpCost.ReadOnly = true;
            }
            else 
            {
                btnAddExp.Visible = true;
                btnUpdateExp.Visible = true;
                btnDltExp.Visible = true;
                btnClear.Visible = true;

                cmbMId.Enabled = true;
                cmbExpCarReg.Enabled = true;
                cmbExpCarModel.Enabled = true;
                cmbExpMaintenanceType.Enabled = true;
                dtpExpDate.Enabled = true;
                txtExpCost.ReadOnly = false;
            }
        }
        private void PopulateGridView(string sql = "")
        {
            if (string.IsNullOrEmpty(sql))
            {
                sql = @"select e.ExpId, e.MId, mc.RegNo, mc.Model, m.MType, m.Date, e.Cost, e.EmpId
                      from Expense e join Maintenance m on e.MId = m.MId join 
                      Manage_Car mc on m.RegNo = mc.RegNo;";

            }

            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvExp.AutoGenerateColumns = false;
            this.dgvExp.DataSource = this.Ds.Tables[0];
        }
        private void GenerateExpenseId()
        {
            this.Sql = "select * from Expense order by ExpId desc;";
            DataTable dt = this.Da.ExecuteQueryTable(this.Sql);

            if (dt.Rows.Count > 0)
            {
                string id = dt.Rows[0]["ExpId"].ToString();
                string[] str = id.Split('E');
                int n = Convert.ToInt32(str[1]);
                string newID = "E" + (++n).ToString("d4");
                this.txtExpId.Text = newID;
            }
            else
            {
                this.txtExpId.Text = "E0001";
            }
            this.txtExpId.ReadOnly = true;
        }
        private void LoadMaintenanceId()
        {
            this.Sql = "select MId from Maintenance;";
            DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
            cmbMId.DataSource = dt;
            cmbMId.DisplayMember = "MId";
            cmbMId.ValueMember = "MId";
            cmbMId.SelectedIndex = -1;
        }

        private bool ValidateInput()
        {
            if (cmbMId.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a Maintenance ID.");
                cmbMId.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbExpCarReg.Text))
            {
                MessageBox.Show("Car registration number is missing.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbExpCarModel.Text))
            {
                MessageBox.Show("Car model is missing.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbExpMaintenanceType.Text))
            {
                MessageBox.Show("Please select maintenance type.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtExpCost.Text))
            {
                MessageBox.Show("Cost is required.");
                txtExpCost.Focus();
                return false;
            }

            try
            {
                Convert.ToDecimal(txtExpCost.Text);
            }
            catch
            {
                MessageBox.Show("Cost must be a valid number.");
                txtExpCost.Focus();
                return false;
            }


            return true;
        }

        private void btnAddExp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }

                string expId = txtExpId.Text;
                string mid = cmbMId.Text;
                string cost = txtExpCost.Text;

                this.Sql = @"insert into Expense values ('" + expId + "','" + mid + "','" + cost + "','" + this.accId + "');";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                {
                    MessageBox.Show("Expense added successfully");
                }
                else
                {
                    MessageBox.Show("Expense insertion failed");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding expense\n\n" + ex.Message);
            }
        }
        private void btnUpdateExp_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }
                string expId = txtExpId.Text;
                string mid = cmbMId.Text;
                string cost = txtExpCost.Text;

                this.Sql = @"update Expense 
                     set MId = '" + mid + @"', 
                         Cost = '" + cost + @"' 
                     where ExpId = '" + expId + "';";

                int count = this.Da.ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                {
                    MessageBox.Show("Expense updated successfully");
                }
                else
                {
                    MessageBox.Show("Expense update failed");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating expense\n\n" + ex.Message);
            }
        }

        private void btnDltExp_Click(object sender, EventArgs e)
        {
            try
            {
                string expId = this.dgvExp.CurrentRow.Cells["ExpId"].Value.ToString();
                this.Sql = @"delete from Expense where ExpId='" + expId + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                {
                    MessageBox.Show("Expense deleted successfully");
                }
                else
                {
                    MessageBox.Show("Expense deletion failed");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting expense\n\n" + ex.Message);
            }
        }
        private void ClearAll()
        {
            cmbMId.SelectedIndex = -1;
            cmbExpCarReg.SelectedIndex = -1;
            cmbExpCarModel.SelectedIndex = -1;
            cmbExpMaintenanceType.SelectedIndex = -1;
            dtpExpDate.Value = DateTime.Today;
            txtExpCost.Clear();
            txtExpSearch.Clear();

            if (userRole != "Admin")
            {
                GenerateExpenseId();
            }
            else
            {
                txtExpId.Clear();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void dgvExpense_DoubleClick(object sender, EventArgs e)
        {
            if (dgvExp.CurrentRow == null || dgvExp.CurrentRow.IsNewRow)
            {
                return;
            }

            try
            {
                txtExpId.Text = dgvExp.CurrentRow.Cells["ExpId"].Value?.ToString() ?? string.Empty;
                cmbMId.Text = dgvExp.CurrentRow.Cells["MId"].Value?.ToString() ?? string.Empty;
                cmbExpCarReg.Text = dgvExp.CurrentRow.Cells["RegNo"].Value?.ToString() ?? string.Empty;
                cmbExpCarModel.Text = dgvExp.CurrentRow.Cells["Model"].Value?.ToString() ?? string.Empty;
                cmbExpMaintenanceType.Text = dgvExp.CurrentRow.Cells["MType"].Value?.ToString() ?? string.Empty;

                dtpExpDate.Value = dgvExp.CurrentRow.Cells["Date"].Value != null && dgvExp.CurrentRow.Cells["Date"].Value != DBNull.Value
                                    ? Convert.ToDateTime(dgvExp.CurrentRow.Cells["Date"].Value): DateTime.Now;

                txtExpCost.Text = dgvExp.CurrentRow.Cells["Cost"].Value?.ToString() ?? "0.00";
                string recordEmpId = dgvExp.CurrentRow.Cells["EmpId"].Value?.ToString() ?? string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading expense record details\n\n" + ex.Message);
            }
        }

        private void cmbMId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMId.SelectedIndex >= 0)
            {
                DataRowView drv = (DataRowView)cmbMId.SelectedItem;

                string selectedMId = drv["MId"].ToString();
                this.Sql = @"select m.RegNo, mc.Model, m.MType
                           from Maintenance m join Manage_Car mc on m.RegNo = mc.RegNo
                           where m.MId='" + selectedMId + "';";
                DataTable dt = this.Da.ExecuteQueryTable(this.Sql);

                if (dt.Rows.Count > 0)
                {
                    cmbExpCarReg.Items.Clear();
                    cmbExpCarReg.Items.Add(dt.Rows[0]["RegNo"].ToString());
                    cmbExpCarReg.SelectedIndex = 0;

                    cmbExpCarModel.Items.Clear();
                    cmbExpCarModel.Items.Add(dt.Rows[0]["Model"].ToString());
                    cmbExpCarModel.SelectedIndex = 0;

                    cmbExpMaintenanceType.Items.Clear();
                    cmbExpMaintenanceType.Items.Add(dt.Rows[0]["MType"].ToString());
                    cmbExpMaintenanceType.SelectedIndex = 0;
                }
                else
                {
                    cmbExpCarReg.Items.Clear();
                    cmbExpCarReg.SelectedIndex = -1;

                    cmbExpCarModel.Items.Clear();
                    cmbExpCarModel.SelectedIndex = -1;

                    cmbExpMaintenanceType.Items.Clear();
                    cmbExpMaintenanceType.SelectedIndex = -1;
                }
            }
            else
            {
                cmbExpCarReg.Items.Clear();
                cmbExpCarReg.SelectedIndex = -1;

                cmbExpCarModel.Items.Clear();
                cmbExpCarModel.SelectedIndex = -1;

                cmbExpMaintenanceType.Items.Clear();
                cmbExpMaintenanceType.SelectedIndex = -1;
            }
        }

        private void txtExpSearch_TextChanged(object sender, EventArgs e)
        {
            string search = this.txtExpSearch.Text.Trim().ToUpper();
            this.Sql = @"select e.ExpId, e.MId, mc.RegNo, mc.Model, m.MType, m.Date, e.Cost, e.EmpId
                       from Expense e join Maintenance m on e.MId = m.MId
                       join Manage_Car mc on m.RegNo = mc.RegNo
                       where e.ExpId like '%" + search + @"%'
                       or e.MId like '%" + search + @"%'
                       or mc.RegNo like '%" + search + @"%'
                       or mc.Model like '%" + search + @"%'
                       or m.MType like '%" + search + @"%';";

            this.PopulateGridView(this.Sql);
        }


        private void btnExpBack_Click(object sender, EventArgs e)
        {
            if (userRole.ToLower() == "admin")
            {
                AdminDash admin = new AdminDash();
                this.Hide();
                admin.Show();
            }
            else
            {
                AccountantDash acc = new AccountantDash(accId);
                this.Hide();
                acc.Show();
            }
        }
    }
}
