using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CarRentalManagementSystem
{
    public partial class Customers : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private string userRole;
        private string staffId;
        public Customers(string role, string empId)
        {
            InitializeComponent();


            if (role != "Admin" && string.IsNullOrWhiteSpace(empId))
            {
                MessageBox.Show("Invalid staff ID. Please log in again.");
                LOGIN logIn = new LOGIN();
                logIn.Show();
                this.Close();
                return;
            }

            this.Da = new DataAccess();
            this.userRole = role;

            if (userRole != "Admin")
            {
                GenerateCustId(); 
            }
            else
            {
                txtCustId.Clear(); 
            }

            this.staffId = empId;
            this.PopulateGridView();
            ConfigureRole();
        }
        private void ConfigureRole()
        {
            if (userRole == "Admin")
            {
                btnAddCust.Visible = false;
                btnUpdateCust.Visible = false;
                btnDltCust.Visible = false;
                btnClearCust.Visible = false;

                txtCustName.ReadOnly = true;
                txtCustAddress.ReadOnly = true;
                txtCustPhn.ReadOnly = true;
                txtCustId.ReadOnly = true;
            }
            else
            {
                btnAddCust.Visible = true;
                btnUpdateCust.Visible = true;
                btnDltCust.Visible = true;
                btnClearCust.Visible = true;

                txtCustName.ReadOnly = false;
                txtCustAddress.ReadOnly = false;
                txtCustPhn.ReadOnly = false;
                txtCustId.ReadOnly = true;
            }
        }

        private void PopulateGridView(string sql = "select * from Customers;")
        {
            try
            {
                this.Ds = this.Da.ExecuteQuery(sql);
                this.dgvCustomer.AutoGenerateColumns = false;
                this.dgvCustomer.DataSource = this.Ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data\n\n " + ex.Message);
            }
        }
        private void GenerateCustId()
        {
            this.Sql = "select * from Customers order by CustId desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);
            if (Dt.Rows.Count > 0)
            {
                string id = Dt.Rows[0]["CustId"].ToString();
                string[] str = id.Split('C');
                int n = Convert.ToInt32(str[1]);
                string newID = "C" + (++n).ToString("d4");
                this.txtCustId.Text = newID;
            }
            else
            {
                this.txtCustId.Text = "C0001";
            }
            this.txtCustId.ReadOnly = true;
        }

        private void btnCustBack_Click(object sender, EventArgs e)
        {
            if(userRole == "Admin")
            {
                AdminDash admin = new AdminDash();
                this.Hide();
                admin.Show();
            }
            else
            {
                StaffDash staff = new StaffDash(this.staffId);
                this.Hide();
                staff.Show();
            }
            
        }
        private void ClearAll()
        {
            this.txtCustId.Clear();
            this.txtCustId.ReadOnly = true;
            this.txtCustName.Clear();
            this.txtCustAddress.Clear();
            this.txtCustPhn.Clear();
            this.txtCustSearch.Clear();

            if (userRole != "Admin")
            {
                GenerateCustId(); 
            }
            else
            {
                txtCustId.Clear(); 
            }
        }

        private void btnClearCust_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtCustName.Text))
            {
                MessageBox.Show("Name cannot be empty");
                txtCustName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCustAddress.Text))
            {
                MessageBox.Show("Address cannot be empty");
                txtCustAddress.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCustPhn.Text) || !txtCustPhn.Text.All(char.IsDigit) || txtCustPhn.Text.Length != 6)
            {
                MessageBox.Show("Phone number must contain exactly 6 digits");
                txtCustPhn.Focus();
                return false;
            }

            return true;
        }
        private void btnAddCust_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }

                string empIdValue = "'" + this.staffId + "'";

                this.Sql = @"insert into Customers
                           values ('" + this.txtCustId.Text + "', '" + this.txtCustName.Text + "', '" + this.txtCustAddress.Text + "', '" + this.txtCustPhn.Text + "', " + empIdValue + ");";
                
                int count = this.Da.ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                {
                    MessageBox.Show("New customer added successfully");
                }
                else
                {
                    MessageBox.Show("Customer insertion failed");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error while adding customer\n\n" + exc.Message);
            }
        }

        private void btnUpdateCust_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }
                dgvCustomer.EndEdit();
                this.Sql = "select * from Customers where CustId = '" + this.txtCustId.Text.Trim() + "';";
                this.Ds = this.Da.ExecuteQuery(this.Sql);
                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    this.Sql = @"update Customers
                    set CustName = '" + this.txtCustName.Text + @"',
                    CustAdd = '" + this.txtCustAddress.Text + @"',
                    CustPhn = '" + this.txtCustPhn.Text + @"'
                    where CustId = '" + this.txtCustId.Text + "';";
                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show(this.txtCustId.Text + " has been updated properly");
                    }
                    else
                    {
                        MessageBox.Show("Customer data updation failed");
                    }
                }
                else
                {
                    MessageBox.Show("Customer not found!");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error while updating customer\n\n" + exc.Message);
            }
        }

        private void btnDltCust_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvCustomer.CurrentRow == null)
                {
                    MessageBox.Show("Please select a customer to delete.");
                    return;
                }

                string id = this.dgvCustomer.CurrentRow.Cells["CustId"].Value?.ToString();
                string name = this.dgvCustomer.CurrentRow.Cells["CustName"].Value?.ToString();

                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Customer ID is missing. Cannot delete.");
                    return;
                }
                string checkSql = "select count(*) from Rentals where CustId = '" + id + "'";
                DataTable dt = this.Da.ExecuteQueryTable(checkSql);
                int relatedRentals = 0;
                if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
                {
                    relatedRentals = Convert.ToInt32(dt.Rows[0][0]);
                }
                if (relatedRentals > 0)
                {
                    MessageBox.Show("Cannot delete customer. There are rental records associated with this customer.");
                    return;
                }

                this.Sql = @"delete from Customers
                        where CustId = '" + id + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(name + " has been deleted");
                }
                else
                {
                    MessageBox.Show("Customer data deletion failed");
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
        }

        private void txtCustSearch_TextChanged(object sender, EventArgs e)
        {
            string search = this.txtCustSearch.Text.Trim();
            this.Sql = "select * from Customers where CustId like '%" + search + "%' or CustName like '%" + search + "%';"; 
            this.PopulateGridView(this.Sql);
        }
        private void dgvCustomer_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow == null || dgvCustomer.CurrentRow.IsNewRow)
            {
                return;
            }

            try
            {
                if (dgvCustomer.CurrentRow.Cells["CustId"].Value == null || dgvCustomer.CurrentRow.Cells["CustId"].Value == DBNull.Value ||
                    string.IsNullOrWhiteSpace(dgvCustomer.CurrentRow.Cells["CustId"].Value.ToString()))
                {
                    return; 
                }

                txtCustId.ReadOnly = true;
                txtCustId.Text = dgvCustomer.CurrentRow.Cells["CustId"].Value?.ToString() ?? string.Empty;
                txtCustName.Text = dgvCustomer.CurrentRow.Cells["CustName"].Value?.ToString() ?? string.Empty;
                txtCustAddress.Text = dgvCustomer.CurrentRow.Cells["CustAdd"].Value?.ToString() ?? string.Empty;
                txtCustPhn.Text = dgvCustomer.CurrentRow.Cells["CustPhn"].Value?.ToString() ?? string.Empty;

                string recordStaffId = dgvCustomer.CurrentRow.Cells["EmpId"].Value != null && dgvCustomer.CurrentRow.Cells["EmpId"].Value != DBNull.Value
                    ? dgvCustomer.CurrentRow.Cells["EmpId"].Value.ToString()
                    : string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer details\n\n" + ex.Message);
            }
        }
        
    }
}
