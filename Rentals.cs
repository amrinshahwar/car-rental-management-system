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
    public partial class Rentals : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private string userRole;
        private string staffId;

        public Rentals(string role, string empId)
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
                GenerateRentId(); 
            }
            else
            {
                txtRentId.Clear(); 
            }

            this.staffId = empId;
            this.PopulateGridView();
            LoadCustomerAndCarComboBox();
            ConfigureRole();
        }
        private void ConfigureRole()
        {
            if (userRole.ToLower() == "admin")
            {
                btnAddRent.Visible = false;
                btnUpdateRent.Visible = false;
                btnDltRent.Visible = false;
                btnClearRent.Visible = false;

                cmbRentCustId.Enabled = false;
                cmbRentCarReg.Enabled = false;
                txtBaseFee.ReadOnly = true;
                txtLateFee.ReadOnly = true;
                cmbRentStatus.Enabled = false;
                dtpRentDate.Enabled = false;
                dtpDueDate.Enabled = false;
                dtpReturnDate.Enabled = false;
            }
            else
            {
                btnAddRent.Visible = true;
                btnUpdateRent.Visible = true;
                btnDltRent.Visible = true;
                btnClearRent.Visible = true;

                cmbRentCustId.Enabled = true;
                cmbRentCarReg.Enabled = true;
                txtBaseFee.ReadOnly = false;
                txtLateFee.ReadOnly = true; 
                cmbRentStatus.Enabled = true;
                dtpRentDate.Enabled = true;
                dtpDueDate.Enabled = true;
                dtpReturnDate.Enabled = true;
            }
        }
        private void PopulateGridView(string sql = "select * from Rentals;")
        {
            try
            {
                this.Ds = this.Da.ExecuteQuery(sql);
                this.dgvRentals.AutoGenerateColumns = false;
                this.dgvRentals.DataSource = this.Ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rental data\n\n " + ex.Message);
            }
        }
        private void GenerateRentId()
        {
            this.Sql = "select * from Rentals order by RentId desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);

            if (Dt.Rows.Count > 0)
            {
                string id = Dt.Rows[0]["RentId"].ToString();
                string[] str = id.Split('R');
                int n = Convert.ToInt32(str[1]);
                string newID = "R" + (++n).ToString("d4");
                this.txtRentId.Text = newID;
            }
            else
            {
                this.txtRentId.Text = "R0001";
            }
            this.txtRentId.ReadOnly = true;
        }
        private void LoadCustomerAndCarComboBox()
        {
            this.Sql = "select CustId, CustName from Customers;";
            DataTable dtCust = this.Da.ExecuteQueryTable(this.Sql);
            cmbRentCustId.DisplayMember = "CustId";
            cmbRentCustId.ValueMember = "CustId";
            cmbRentCustId.DataSource = dtCust;
            cmbRentCustId.SelectedIndex = -1;

            this.Sql = "select RegNo, Price, Available from Manage_Car;";
            DataTable dtCar = this.Da.ExecuteQueryTable(this.Sql);
            cmbRentCarReg.DisplayMember = "RegNo";
            cmbRentCarReg.ValueMember = "RegNo";
            cmbRentCarReg.DataSource = dtCar;
            cmbRentCarReg.SelectedIndex = -1;
        }
        private void ClearAll()
        {
            cmbRentCustId.SelectedIndex = -1;
            cmbRentCarReg.SelectedIndex = -1;
            dtpRentDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now.AddDays(1);
            dtpReturnDate.Value = DateTime.Now;
            txtBaseFee.Clear();
            txtLateFee.Text = "0";
            txtLateFee.ReadOnly = true;
            cmbRentStatus.SelectedIndex = -1;
            txtRentSearch.Clear();

            if (userRole != "Admin")
            {
                GenerateRentId();
            }
            else
            {
                txtRentId.Clear();
            }
        }
        private bool ValidateInput()
        {
            if (cmbRentCustId.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a customer.");
                cmbRentCustId.Focus();
                return false;
            }

            if (cmbRentCarReg.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a car.");
                cmbRentCarReg.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBaseFee.Text))
            {
                MessageBox.Show("Base Fee is required.");
                txtBaseFee.Focus();
                return false;
            }

            try
            {
                Convert.ToDecimal(txtBaseFee.Text);
            }
            catch
            {
                MessageBox.Show("Base Fee must be a valid number.");
                txtBaseFee.Focus();
                return false;
            }

            try
            {
                Convert.ToDecimal(txtLateFee.Text);
            }
            catch
            {
                MessageBox.Show("Late Fee must be a valid number.");
                txtLateFee.Focus();
                return false;
            }

            if (cmbRentStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a status.");
                cmbRentStatus.Focus();
                return false;
            }

            if (dtpRentDate.Value.Date > dtpDueDate.Value.Date)
            {
                MessageBox.Show("Due Date cannot be earlier than Rent Date.");
                dtpRentDate.Focus();
                return false;
            }

            if (dtpReturnDate.Value.Date < dtpRentDate.Value.Date)
            {
                MessageBox.Show("Return Date cannot be earlier than Rent Date.");
                dtpReturnDate.Focus();
                return false;
            }

            return true;
        }
        private bool IsCarAvailable(string carRegNo, DateTime rentDate, DateTime dueDate, string currentRentId = "")
        {
            this.Sql = @"select count(*) from Rentals 
                 where RegNo = '" + carRegNo + @"'
                 and RentId <> '" + currentRentId + @"'
                 and ((RentDate <= '" + dueDate.ToString("yyyy-MM-dd") + @"' 
                       and DueDate >= '" + rentDate.ToString("yyyy-MM-dd") + @"')
                 or (ReturnDate IS NULL))";

            DataTable dt = this.Da.ExecuteQueryTable(this.Sql);

            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
            {
                int count = Convert.ToInt32(dt.Rows[0][0]);
                if (count > 0)
                {
                    MessageBox.Show("This car is already booked during the selected dates.");
                    return false;
                }
            }
            return true;
        }

        private void btnAddRent_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }

                string customerId = cmbRentCustId.SelectedValue.ToString();
                string carRegNo = cmbRentCarReg.SelectedValue.ToString();
                decimal baseFee = Convert.ToDecimal(txtBaseFee.Text);
                decimal lateFee = Convert.ToDecimal(txtLateFee.Text);

                if (!IsCarAvailable(carRegNo, dtpRentDate.Value, dtpDueDate.Value))
                {
                    return;
                }

                this.Sql = @"insert into Rentals
                values ('" + this.txtRentId.Text + "', '" + customerId + "', '" + carRegNo + "', '" +
                this.dtpRentDate.Value.ToString("yyyy-MM-dd") + "', '" + this.dtpDueDate.Value.ToString("yyyy-MM-dd") + "', '" +
                this.dtpReturnDate.Value.ToString("yyyy-MM-dd") + "', " + baseFee + ", " + lateFee + ", '" + this.cmbRentStatus.Text + "', '" + this.staffId + "');";

                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show("Rental added successfully");
                }
                else
                {
                    MessageBox.Show("Rental insertion failed");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding rental information\n\n" + ex.Message);
            }
        }
        private void btnUpdateRent_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                    return;
                dgvRentals.EndEdit();
                string customerId = cmbRentCustId.SelectedValue.ToString();
                string carRegNo = cmbRentCarReg.SelectedValue.ToString();
                decimal baseFee = Convert.ToDecimal(txtBaseFee.Text);
                decimal lateFee = Convert.ToDecimal(txtLateFee.Text);

                if (!IsCarAvailable(carRegNo, dtpRentDate.Value, dtpDueDate.Value, txtRentId.Text))
                {
                    return;
                }

                dgvRentals.EndEdit();

                this.Sql = "select * from Rentals where RentId = '" + this.txtRentId.Text.Trim() + "';";
                this.Ds = this.Da.ExecuteQuery(this.Sql);
                if (this.Ds.Tables[0].Rows.Count == 1)
                { 
                    this.Sql = @"update Rentals
                    set CustId='" + customerId + @"',
                    RegNo='" + carRegNo + @"',
                    RentDate='" + this.dtpRentDate.Value.ToString("yyyy-MM-dd") + @"',
                    DueDate='" + this.dtpDueDate.Value.ToString("yyyy-MM-dd") + @"',
                    ReturnDate='" + this.dtpReturnDate.Value.ToString("yyyy-MM-dd") + @"',
                    BaseFee=" + baseFee + @",
                    LateFee=" + lateFee + @",
                    RentStatus='" + cmbRentStatus.Text + @"'
                    where RentId='" + this.txtRentId.Text + "';";

                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show(this.txtRentId.Text + " has been updated properly");
                    }
                    else
                    {
                        MessageBox.Show("Rental data updation failed");
                    }
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error while updating rental information\n\n" + exc.Message);
            }
        }
        private void btnClearRent_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void btnDltRent_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgvRentals.CurrentRow.Cells["RentId"].Value.ToString();
                this.Sql = @"delete from Rentals
                        where RentId = '" + id + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(id + " has been deleted");
                }
                else
                {
                    MessageBox.Show("Rental data deletion failed");
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured during deletion\n" + exc.Message);
            }
        }
        private void cmbRentCarReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRentCarReg.SelectedIndex >= 0)
            {
                DataRowView drv = (DataRowView)cmbRentCarReg.SelectedItem;
                txtBaseFee.Text = drv["Price"].ToString();
                if (drv.Row.Table.Columns.Contains("Available")) 
                {
                    int available = Convert.ToInt32(drv["Available"]);
                    if (available == 0)
                    {
                        MessageBox.Show("This car is not available for rent.");
                        cmbRentCarReg.SelectedIndex = -1;  
                        txtBaseFee.Clear();
                    }
                }
            }
            else
            {
                txtBaseFee.Clear();
            }
        }
        private void dtpRentDate_ValueChanged(object sender, EventArgs e)
        {
            txtLateFee.Text = "0";
            txtLateFee.ReadOnly = true;
        }
        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpReturnDate.Value > dtpDueDate.Value)
            {
                txtLateFee.ReadOnly = false;
            }
            else
            {
                txtLateFee.Text = "0";
                txtLateFee.ReadOnly = true;
            }
        }
        private void txtRentSearch_TextChanged(object sender, EventArgs e)
        {
            string search = this.txtRentSearch.Text.Trim();
            this.Sql = "select * from Rentals where CustId like '%" + search + "%' or RentId like '%" + search + "%';";

            this.PopulateGridView(this.Sql);
        }
        private void dgvRentals_DoubleClick(object sender, EventArgs e)
        {
            if (dgvRentals.CurrentRow == null || dgvRentals.CurrentRow.IsNewRow)
            {
                return;
            }

            try
            {
                txtRentId.ReadOnly = true;
                txtRentId.Text = dgvRentals.CurrentRow.Cells["RentId"].Value?.ToString() ?? string.Empty;

                cmbRentCustId.SelectedValue = dgvRentals.CurrentRow.Cells["CustId"].Value?.ToString();
                cmbRentCarReg.SelectedValue = dgvRentals.CurrentRow.Cells["RegNo"].Value?.ToString();

                dtpRentDate.Value = dgvRentals.CurrentRow.Cells["RentDate"].Value != null && dgvRentals.CurrentRow.Cells["RentDate"].Value != DBNull.Value
                    ? Convert.ToDateTime(dgvRentals.CurrentRow.Cells["RentDate"].Value)
                    : DateTime.Now;

                dtpDueDate.Value = dgvRentals.CurrentRow.Cells["DueDate"].Value != null && dgvRentals.CurrentRow.Cells["DueDate"].Value != DBNull.Value
                    ? Convert.ToDateTime(dgvRentals.CurrentRow.Cells["DueDate"].Value)
                    : DateTime.Now;

                dtpReturnDate.Value = dgvRentals.CurrentRow.Cells["ReturnDate"].Value != null && dgvRentals.CurrentRow.Cells["ReturnDate"].Value != DBNull.Value
                    ? Convert.ToDateTime(dgvRentals.CurrentRow.Cells["ReturnDate"].Value)
                    : DateTime.Now;

                txtBaseFee.Text = dgvRentals.CurrentRow.Cells["BaseFee"].Value?.ToString() ?? string.Empty;
                txtLateFee.Text = dgvRentals.CurrentRow.Cells["LateFee"].Value?.ToString() ?? "0";

                cmbRentStatus.Text = dgvRentals.CurrentRow.Cells["RentStatus"].Value?.ToString().Trim() ?? string.Empty;

                string recordStaffId = dgvRentals.CurrentRow.Cells["EmpId"].Value?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rental details\n\n" + ex.Message);
            }
        }

        private void btnRentBack_Click(object sender, EventArgs e)
        {

            if (userRole == "Admin")
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

        
    }

}
