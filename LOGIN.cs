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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }
        private void ClearFields()
        {
            this.txtUserID.Clear();
            this.txtPassword.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btncross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(this.txtUserID.Text) || string.IsNullOrWhiteSpace(this.txtPassword.Text))
                {
                    MessageBox.Show("User ID and Password cannot be empty!");
                    return;
                }

                string userId = this.txtUserID.Text.Trim();
                string password = this.txtPassword.Text.Trim();

                if (userId == "admin" && password == "2114")
                {
                    AdminDash admin = new AdminDash();
                    this.Hide();
                    admin.Show();
                    return;
                }

                string sql = @"select * from dbo.login where UserID = '" + userId + "' and Password = '" + password + "';";

                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    string role = ds.Tables[0].Rows[0]["UserRole"].ToString().Trim();
                    string empId = ds.Tables[0].Rows[0]["EmpId"].ToString().Trim();

                    if (role == "Staff")
                    {
                        StaffDash staff = new StaffDash(empId);
                        this.Hide();
                        staff.Show();
                    }
                    else if (role == "Accountant")
                    {
                        AccountantDash accountant = new AccountantDash(empId);
                        this.Hide();
                        accountant.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Login Invalid!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while logging in\n\n " + ex.Message);
            }
        }

    } 
}


