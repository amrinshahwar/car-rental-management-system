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
    public partial class Maintenance : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private string Sql { get; set; }
        private string staffId;
        public Maintenance(string empId)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.staffId = empId;
            this.PopulateGridView();
            GenerateMaintenanceId();
            LoadCarComboBox();
        }
        private void PopulateGridView(string sql = "")
        {
            try
            {
                if (string.IsNullOrEmpty(sql))
                {
                    sql = @"select m.MId, m.RegNo, c.Model, m.MType, m.Date, m.EmpId
                    from Maintenance m
                    join Manage_Car c on m.RegNo = c.RegNo;";
                }

                this.Ds = this.Da.ExecuteQuery(sql);
                this.dgvMaintenance.AutoGenerateColumns = false;
                this.dgvMaintenance.DataSource = this.Ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
        private void GenerateMaintenanceId()
        {
            this.Sql = "select * from Maintenance order by MId desc;";
            DataTable Dt = this.Da.ExecuteQueryTable(this.Sql);
            if (Dt.Rows.Count > 0)
            {
                string id = Dt.Rows[0]["MId"].ToString();
                string[] str = id.Split('M');
                int n = Convert.ToInt32(str[1]);
                string newID = "M" + (++n).ToString("d4");
                this.txtMaintainId.Text = newID;
            }
            else
            {
                this.txtMaintainId.Text = "M0001";
            }
            this.txtMaintainId.ReadOnly = true;
        }
        private void LoadCarComboBox()
        {
            this.Sql = "select RegNo, Model from Manage_Car;";
            DataTable dtCar = this.Da.ExecuteQueryTable(this.Sql);
            cmbMCarReg.DisplayMember = "RegNo";
            cmbMCarReg.ValueMember = "RegNo";
            cmbMCarReg.DataSource = dtCar;
            cmbMCarReg.SelectedIndex = -1;

            cmbMCarModel.DisplayMember = "Model";
            cmbMCarModel.ValueMember = "Model";
            cmbMCarModel.DataSource = dtCar;
            cmbMCarModel.SelectedIndex = -1;
        }

        private void btnMaintainBack_Click(object sender, EventArgs e)
        {
            StaffDash staff = new StaffDash(this.staffId);
            this.Hide();
            staff.Show();
        }
        private void ClearAll()
        {
            this.txtMaintainId.Clear();
            this.cmbMCarReg.SelectedIndex = -1;
            this.cmbMCarModel.SelectedIndex = -1;
            this.cmbMaintenanceType.SelectedIndex = -1;
            this.dtpMDate.Value = DateTime.Now;
            GenerateMaintenanceId();
        }

        private void cmbMCarReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMCarReg.SelectedIndex >= 0)
            {
                DataRowView drv = (DataRowView)cmbMCarReg.SelectedItem;
                cmbMCarModel.SelectedValue = drv["Model"].ToString();
            }
        }

        private void txtMSearch_TextChanged(object sender, EventArgs e)
        {
            string search = this.txtMSearch.Text.Trim().ToUpper();
            this.Sql = @"select m.MId, m.RegNo, c.Model, m.MType, m.Date, m.EmpId
             from Maintenance m join Manage_Car c ON m.RegNo = c.RegNo
             where m.MId like '%" + search + "%' or m.RegNo like '%" + search + "%';";
            this.PopulateGridView(this.Sql);

        }

        private void dgvMaintenance_DoubleClick(object sender, EventArgs e)
        {
            if (dgvMaintenance.CurrentRow == null || dgvMaintenance.CurrentRow.IsNewRow)
            {
                return;
            }

            try
            {
                txtMaintainId.ReadOnly = true;
                txtMaintainId.Text = dgvMaintenance.CurrentRow.Cells["MId"].Value?.ToString() ?? string.Empty;

                cmbMCarReg.SelectedValue = dgvMaintenance.CurrentRow.Cells["RegNo"].Value?.ToString();
                cmbMCarModel.SelectedValue = dgvMaintenance.CurrentRow.Cells["Model"].Value?.ToString();

                dtpMDate.Value = dgvMaintenance.CurrentRow.Cells["Date"].Value != null && dgvMaintenance.CurrentRow.Cells["Date"].Value != DBNull.Value
                    ? Convert.ToDateTime(dgvMaintenance.CurrentRow.Cells["Date"].Value)
                    : DateTime.Now;

                cmbMaintenanceType.Text = dgvMaintenance.CurrentRow.Cells["MType"].Value?.ToString().Trim() ?? string.Empty;

                string recordStaffId = dgvMaintenance.CurrentRow.Cells["EmpId"].Value?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading maintenance record details\n\n" + ex.Message);
            }
        }

        private bool ValidateInput()
        {
            if (cmbMCarReg.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a Car Registration number.");
                cmbMCarReg.Focus();
                return false;
            }

            if (cmbMCarModel.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a Car Model.");
                cmbMCarModel.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbMaintenanceType.Text))
            {
                MessageBox.Show("Please select a Maintenance Type.");
                cmbMaintenanceType.Focus();
                return false;
            }

            if (dtpMDate.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("Maintenance date cannot be in the future.");
                dtpMDate.Focus();
                return false;
            }

            return true;
        }


        private void btnAddM_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }

                this.Sql = @"insert into Maintenance values 
                           ('" + this.txtMaintainId.Text + "', '" + this.cmbMCarReg.Text + "', '" + this.cmbMaintenanceType.Text + "', '" + this.dtpMDate.Value.ToString("yyyy-MM-dd") + "', '" + this.staffId + "');";

                int count = this.Da.ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                {
                    MessageBox.Show("Maintenance record added successfully");
                }
                else
                {
                    MessageBox.Show("Record insertion failed");
                }

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error while adding record\n\n" + exc.Message);
            }
        }

        private void btnUpdateM_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtMaintainId.Text))
                {
                    MessageBox.Show("Please select a record to update.");
                    return;
                }

                if (!ValidateInput())
                {
                    return;
                }

                this.Sql = "select * from Maintenance where MId = '" + this.txtMaintainId.Text.Trim() + "';";
                this.Ds = this.Da.ExecuteQuery(this.Sql);

                if (this.Ds.Tables[0].Rows.Count == 1)
                {
                    this.Sql = @"update Maintenance
                    set RegNo = '" + this.cmbMCarReg.Text + @"',
                    MType = '" + this.cmbMaintenanceType.Text + @"',
                    Date = '" + this.dtpMDate.Value.ToString("yyyy-MM-dd") + @"'
                    where MId = '" + this.txtMaintainId.Text + "';";
                    int count = this.Da.ExecuteUpdateQuery(this.Sql);
                    if (count == 1)
                    {
                        MessageBox.Show("Maintenance record updated.");
                    }
                    else
                    {
                        MessageBox.Show("Data updation failed.");
                    }
                }
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating\n\n " + ex.Message);
            }
        }

        private void btnClearM_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
