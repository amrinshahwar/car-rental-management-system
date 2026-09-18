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

namespace CarRentalManagementSystem
{
    public partial class Payments : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private string accId;

        public Payments(string empId)
        {
            InitializeComponent();

            this.Da = new DataAccess();
            this.accId = empId;

            this.PopulateGridView();
            GeneratePaymentId();
            LoadInvoiceComboBox();
        }
        private void PopulateGridView(string sql = "")
        {
            try
            {
                if (string.IsNullOrEmpty(sql))
                {
                    sql = @"select p.PayId, p.InvId, i.Amount, p.Method, p.PayDate, p.EmpId
                            from Payments p
                            join Invoices i on p.InvId = i.InvId;";
                }
                this.Ds = this.Da.ExecuteQuery(sql);
                this.dgvPayments.AutoGenerateColumns = false;
                this.dgvPayments.DataSource = this.Ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payment details\n\n " + ex.Message);
            }
        }
        private void GeneratePaymentId()
        {
            this.Sql = "select * from Payments order by PayId desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);
            if (Dt.Rows.Count > 0)
            {
                string id = Dt.Rows[0]["PayId"].ToString();
                string[] str = id.Split('P');
                int n = Convert.ToInt32(str[1]);
                string newID = "P" + (++n).ToString("d4");
                this.txtPId.Text = newID;
            }
            else
            {
                this.txtPId.Text = "P0001";
            }
            this.txtPId.ReadOnly = true;
        }
        private void LoadInvoiceComboBox()
        {
            this.Sql = "select InvId, Amount from Invoices where Status='Unpaid';";
            DataTable dtInvoice = this.Da.ExecuteQueryTable(this.Sql);
            cmbPInvId.DisplayMember = "InvId";
            cmbPInvId.ValueMember = "InvId";
            cmbPInvId.DataSource = dtInvoice;
            cmbPInvId.SelectedIndex = -1;

            txtPAmount.Clear();
        }
        private void cmbPInvId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPInvId.SelectedIndex >= 0)
            {
                DataRowView drv = (DataRowView)cmbPInvId.SelectedItem;
                txtPAmount.Text = drv["Amount"].ToString();
                dtpPayDate.Value = DateTime.Now;
            }
        }

        private void ClearAll()
        {
            this.cmbPInvId.SelectedIndex = -1;
            this.txtPAmount.Clear();
            this.cmbMethod.SelectedIndex = -1;
            this.txtSearchPay.Clear();
            this.dtpPayDate.Value = DateTime.Now;

            this.GeneratePaymentId();
        }
        private void btnPaymentsBack_Click(object sender, EventArgs e)
        {
            AccountantDash acc = new AccountantDash(accId);
            this.Hide();
            acc.Show();
        }

        private void btnClearPayments_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private bool ValidateInput()
        {
            if (cmbPInvId.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an invoice ID.");
                cmbPInvId.Focus();
                return false;
            }

            if (cmbMethod.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a payment method.");
                cmbMethod.Focus();
                return false;
            }
            
            return true;
        }

        private void btnAddPayments_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }

                string pId = txtPId.Text;
                string invoiceId = cmbPInvId.SelectedValue.ToString();
                string method = cmbMethod.Text;
                string date = dtpPayDate.Value.ToString("yyyy-MM-dd");

                this.Sql = @"insert into Payments values ('" + pId + "', '" + invoiceId + "', '" + method + "', '" + date + "', '" + this.accId + "');";

                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show("Payment recorded successfully");

                    string updateInvoice = "update Invoices set Status='PAID' where InvId='" + invoiceId + "';";
                    this.Da.ExecuteUpdateQuery(updateInvoice);

                    this.PopulateGridView();
                    this.ClearAll();
                    this.LoadInvoiceComboBox(); 
                }
                else
                {
                    MessageBox.Show("Payment insertion failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding payment\n\n" + ex.Message);
            }
        }

        private void btnDltPayments_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgvPayments.CurrentRow.Cells["PayId"].Value.ToString();
                this.Sql = @"delete from Payments
                        where PayId = '" + id + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);
                if (count == 1)
                {
                    MessageBox.Show(id + " has been deleted");
                }
                else
                {
                    MessageBox.Show("Payment data deletion failed");
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured during deletion\n" + ex.Message);
            }
        }

        private void dgvPayments_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPayments.CurrentRow == null || dgvPayments.CurrentRow.IsNewRow)
            {
                return; 
            }

            try
            {
                txtPId.ReadOnly = true;
                txtPId.Text = dgvPayments.CurrentRow.Cells["PayId"].Value?.ToString() ?? string.Empty;

                string invId = dgvPayments.CurrentRow.Cells["InvId"].Value?.ToString() ?? string.Empty;
                string amount = dgvPayments.CurrentRow.Cells["Amount"].Value?.ToString() ?? "0.00";

                DataTable dt = (DataTable)cmbPInvId.DataSource;

                bool found = false;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["InvId"].ToString() == invId)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found && !string.IsNullOrEmpty(invId))
                {
                    DataRow newRow = dt.NewRow();
                    newRow["InvId"] = invId;
                    newRow["Amount"] = amount;
                    dt.Rows.Add(newRow);
                }

                cmbPInvId.SelectedValue = invId;
                txtPAmount.Text = amount;
                cmbMethod.Text = dgvPayments.CurrentRow.Cells["Method"].Value?.ToString() ?? string.Empty;

                dtpPayDate.Value = dgvPayments.CurrentRow.Cells["PayDate"].Value != null && dgvPayments.CurrentRow.Cells["PayDate"].Value != DBNull.Value
                                   ? Convert.ToDateTime(dgvPayments.CurrentRow.Cells["PayDate"].Value): DateTime.Now;

                string recordEmpId = dgvPayments.CurrentRow.Cells["EmpId"].Value?.ToString() ?? string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payment details\n\n" + ex.Message);
            }
        }

        private void txtSearchPay_TextChanged(object sender, EventArgs e)
        {
            string search = this.txtSearchPay.Text.Trim();
            this.Sql = @"select p.PayId, p.InvId, i.Amount, p.Method, p.PayDate, p.EmpId
                         from Payments p join Invoices i on p.InvId = i.InvId
                         where p.PayId like '%" + search + "%' or p.InvId like '%" + search + "%';";

            this.PopulateGridView(this.Sql);
        }
    }
}
