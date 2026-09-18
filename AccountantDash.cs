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
    public partial class AccountantDash : Form
    {
        private string accId;
        public AccountantDash(string empId)
        {
            InitializeComponent();
            if (string.IsNullOrWhiteSpace(empId))
            {
                MessageBox.Show("Invalid Accountant ID. Please log in again.");

                LOGIN logIn = new LOGIN();
                logIn.Show();
                this.Close();
                return;
            }

            this.accId = empId;
        }
        private void btnInvoices_Click(object sender, EventArgs e)
        {
            Invoices invoice = new Invoices(accId);
            this.Hide();
            invoice.Show();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            Payments payment = new Payments(accId);
            this.Hide();
            payment.Show();
        }
        private void btnExpenses_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense("Accountant" , accId);
            this.Hide();
            expense.Show();
        }

        private void btncrossAcc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccLogout_Click(object sender, EventArgs e)
        {
            LOGIN logIn = new LOGIN();
            this.Hide();
            logIn.Show();
        }
    }
}
