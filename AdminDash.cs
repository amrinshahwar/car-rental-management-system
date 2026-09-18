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
    public partial class AdminDash : Form
    {
        public AdminDash()
        {
            InitializeComponent();
        }

        private void btnManageCar_Click(object sender, EventArgs e)
        {
            ManageCar manageCar = new ManageCar();
            this.Hide();
            manageCar.Show();
        }
        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            ManageStaff manageStaff = new ManageStaff();
            this.Hide();
            manageStaff.Show();
        }
        private void btnManageAccountant_Click(object sender, EventArgs e)
        {
            ManageAcc manageAcc = new ManageAcc();
            this.Hide();
            manageAcc.Show();
        }


        private void btnAdLogout_Click(object sender, EventArgs e)
        {
            LOGIN logIn = new LOGIN();
            this.Hide();
            logIn.Show();
        }

        private void btncross2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdDash_Click(object sender, EventArgs e)
        {
            DashBoard dash = new DashBoard();
            this.Hide();
            dash.Show();
        }

        private void btnViewCust_Click(object sender, EventArgs e)
        {
            Customers cust = new Customers("Admin", null);
            cust.ShowDialog();
        }

        private void btnViewRental_Click(object sender, EventArgs e)
        {
            Rentals rent = new Rentals("Admin", null);
            rent.ShowDialog();
        }

        private void btnViewExp_Click(object sender, EventArgs e)
        {
            Expense exp = new Expense("Admin", null);
            exp.ShowDialog();
        }
    }
}
