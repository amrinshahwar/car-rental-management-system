namespace CarRentalManagementSystem
{
    partial class ManageStaff
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
            this.ManageStaffpanel = new System.Windows.Forms.Panel();
            this.btnMStaffBack = new System.Windows.Forms.Button();
            this.lblManageStaff = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhn = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhn = new System.Windows.Forms.TextBox();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.btnDltStaff = new System.Windows.Forms.Button();
            this.btnClearStaff = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.lblSearchStaff = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpPhn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManageStaffpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageStaffpanel
            // 
            this.ManageStaffpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.ManageStaffpanel.Controls.Add(this.btnMStaffBack);
            this.ManageStaffpanel.Controls.Add(this.lblManageStaff);
            this.ManageStaffpanel.Location = new System.Drawing.Point(0, 0);
            this.ManageStaffpanel.Name = "ManageStaffpanel";
            this.ManageStaffpanel.Size = new System.Drawing.Size(1046, 69);
            this.ManageStaffpanel.TabIndex = 1;
            // 
            // btnMStaffBack
            // 
            this.btnMStaffBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnMStaffBack.FlatAppearance.BorderSize = 0;
            this.btnMStaffBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMStaffBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMStaffBack.Location = new System.Drawing.Point(960, 0);
            this.btnMStaffBack.Name = "btnMStaffBack";
            this.btnMStaffBack.Size = new System.Drawing.Size(82, 35);
            this.btnMStaffBack.TabIndex = 12;
            this.btnMStaffBack.Text = "Back";
            this.btnMStaffBack.UseVisualStyleBackColor = false;
            this.btnMStaffBack.Click += new System.EventHandler(this.btnMStaffBack_Click);
            // 
            // lblManageStaff
            // 
            this.lblManageStaff.AutoSize = true;
            this.lblManageStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblManageStaff.Font = new System.Drawing.Font("Ebrima", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageStaff.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblManageStaff.Location = new System.Drawing.Point(462, 9);
            this.lblManageStaff.Name = "lblManageStaff";
            this.lblManageStaff.Size = new System.Drawing.Size(111, 45);
            this.lblManageStaff.TabIndex = 0;
            this.lblManageStaff.Text = "Staffs";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(30, 85);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 21);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "Id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(30, 140);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 21);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(30, 195);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(83, 21);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Address";
            // 
            // lblPhn
            // 
            this.lblPhn.AutoSize = true;
            this.lblPhn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhn.Location = new System.Drawing.Point(30, 250);
            this.lblPhn.Name = "lblPhn";
            this.lblPhn.Size = new System.Drawing.Size(65, 21);
            this.lblPhn.TabIndex = 16;
            this.lblPhn.Text = "Phone";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Ivory;
            this.txtId.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(168, 85);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(237, 27);
            this.txtId.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Ivory;
            this.txtName.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(168, 140);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 27);
            this.txtName.TabIndex = 18;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Ivory;
            this.txtAddress.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(168, 195);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(237, 27);
            this.txtAddress.TabIndex = 19;
            // 
            // txtPhn
            // 
            this.txtPhn.BackColor = System.Drawing.Color.Ivory;
            this.txtPhn.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhn.Location = new System.Drawing.Point(168, 250);
            this.txtPhn.Name = "txtPhn";
            this.txtPhn.Size = new System.Drawing.Size(237, 27);
            this.txtPhn.TabIndex = 20;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnAddStaff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.Location = new System.Drawing.Point(35, 411);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(102, 59);
            this.btnAddStaff.TabIndex = 21;
            this.btnAddStaff.Text = "Add";
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnUpdateStaff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStaff.Location = new System.Drawing.Point(185, 411);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(102, 59);
            this.btnUpdateStaff.TabIndex = 22;
            this.btnUpdateStaff.Text = "Update";
            this.btnUpdateStaff.UseVisualStyleBackColor = false;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // btnDltStaff
            // 
            this.btnDltStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnDltStaff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDltStaff.Location = new System.Drawing.Point(335, 411);
            this.btnDltStaff.Name = "btnDltStaff";
            this.btnDltStaff.Size = new System.Drawing.Size(102, 59);
            this.btnDltStaff.TabIndex = 23;
            this.btnDltStaff.Text = "Delete";
            this.btnDltStaff.UseVisualStyleBackColor = false;
            this.btnDltStaff.Click += new System.EventHandler(this.btnDltStaff_Click);
            // 
            // btnClearStaff
            // 
            this.btnClearStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnClearStaff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearStaff.Location = new System.Drawing.Point(185, 494);
            this.btnClearStaff.Name = "btnClearStaff";
            this.btnClearStaff.Size = new System.Drawing.Size(102, 59);
            this.btnClearStaff.TabIndex = 24;
            this.btnClearStaff.Text = "Clear";
            this.btnClearStaff.UseVisualStyleBackColor = false;
            this.btnClearStaff.Click += new System.EventHandler(this.btnClearStaff_Click);
            // 
            // dgvStaff
            // 
            this.dgvStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaff.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpId,
            this.EmpName,
            this.EmpAdd,
            this.EmpPhn,
            this.HireDate,
            this.Salary});
            this.dgvStaff.Location = new System.Drawing.Point(491, 141);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.RowHeadersWidth = 51;
            this.dgvStaff.RowTemplate.Height = 24;
            this.dgvStaff.Size = new System.Drawing.Size(523, 399);
            this.dgvStaff.TabIndex = 25;
            this.dgvStaff.DoubleClick += new System.EventHandler(this.dgvStaff_DoubleClick);
            // 
            // lblSearchStaff
            // 
            this.lblSearchStaff.AutoSize = true;
            this.lblSearchStaff.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchStaff.Location = new System.Drawing.Point(630, 100);
            this.lblSearchStaff.Name = "lblSearchStaff";
            this.lblSearchStaff.Size = new System.Drawing.Size(71, 21);
            this.lblSearchStaff.TabIndex = 26;
            this.lblSearchStaff.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Ivory;
            this.txtSearch.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(717, 94);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(237, 27);
            this.txtSearch.TabIndex = 27;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHireDate.Location = new System.Drawing.Point(30, 305);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(98, 21);
            this.lblHireDate.TabIndex = 28;
            this.lblHireDate.Text = "Hire Date";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(30, 360);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(68, 21);
            this.lblSalary.TabIndex = 29;
            this.lblSalary.Text = "Salary";
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHireDate.Location = new System.Drawing.Point(168, 305);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(237, 22);
            this.dtpHireDate.TabIndex = 33;
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.Ivory;
            this.txtSalary.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(168, 360);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(237, 27);
            this.txtSalary.TabIndex = 34;
            // 
            // EmpId
            // 
            this.EmpId.DataPropertyName = "EmpId";
            this.EmpId.HeaderText = "EmpId";
            this.EmpId.MinimumWidth = 6;
            this.EmpId.Name = "EmpId";
            this.EmpId.ReadOnly = true;
            // 
            // EmpName
            // 
            this.EmpName.DataPropertyName = "EmpName";
            this.EmpName.HeaderText = "EmpName";
            this.EmpName.MinimumWidth = 6;
            this.EmpName.Name = "EmpName";
            // 
            // EmpAdd
            // 
            this.EmpAdd.DataPropertyName = "EmpAdd";
            this.EmpAdd.HeaderText = "EmpAdd";
            this.EmpAdd.MinimumWidth = 6;
            this.EmpAdd.Name = "EmpAdd";
            // 
            // EmpPhn
            // 
            this.EmpPhn.DataPropertyName = "EmpPhn";
            this.EmpPhn.HeaderText = "EmpPhn";
            this.EmpPhn.MinimumWidth = 6;
            this.EmpPhn.Name = "EmpPhn";
            // 
            // HireDate
            // 
            this.HireDate.DataPropertyName = "HireDate";
            this.HireDate.HeaderText = "HireDate";
            this.HireDate.MinimumWidth = 6;
            this.HireDate.Name = "HireDate";
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            // 
            // ManageStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1030, 565);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblHireDate);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearchStaff);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.btnClearStaff);
            this.Controls.Add(this.btnDltStaff);
            this.Controls.Add(this.btnUpdateStaff);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.txtPhn);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblPhn);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.ManageStaffpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageStaff";
            this.ManageStaffpanel.ResumeLayout(false);
            this.ManageStaffpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ManageStaffpanel;
        private System.Windows.Forms.Button btnMStaffBack;
        private System.Windows.Forms.Label lblManageStaff;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhn;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhn;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btnDltStaff;
        private System.Windows.Forms.Button btnClearStaff;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Label lblSearchStaff;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpPhn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
    }
}