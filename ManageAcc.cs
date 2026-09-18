using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem
{
    public partial class ManageAcc : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public ManageAcc()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();
            GenerateEmpId("Accountant");
        }
        private void PopulateGridView(string sql = "select * from Employee where Role = 'Accountant'")
        {
            try
            {
                this.Ds = this.Da.ExecuteQuery(sql);
                this.dgvAccountant.AutoGenerateColumns = false;
                this.dgvAccountant.DataSource = this.Ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading accountant data\n\n " + ex.Message);
            }
        }
        private void ClearAll()
        {
            this.txtId.Clear();
            this.txtId.ReadOnly = true;
            this.txtName.Clear();
            this.txtAddress.Clear();
            this.txtPhn.Clear();
            this.dtpHireDate.Value = DateTime.Now;
            this.txtSalary.Clear();
            this.txtSearch.Clear();
            GenerateEmpId("Accountant");
        }
        private void GenerateEmpId(string role)
        {
            string prefix = "A";
            
            this.Sql = "select * from Employee where Role='" + role + "' order by EmpId desc";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);

            if (Dt.Rows.Count > 0)
            {
                string id = Dt.Rows[0]["EmpId"].ToString();
                int n = Convert.ToInt32(id.Substring(1));
                this.txtId.Text = prefix + (n + 1).ToString("d4");
            }
            else
            {
                this.txtId.Text = prefix + "0001";
            }

            this.txtId.ReadOnly = true;
        }

        private void btnMAccBack_Click(object sender, EventArgs e)
        {
            AdminDash admin = new AdminDash();
            this.Hide();
            admin.Show();
        }

        private void btnClearAcc_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name cannot be empty");
                txtName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address cannot be empty");
                txtAddress.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhn.Text) || !txtPhn.Text.All(char.IsDigit) || txtPhn.Text.Length != 6)
            {
                MessageBox.Show("Phone number must contain exactly 6 digits");
                txtPhn.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                MessageBox.Show("Salary is required.");
                txtSalary.Focus();
                return false;
            }

            try
            {
                Convert.ToDecimal(txtSalary.Text);
            }
            catch
            {
                MessageBox.Show("Salary must be a valid number.");
                txtSalary.Focus();
                return false;
            }
            if (dtpHireDate.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Hire date cannot be in the future.");
                dtpHireDate.Focus();
                return false;
            }

            return true;
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }
                string hireDate = dtpHireDate.Value.ToString("yyyy-MM-dd");
                string role = "Accountant";

                this.Sql = @"insert into Employee
                           values ('" + this.txtId.Text + "', '" + this.txtName.Text + "', '" + this.txtAddress.Text + "', '" + this.txtPhn.Text + "','" + hireDate + "','" + txtSalary.Text + "','" + role + "')";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                {
                    MessageBox.Show("New accountant added successfully");
                    string insertLogin = @"insert into login (UserId, Password, UserRole, EmpId) 
                                   values ('tempUser', 'tempPass', '" + role + "', '" + this.txtId.Text + "')";
                    int loginCount = this.Da.ExecuteUpdateQuery(insertLogin);

                    if (loginCount != 1)
                    {
                        MessageBox.Show("Warning: Failed to auto-insert EmpId into Login table.");
                    }
                }
                else
                {
                    MessageBox.Show("Accountant insertion failed");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error while adding accountant\n\n" + exc.Message);
            }
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }
                dgvAccountant.EndEdit();
                string hireDate = dtpHireDate.Value.ToString("yyyy-MM-dd");
                string role = "Accountant";

                this.Sql = "select * from Employee where EmpId = '" + this.txtId.Text.Trim() + "';";
                this.Ds = this.Da.ExecuteQuery(this.Sql);
                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    this.Sql = @"update Employee
                    set EmpName = '" + this.txtName.Text + @"',
                    EmpAdd = '" + this.txtAddress.Text + @"',
                    EmpPhn = '" + this.txtPhn.Text + @"',
                    HireDate = '" + hireDate + @"',
                    Salary = '" + txtSalary.Text + @"',
                    Role = '" + role + @"'
                    where EmpId = '" + this.txtId.Text + "';";
                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show(this.txtId.Text + " has been updated properly");
                    }
                    else
                    {
                        MessageBox.Show("Accountant data updation failed");
                    }
                }
                else
                {
                    MessageBox.Show("Accountant not found!");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error while updating accountant\n\n" + exc.Message);
            }
        }

        private void btnDltAcc_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgvAccountant.CurrentRow.Cells["EmpId"].Value.ToString();
                string name = this.dgvAccountant.CurrentRow.Cells["EmpName"].Value.ToString();

                this.Sql = @"delete from Employee
                        where EmpId = '" + id + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(name + " has been deleted");
                }
                else
                {
                    MessageBox.Show("Accountant data deletion failed");
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
        }
        private void dgvAccountant_DoubleClick(object sender, EventArgs e)
        {
            if (dgvAccountant.CurrentRow == null || dgvAccountant.CurrentRow.IsNewRow)
            {
                return; 
            }

            try
            {
                if (dgvAccountant.CurrentRow.Cells["EmpId"].Value == null || dgvAccountant.CurrentRow.Cells["EmpId"].Value == DBNull.Value ||
                    string.IsNullOrWhiteSpace(dgvAccountant.CurrentRow.Cells["EmpId"].Value.ToString()))
                {
                    return; 
                }

                txtId.ReadOnly = true;
                txtId.Text = dgvAccountant.CurrentRow.Cells["EmpId"].Value?.ToString() ?? string.Empty;
                txtName.Text = dgvAccountant.CurrentRow.Cells["EmpName"].Value?.ToString() ?? string.Empty;
                txtAddress.Text = dgvAccountant.CurrentRow.Cells["EmpAdd"].Value?.ToString() ?? string.Empty;
                txtPhn.Text = dgvAccountant.CurrentRow.Cells["EmpPhn"].Value?.ToString() ?? string.Empty;

                dtpHireDate.Value = dgvAccountant.CurrentRow.Cells["HireDate"].Value != null && dgvAccountant.CurrentRow.Cells["HireDate"].Value != DBNull.Value
                    ? Convert.ToDateTime(dgvAccountant.CurrentRow.Cells["HireDate"].Value)
                    : DateTime.Now;

                txtSalary.Text = dgvAccountant.CurrentRow.Cells["Salary"].Value != null && dgvAccountant.CurrentRow.Cells["Salary"].Value != DBNull.Value
                    ? dgvAccountant.CurrentRow.Cells["Salary"].Value.ToString()
                    : string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading accountant details\n\n" + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            this.Sql = "select * from Employee where Role='Accountant' and (EmpId like '%" + search + "%' or EmpName like '%" + search + "%');";
            this.PopulateGridView(this.Sql);
        }
    }
}
