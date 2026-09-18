namespace CarRentalManagementSystem
{
    partial class Maintenance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Maintainpanel = new System.Windows.Forms.Panel();
            this.btnMaintainBack = new System.Windows.Forms.Button();
            this.lblMaintain = new System.Windows.Forms.Label();
            this.lblMaintainId = new System.Windows.Forms.Label();
            this.lblMaintainCarReg = new System.Windows.Forms.Label();
            this.lblMaintainCarModel = new System.Windows.Forms.Label();
            this.lblMaintainType = new System.Windows.Forms.Label();
            this.lblMDate = new System.Windows.Forms.Label();
            this.txtMaintainId = new System.Windows.Forms.TextBox();
            this.cmbMCarReg = new System.Windows.Forms.ComboBox();
            this.cmbMCarModel = new System.Windows.Forms.ComboBox();
            this.cmbMaintenanceType = new System.Windows.Forms.ComboBox();
            this.dtpMDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddRent = new System.Windows.Forms.Button();
            this.btnUpdateRent = new System.Windows.Forms.Button();
            this.btnClearRent = new System.Windows.Forms.Button();
            this.dgvMaintenance = new System.Windows.Forms.DataGridView();
            this.lblMSearch = new System.Windows.Forms.Label();
            this.txtMSearch = new System.Windows.Forms.TextBox();
            this.MId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maintainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).BeginInit();
            this.SuspendLayout();
            // 
            // Maintainpanel
            // 
            this.Maintainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.Maintainpanel.Controls.Add(this.btnMaintainBack);
            this.Maintainpanel.Controls.Add(this.lblMaintain);
            this.Maintainpanel.Location = new System.Drawing.Point(0, 0);
            this.Maintainpanel.Name = "Maintainpanel";
            this.Maintainpanel.Size = new System.Drawing.Size(1046, 69);
            this.Maintainpanel.TabIndex = 5;
            // 
            // btnMaintainBack
            // 
            this.btnMaintainBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnMaintainBack.FlatAppearance.BorderSize = 0;
            this.btnMaintainBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintainBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintainBack.Location = new System.Drawing.Point(960, 0);
            this.btnMaintainBack.Name = "btnMaintainBack";
            this.btnMaintainBack.Size = new System.Drawing.Size(82, 35);
            this.btnMaintainBack.TabIndex = 12;
            this.btnMaintainBack.Text = "Back";
            this.btnMaintainBack.UseVisualStyleBackColor = false;
            this.btnMaintainBack.Click += new System.EventHandler(this.btnMaintainBack_Click);
            // 
            // lblMaintain
            // 
            this.lblMaintain.AutoSize = true;
            this.lblMaintain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMaintain.Font = new System.Drawing.Font("Ebrima", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaintain.Location = new System.Drawing.Point(431, 9);
            this.lblMaintain.Name = "lblMaintain";
            this.lblMaintain.Size = new System.Drawing.Size(222, 45);
            this.lblMaintain.TabIndex = 0;
            this.lblMaintain.Text = "Maintenance";
            // 
            // lblMaintainId
            // 
            this.lblMaintainId.AutoSize = true;
            this.lblMaintainId.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintainId.Location = new System.Drawing.Point(35, 100);
            this.lblMaintainId.Name = "lblMaintainId";
            this.lblMaintainId.Size = new System.Drawing.Size(151, 21);
            this.lblMaintainId.TabIndex = 16;
            this.lblMaintainId.Text = "Maintenance Id";
            // 
            // lblMaintainCarReg
            // 
            this.lblMaintainCarReg.AutoSize = true;
            this.lblMaintainCarReg.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintainCarReg.Location = new System.Drawing.Point(35, 175);
            this.lblMaintainCarReg.Name = "lblMaintainCarReg";
            this.lblMaintainCarReg.Size = new System.Drawing.Size(160, 21);
            this.lblMaintainCarReg.TabIndex = 18;
            this.lblMaintainCarReg.Text = "Car Registration";
            // 
            // lblMaintainCarModel
            // 
            this.lblMaintainCarModel.AutoSize = true;
            this.lblMaintainCarModel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintainCarModel.Location = new System.Drawing.Point(35, 250);
            this.lblMaintainCarModel.Name = "lblMaintainCarModel";
            this.lblMaintainCarModel.Size = new System.Drawing.Size(106, 21);
            this.lblMaintainCarModel.TabIndex = 19;
            this.lblMaintainCarModel.Text = "Car Model";
            // 
            // lblMaintainType
            // 
            this.lblMaintainType.AutoSize = true;
            this.lblMaintainType.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintainType.Location = new System.Drawing.Point(35, 325);
            this.lblMaintainType.Name = "lblMaintainType";
            this.lblMaintainType.Size = new System.Drawing.Size(177, 21);
            this.lblMaintainType.TabIndex = 20;
            this.lblMaintainType.Text = "Maintenance Type";
            // 
            // lblMDate
            // 
            this.lblMDate.AutoSize = true;
            this.lblMDate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMDate.Location = new System.Drawing.Point(35, 400);
            this.lblMDate.Name = "lblMDate";
            this.lblMDate.Size = new System.Drawing.Size(52, 21);
            this.lblMDate.TabIndex = 22;
            this.lblMDate.Text = "Date";
            // 
            // txtMaintainId
            // 
            this.txtMaintainId.BackColor = System.Drawing.Color.Ivory;
            this.txtMaintainId.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaintainId.Location = new System.Drawing.Point(237, 100);
            this.txtMaintainId.Name = "txtMaintainId";
            this.txtMaintainId.Size = new System.Drawing.Size(237, 27);
            this.txtMaintainId.TabIndex = 30;
            // 
            // cmbMCarReg
            // 
            this.cmbMCarReg.BackColor = System.Drawing.Color.Ivory;
            this.cmbMCarReg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMCarReg.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMCarReg.FormattingEnabled = true;
            this.cmbMCarReg.Items.AddRange(new object[] {
            ""});
            this.cmbMCarReg.Location = new System.Drawing.Point(237, 175);
            this.cmbMCarReg.Name = "cmbMCarReg";
            this.cmbMCarReg.Size = new System.Drawing.Size(237, 26);
            this.cmbMCarReg.TabIndex = 31;
            this.cmbMCarReg.SelectedIndexChanged += new System.EventHandler(this.cmbMCarReg_SelectedIndexChanged);
            // 
            // cmbMCarModel
            // 
            this.cmbMCarModel.BackColor = System.Drawing.Color.Ivory;
            this.cmbMCarModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMCarModel.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMCarModel.FormattingEnabled = true;
            this.cmbMCarModel.Items.AddRange(new object[] {
            ""});
            this.cmbMCarModel.Location = new System.Drawing.Point(237, 250);
            this.cmbMCarModel.Name = "cmbMCarModel";
            this.cmbMCarModel.Size = new System.Drawing.Size(237, 26);
            this.cmbMCarModel.TabIndex = 32;
            // 
            // cmbMaintenanceType
            // 
            this.cmbMaintenanceType.BackColor = System.Drawing.Color.Ivory;
            this.cmbMaintenanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaintenanceType.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaintenanceType.FormattingEnabled = true;
            this.cmbMaintenanceType.Items.AddRange(new object[] {
            "Engine Repair",
            "Dent Repair",
            "Tire Replacement",
            "Fuel Change",
            "General "});
            this.cmbMaintenanceType.Location = new System.Drawing.Point(237, 325);
            this.cmbMaintenanceType.Name = "cmbMaintenanceType";
            this.cmbMaintenanceType.Size = new System.Drawing.Size(237, 26);
            this.cmbMaintenanceType.TabIndex = 33;
            // 
            // dtpMDate
            // 
            this.dtpMDate.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMDate.Location = new System.Drawing.Point(237, 400);
            this.dtpMDate.Name = "dtpMDate";
            this.dtpMDate.Size = new System.Drawing.Size(237, 22);
            this.dtpMDate.TabIndex = 35;
            // 
            // btnAddRent
            // 
            this.btnAddRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnAddRent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRent.Location = new System.Drawing.Point(35, 470);
            this.btnAddRent.Name = "btnAddRent";
            this.btnAddRent.Size = new System.Drawing.Size(102, 59);
            this.btnAddRent.TabIndex = 40;
            this.btnAddRent.Text = "Add";
            this.btnAddRent.UseVisualStyleBackColor = false;
            this.btnAddRent.Click += new System.EventHandler(this.btnAddM_Click);
            // 
            // btnUpdateRent
            // 
            this.btnUpdateRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnUpdateRent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRent.Location = new System.Drawing.Point(188, 470);
            this.btnUpdateRent.Name = "btnUpdateRent";
            this.btnUpdateRent.Size = new System.Drawing.Size(102, 59);
            this.btnUpdateRent.TabIndex = 41;
            this.btnUpdateRent.Text = "Update";
            this.btnUpdateRent.UseVisualStyleBackColor = false;
            this.btnUpdateRent.Click += new System.EventHandler(this.btnUpdateM_Click);
            // 
            // btnClearRent
            // 
            this.btnClearRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnClearRent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearRent.Location = new System.Drawing.Point(343, 470);
            this.btnClearRent.Name = "btnClearRent";
            this.btnClearRent.Size = new System.Drawing.Size(102, 59);
            this.btnClearRent.TabIndex = 42;
            this.btnClearRent.Text = "Clear";
            this.btnClearRent.UseVisualStyleBackColor = false;
            this.btnClearRent.Click += new System.EventHandler(this.btnClearM_Click);
            // 
            // dgvMaintenance
            // 
            this.dgvMaintenance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaintenance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.dgvMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MId,
            this.RegNo,
            this.Model,
            this.MType,
            this.Date,
            this.EmpId});
            this.dgvMaintenance.Location = new System.Drawing.Point(491, 141);
            this.dgvMaintenance.Name = "dgvMaintenance";
            this.dgvMaintenance.RowHeadersWidth = 51;
            this.dgvMaintenance.RowTemplate.Height = 24;
            this.dgvMaintenance.Size = new System.Drawing.Size(523, 399);
            this.dgvMaintenance.TabIndex = 43;
            this.dgvMaintenance.DoubleClick += new System.EventHandler(this.dgvMaintenance_DoubleClick);
            // 
            // lblMSearch
            // 
            this.lblMSearch.AutoSize = true;
            this.lblMSearch.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSearch.Location = new System.Drawing.Point(630, 100);
            this.lblMSearch.Name = "lblMSearch";
            this.lblMSearch.Size = new System.Drawing.Size(71, 21);
            this.lblMSearch.TabIndex = 44;
            this.lblMSearch.Text = "Search";
            // 
            // txtMSearch
            // 
            this.txtMSearch.BackColor = System.Drawing.Color.Ivory;
            this.txtMSearch.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSearch.Location = new System.Drawing.Point(717, 94);
            this.txtMSearch.Name = "txtMSearch";
            this.txtMSearch.Size = new System.Drawing.Size(237, 27);
            this.txtMSearch.TabIndex = 45;
            this.txtMSearch.TextChanged += new System.EventHandler(this.txtMSearch_TextChanged);
            // 
            // MId
            // 
            this.MId.DataPropertyName = "MId";
            this.MId.HeaderText = "MId";
            this.MId.MinimumWidth = 6;
            this.MId.Name = "MId";
            this.MId.ReadOnly = true;
            // 
            // RegNo
            // 
            this.RegNo.DataPropertyName = "RegNo";
            this.RegNo.HeaderText = "RegNo";
            this.RegNo.MinimumWidth = 6;
            this.RegNo.Name = "RegNo";
            this.RegNo.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // MType
            // 
            this.MType.DataPropertyName = "MType";
            this.MType.HeaderText = "MType";
            this.MType.MinimumWidth = 6;
            this.MType.Name = "MType";
            this.MType.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // EmpId
            // 
            this.EmpId.DataPropertyName = "EmpId";
            this.EmpId.HeaderText = "StaffId";
            this.EmpId.MinimumWidth = 6;
            this.EmpId.Name = "EmpId";
            this.EmpId.ReadOnly = true;
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1030, 565);
            this.Controls.Add(this.txtMSearch);
            this.Controls.Add(this.lblMSearch);
            this.Controls.Add(this.dgvMaintenance);
            this.Controls.Add(this.btnClearRent);
            this.Controls.Add(this.btnUpdateRent);
            this.Controls.Add(this.btnAddRent);
            this.Controls.Add(this.dtpMDate);
            this.Controls.Add(this.cmbMaintenanceType);
            this.Controls.Add(this.cmbMCarModel);
            this.Controls.Add(this.cmbMCarReg);
            this.Controls.Add(this.txtMaintainId);
            this.Controls.Add(this.lblMDate);
            this.Controls.Add(this.lblMaintainType);
            this.Controls.Add(this.lblMaintainCarModel);
            this.Controls.Add(this.lblMaintainCarReg);
            this.Controls.Add(this.lblMaintainId);
            this.Controls.Add(this.Maintainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Maintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance";
            this.Maintainpanel.ResumeLayout(false);
            this.Maintainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Maintainpanel;
        private System.Windows.Forms.Button btnMaintainBack;
        private System.Windows.Forms.Label lblMaintain;
        private System.Windows.Forms.Label lblMaintainId;
        private System.Windows.Forms.Label lblMaintainCarReg;
        private System.Windows.Forms.Label lblMaintainCarModel;
        private System.Windows.Forms.Label lblMaintainType;
        private System.Windows.Forms.Label lblMDate;
        private System.Windows.Forms.TextBox txtMaintainId;
        private System.Windows.Forms.ComboBox cmbMCarReg;
        private System.Windows.Forms.ComboBox cmbMCarModel;
        private System.Windows.Forms.ComboBox cmbMaintenanceType;
        private System.Windows.Forms.DateTimePicker dtpMDate;
        private System.Windows.Forms.Button btnAddRent;
        private System.Windows.Forms.Button btnUpdateRent;
        private System.Windows.Forms.Button btnClearRent;
        private System.Windows.Forms.DataGridView dgvMaintenance;
        private System.Windows.Forms.Label lblMSearch;
        private System.Windows.Forms.TextBox txtMSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn MId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn MType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
    }
}