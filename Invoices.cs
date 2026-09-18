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
    public partial class Invoices : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private string accId;

        public Invoices(string empId)
        {
            InitializeComponent();

            this.Da = new DataAccess();
            this.accId = empId;

            this.PopulateGridView();
            GenerateInvoiceId();
            LoadRentalComboBox();
        }
        private void PopulateGridView(string sql = "select * from Invoices;")
        {
            try
            {
                this.Ds = this.Da.ExecuteQuery(sql);
                this.dgvInvoices.AutoGenerateColumns = false;
                this.dgvInvoices.DataSource = this.Ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading invoice data\n\n" + ex.Message);
            }
        }
        private void GenerateInvoiceId()
        {
            this.Sql = "select * from Invoices order by InvId desc;";
            DataTable dt = this.Da.ExecuteQueryTable(this.Sql);

            if (dt.Rows.Count > 0)
            {
                string id = dt.Rows[0]["InvId"].ToString();
                string[] str = id.Split('I');
                int n = Convert.ToInt32(str[1]);
                string newID = "I" + (++n).ToString("d4");
                this.txtInvId.Text = newID;
            }
            else
            {
                this.txtInvId.Text = "I0001";
            }
            this.txtInvId.ReadOnly = true;
        }
        private void LoadRentalComboBox()
        {
            this.Sql = "select RentId, CustId, RentDate, DueDate, ReturnDate, BaseFee, LateFee from Rentals;";
            DataTable dtRent = this.Da.ExecuteQueryTable(this.Sql);
            cmbInvRentId.DisplayMember = "RentId";
            cmbInvRentId.ValueMember = "RentId";
            cmbInvRentId.DataSource = dtRent;
            cmbInvRentId.SelectedIndex = -1;
        }
        private void ClearAll()
        {
            cmbInvRentId.SelectedIndex = -1;
            txtInvAmount.Clear();
            dtpInvDate.Value = DateTime.Now;
            cmbInvStatus.SelectedIndex = -1;
            txtSearchInv.Clear();

            GenerateInvoiceId();
        }
        private void CalculateTotal(object sender, EventArgs e)
        {
            if (cmbInvRentId.SelectedIndex >= 0)
            {
                DataRowView drv = (DataRowView)cmbInvRentId.SelectedItem;

                decimal baseFee = 0;
                decimal lateFee = 0;
                DateTime rentDate = DateTime.Now;
                DateTime returnDate = DateTime.Now;

                if (!string.IsNullOrWhiteSpace(drv["BaseFee"].ToString()))
                {
                    baseFee = Convert.ToDecimal(drv["BaseFee"]);
                }
                if (!string.IsNullOrWhiteSpace(drv["LateFee"].ToString()))
                {
                    lateFee = Convert.ToDecimal(drv["LateFee"]);
                }
                if (!string.IsNullOrWhiteSpace(drv["RentDate"].ToString()))
                {
                    rentDate = Convert.ToDateTime(drv["RentDate"]);
                }
                if (!string.IsNullOrWhiteSpace(drv["ReturnDate"].ToString()))
                {
                    returnDate = Convert.ToDateTime(drv["ReturnDate"]);
                }

                txtInvAmount.Text = (baseFee + lateFee).ToString("0.00");
                dtpInvDate.Value = DateTime.Now;
            }
            else
            {
                txtInvAmount.Text = "0.00";
            }
        }

        private bool ValidateInput()
        {
            if (cmbInvRentId.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a rental.");
                cmbInvRentId.Focus();
                return false;
            }

            if (cmbInvStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a status.");
                cmbInvStatus.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtInvAmount.Text))
            {
                MessageBox.Show("Amount is required.");
                txtInvAmount.Focus();
                return false;
            }

            try
            {
                Convert.ToDecimal(txtInvAmount.Text);
            }
            catch
            {
                MessageBox.Show("Amount must be a valid number.");
                txtInvAmount.Focus();
                return false;
            }

            return true;
        }

        private void btnAddInv_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }

                string invId = txtInvId.Text;
                string rentalId = cmbInvRentId.SelectedValue.ToString();
                decimal amount = Convert.ToDecimal(txtInvAmount.Text);
                string date = this.dtpInvDate.Value.ToString("yyyy-MM-dd");
                string invStat = cmbInvStatus.Text;

                this.Sql = @"insert into Invoices values ('" + invId + "', '" + rentalId + "', " + amount + ", '" +
                date + "', '" + invStat + "', '" + this.accId + "');";

                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show("Invoice data added successfully");
                }
                else
                {
                    MessageBox.Show("Invoice data insertion failed");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding invoice\n\n" + ex.Message);
            }
        }

        private void btnUpdateInv_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }

                dgvInvoices.EndEdit();

                string rentalId = cmbInvRentId.SelectedValue.ToString();
                decimal amount = Convert.ToDecimal(txtInvAmount.Text);

                this.Sql = @"update Invoices
                set RentId='" + rentalId + @"',
                Amount=" + amount + @",
                InvDate='" + dtpInvDate.Value.ToString("yyyy-MM-dd") + @"',
                Status='" + cmbInvStatus.Text + @"'
                where InvId='" + txtInvId.Text + "';";

                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                    MessageBox.Show(txtInvId.Text + " has been updated properly");
                else
                    MessageBox.Show("Invoice data updation failed");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating invoice\n\n" + ex.Message);
            }
        }

        private void btnDltInv_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgvInvoices.CurrentRow.Cells["InvId"].Value.ToString();
                this.Sql = @"delete from Invoices where InvId = '" + id + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(id + " has been deleted");
                }
                else
                {
                    MessageBox.Show("Invoice data deletion failed");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting invoice\n\n" + ex.Message);
            }
        }

        private void btnClearInv_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void txtSearchInv_TextChanged(object sender, EventArgs e)
        {
            string search = this.txtSearchInv.Text.Trim();
            this.Sql = "select * from Invoices where InvId like '%" + search + "%' or RentId like '%" + search + "%';";

            this.PopulateGridView(this.Sql);
        }

        private void dgvInvoices_DoubleClick(object sender, EventArgs e)
        {
            if (dgvInvoices.CurrentRow == null || dgvInvoices.CurrentRow.IsNewRow)
            {
                return; 
            }

            try
            {
                txtInvId.ReadOnly = true;
                txtInvId.Text = dgvInvoices.CurrentRow.Cells["InvId"].Value?.ToString() ?? string.Empty;
                cmbInvRentId.SelectedValue = dgvInvoices.CurrentRow.Cells["RentId"].Value?.ToString();
                txtInvAmount.Text = dgvInvoices.CurrentRow.Cells["Amount"].Value?.ToString() ?? "0.00";
                dtpInvDate.Value = dgvInvoices.CurrentRow.Cells["InvDate"].Value != null && dgvInvoices.CurrentRow.Cells["InvDate"].Value != DBNull.Value
                    ? Convert.ToDateTime(dgvInvoices.CurrentRow.Cells["InvDate"].Value)
                    : DateTime.Now;
                cmbInvStatus.Text = dgvInvoices.CurrentRow.Cells["Status"].Value?.ToString().Trim() ?? string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading invoice details\n\n" + ex.Message);
            }
        }

        private void btnInvoicesBack_Click(object sender, EventArgs e)
        {
            AccountantDash acc = new AccountantDash(accId);
            this.Hide();
            acc.Show();
        }

        
    }
}
