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
    public partial class StaffDash : Form
    {
        private string staffId;
        public StaffDash(string empId)
        {
            InitializeComponent();

            if (string.IsNullOrWhiteSpace(empId))
            {
                MessageBox.Show("Invalid Staff ID. Please log in again.");

                LOGIN logIn = new LOGIN();
                logIn.Show();
                this.Close();
                return;
            }


            this.staffId = empId; 
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers("Staff", staffId);
            this.Hide();
            customer.Show();
        }

        private void btnRentals_Click(object sender, EventArgs e)
        {
            Rentals rental = new Rentals("Staff", staffId);
            rental.Show();
            this.Hide();
        }
        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            Maintenance maintain = new Maintenance(staffId);
            this.Hide();
            maintain.Show();
        }

        private void btnStaffLogout_Click(object sender, EventArgs e)
        {
            LOGIN logIn = new LOGIN();
            this.Hide();
            logIn.Show();
        }

        private void btncrossStaff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
