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
    public partial class DashBoard : Form
    {
        private DataAccess Da { get; set; }
        private string Sql { get; set; }
        public DashBoard()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            LoadSummary();
        }
        private void LoadSummary()
        {
            try
            {
                this.Sql = "select count(*) as TotalCars from Manage_Car;";
                DataTable dtCars = this.Da.ExecuteQueryTable(this.Sql);
                lblTotalCars.Text = dtCars.Rows[0]["TotalCars"].ToString();

                this.Sql = "select count(*) as AvailableCars from Manage_Car where Available=1;";
                DataTable dtAvailable = this.Da.ExecuteQueryTable(this.Sql);
                lblAvailCars.Text = dtAvailable.Rows[0]["AvailableCars"].ToString();

                this.Sql = "select count(*) as TotalStaff from Employee where Role='Staff';";
                DataTable dtStaff = this.Da.ExecuteQueryTable(this.Sql);
                lblTotalStaff.Text = dtStaff.Rows[0]["TotalStaff"].ToString();

                this.Sql = "select count(*) as TotalAccountants from Employee where Role='Accountant';";
                DataTable dtAcc = this.Da.ExecuteQueryTable(this.Sql);
                lblTotalAccountants.Text = dtAcc.Rows[0]["TotalAccountants"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard summary: " + ex.Message);
            }
        }

        private void btncrossD_Click(object sender, EventArgs e)
        {
            AdminDash admin = new AdminDash();
            this.Hide();
            admin.Show();
        }
    }
}
