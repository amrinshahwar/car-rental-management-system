using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CarRentalManagementSystem
{
    public partial class ManageCar : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        public ManageCar()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.dgvCar.CellFormatting += dgvCar_CellFormatting;
            PopulateGridView();
        }

        private void ManageCar_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }
        private void dgvCar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCar.Columns[e.ColumnIndex].Name == "Available" && e.Value != null)
            {
                string value = e.Value.ToString().Trim().ToUpper();

                if (value == "1" || value == "TRUE" || value == "YES")
                {
                    e.Value = "YES";
                }
                else
                {
                    e.Value = "NO";
                }

                e.FormattingApplied = true;
            }
        }


        private void ClearAll()
        {
            this.txtRegNo.Clear();
            this.txtBrand.Clear();
            this.txtModel.Clear();
            this.txtPrice.Clear();
            this.cmbAvailable.SelectedIndex = -1;
            this.txtSearchCar.Clear();
        }
        private void PopulateGridView(string sql = "select * from Manage_Car;")
        {
            try
            {
                this.Ds = this.Da.ExecuteQuery(sql);
                this.dgvCar.AutoGenerateColumns = false;
                this.dgvCar.DataSource = this.Ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnMCarLogout_Click(object sender, EventArgs e)
        {
            AdminDash admin = new AdminDash();
            this.Hide();
            admin.Show();
        }

        private void btnClearCar_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private bool ValidateInput()
        {
            string regNo = txtRegNo.Text;
            if (string.IsNullOrWhiteSpace(regNo))
            {
                MessageBox.Show("Registration number is required.");
                txtRegNo.Focus();
                return false;
            }
            if (regNo.Length != 7 || !regNo.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Registration number cannot be more than 7 letters");
                txtRegNo.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtBrand.Text))
            {
                MessageBox.Show("Brand is required.");
                txtBrand.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Model is required.");
                txtModel.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Price is required.");
                txtPrice.Focus();
                return false;
            }

            try
            {
                Convert.ToDecimal(txtPrice.Text);
            }
            catch
            {
                MessageBox.Show("Price must be a valid number.");
                txtPrice.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbAvailable.Text))
            {
                MessageBox.Show("Availability must be selected.");
                cmbAvailable.Focus();
                return false;
            }

            return true;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                { 
                    return; 
                }

                decimal price = Convert.ToDecimal(this.txtPrice.Text);
                int available = (cmbAvailable.Text.ToUpper() == "YES") ? 1 : 0;
                this.Sql = @"insert into Manage_Car
                           values ('" + this.txtRegNo.Text + "', '" + this.txtBrand.Text + "', '" + this.txtModel.Text + "', " + price + ", " + available + ");";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                {
                    MessageBox.Show("Car added successfully");
                }
                else
                {
                    MessageBox.Show("Car insertion failed");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error while adding car\n\n" + exc.Message);
            }
        }

        private void btnSaveCar_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (string.IsNullOrWhiteSpace(this.txtRegNo.Text))
                {
                    MessageBox.Show("Please select a car to update by double-clicking a row.");
                    return;
                }
                if (!ValidateInput())
                {
                    return;
                }
                dgvCar.EndEdit();
                decimal price = Convert.ToDecimal(this.txtPrice.Text);
                int available = (cmbAvailable.Text.ToUpper() == "YES") ? 1 : 0;
                this.Sql = @"update Manage_Car
                            set Brand = '" + this.txtBrand.Text + @"',
                                Model = '" + this.txtModel.Text + @"',
                                Price = " + price + @",
                                Available = " + available + @"
                            where RegNo = '" + this.txtRegNo.Text + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                {
                    MessageBox.Show("Car updated successfully");
                }
                else
                {
                    MessageBox.Show("Car update failed");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error while updating car\n\n" + exc.Message);
            }
        }

        private void btnDltCar_Click(object sender, EventArgs e)
        {
            try
            {
                string regNo = this.dgvCar.CurrentRow.Cells["RegNo"].Value.ToString();

                this.Sql = @"delete from Manage_Car where RegNo = '" + regNo + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                {
                    MessageBox.Show("Car has been deleted");
                }
                else
                {
                    MessageBox.Show("Car deletion failed");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error while deleting car\n\n" + exc.Message);
            }
        }
        private void dgvCar_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCar.CurrentRow == null || dgvCar.CurrentRow.IsNewRow)
            {
                return; 
            }

            try
            {
                if (dgvCar.CurrentRow.Cells["RegNo"].Value == null ||
                    dgvCar.CurrentRow.Cells["RegNo"].Value == DBNull.Value ||
                    string.IsNullOrWhiteSpace(dgvCar.CurrentRow.Cells["RegNo"].Value.ToString()))
                {
                    return; 
                }

                txtRegNo.Text = dgvCar.CurrentRow.Cells["RegNo"].Value?.ToString() ?? string.Empty;
                txtBrand.Text = dgvCar.CurrentRow.Cells["Brand"].Value?.ToString() ?? string.Empty;
                txtModel.Text = dgvCar.CurrentRow.Cells["Model"].Value?.ToString() ?? string.Empty;
                txtPrice.Text = dgvCar.CurrentRow.Cells["Price"].Value?.ToString() ?? string.Empty;

                cmbAvailable.Text = (dgvCar.CurrentRow.Cells["Available"].Value != null && dgvCar.CurrentRow.Cells["Available"].Value != DBNull.Value &&
                                     Convert.ToInt32(dgvCar.CurrentRow.Cells["Available"].Value) == 1)? "YES": "NO";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading car details\n\n" + ex.Message);
            }
        }

        private void txtSearchCar_TextChanged(object sender, EventArgs e)
        {
            string search = this.txtSearchCar.Text.Trim().ToUpper();
            this.Sql = "select * from Manage_Car where RegNo like '%" + this.txtSearchCar.Text + "%' or Brand like '%" + this.txtSearchCar.Text + "%';";
            this.PopulateGridView(this.Sql);
        }
    }
}
