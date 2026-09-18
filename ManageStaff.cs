using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem
{
    public partial class ManageStaff : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public ManageStaff()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            PopulateGridView();
            GenerateEmpId("Staff");
        }
        private void PopulateGridView(string sql = "select * from Employee where Role = 'Staff'" )
        {
            try
            {
                this.Ds = this.Da.ExecuteQuery(sql);
                this.dgvStaff.AutoGenerateColumns = false;
                this.dgvStaff.DataSource = this.Ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff data\n\n " + ex.Message);
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
            GenerateEmpId("Staff");
        }
        private void GenerateEmpId(string role)
        {
            string prefix = "S";

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


        private void btnMStaffBack_Click(object sender, EventArgs e)
        {
            AdminDash admin = new AdminDash();
            this.Hide();
            admin.Show();
        }

        private void btnClearStaff_Click(object sender, EventArgs e)
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

            return true;
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }
                string hireDate = dtpHireDate.Value.ToString("yyyy-MM-dd");
                string role = "Staff";

                this.Sql = @"insert into Employee
                           values ('" + this.txtId.Text + "', '" + this.txtName.Text + "', '" + this.txtAddress.Text + "', '" + this.txtPhn.Text + "','" + hireDate + "','" + txtSalary.Text + "','" + role + "')";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                {
                    MessageBox.Show("New staff added successfully");
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
                    MessageBox.Show("Staff insertion failed");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error while adding staff\n\n" + exc.Message);
            }
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }
                dgvStaff.EndEdit();
                string hireDate = dtpHireDate.Value.ToString("yyyy-MM-dd");
                string role = "Staff";

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
                        MessageBox.Show("Staff data updation failed");
                    }
                }
                else
                {
                    MessageBox.Show("Staff not found!");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error while updating staff\n\n" + exc.Message);
            }
        }

        private void btnDltStaff_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgvStaff.CurrentRow.Cells["EmpId"].Value.ToString();
                string name = this.dgvStaff.CurrentRow.Cells["EmpName"].Value.ToString();

                this.Sql = @"delete from Employee
                        where EmpId = '" + id + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(name + " has been deleted");
                }
                else
                {
                    MessageBox.Show("Staff data deletion failed");
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
        }
        private void dgvStaff_DoubleClick(object sender, EventArgs e)
        {
            if (dgvStaff.CurrentRow == null || dgvStaff.CurrentRow.IsNewRow)
            {
                return; 
            }

            try
            {
                if (dgvStaff.CurrentRow.Cells["EmpId"].Value == null || dgvStaff.CurrentRow.Cells["EmpId"].Value == DBNull.Value ||
                    string.IsNullOrWhiteSpace(dgvStaff.CurrentRow.Cells["EmpId"].Value.ToString()))
                {
                    return; 
                }

                txtId.ReadOnly = true;
                txtId.Text = dgvStaff.CurrentRow.Cells["EmpId"].Value?.ToString() ?? string.Empty;
                txtName.Text = dgvStaff.CurrentRow.Cells["EmpName"].Value?.ToString() ?? string.Empty;
                txtAddress.Text = dgvStaff.CurrentRow.Cells["EmpAdd"].Value?.ToString() ?? string.Empty;
                txtPhn.Text = dgvStaff.CurrentRow.Cells["EmpPhn"].Value?.ToString() ?? string.Empty;

                dtpHireDate.Value = dgvStaff.CurrentRow.Cells["HireDate"].Value != null && dgvStaff.CurrentRow.Cells["HireDate"].Value != DBNull.Value
                    ? Convert.ToDateTime(dgvStaff.CurrentRow.Cells["HireDate"].Value)
                    : DateTime.Now;

                txtSalary.Text = dgvStaff.CurrentRow.Cells["Salary"].Value != null && dgvStaff.CurrentRow.Cells["Salary"].Value != DBNull.Value
                    ? dgvStaff.CurrentRow.Cells["Salary"].Value.ToString()
                    : string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff details\n\n" + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            this.Sql = "select * from Employee where Role='Staff' and (EmpId like '%" + search + "%' or EmpName like '%" + search + "%');";
            this.PopulateGridView(this.Sql);
        }
    }
}
