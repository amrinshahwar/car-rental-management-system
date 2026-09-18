namespace CarRentalManagementSystem
{
    partial class ManageAcc
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
            this.ManageAccpanel = new System.Windows.Forms.Panel();
            this.btnMAccBack = new System.Windows.Forms.Button();
            this.lblManageAcc = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhn = new System.Windows.Forms.Label();
            this.lblSearchAcc = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhn = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.btnUpdateAcc = new System.Windows.Forms.Button();
            this.btnDltAcc = new System.Windows.Forms.Button();
            this.btnClearAcc = new System.Windows.Forms.Button();
            this.dgvAccountant = new System.Windows.Forms.DataGridView();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpPhn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.ManageAccpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountant)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageAccpanel
            // 
            this.ManageAccpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.ManageAccpanel.Controls.Add(this.btnMAccBack);
            this.ManageAccpanel.Controls.Add(this.lblManageAcc);
            this.ManageAccpanel.Location = new System.Drawing.Point(0, 0);
            this.ManageAccpanel.Name = "ManageAccpanel";
            this.ManageAccpanel.Size = new System.Drawing.Size(1046, 69);
            this.ManageAccpanel.TabIndex = 2;
            // 
            // btnMAccBack
            // 
            this.btnMAccBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnMAccBack.FlatAppearance.BorderSize = 0;
            this.btnMAccBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMAccBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMAccBack.Location = new System.Drawing.Point(960, 0);
            this.btnMAccBack.Name = "btnMAccBack";
            this.btnMAccBack.Size = new System.Drawing.Size(82, 35);
            this.btnMAccBack.TabIndex = 12;
            this.btnMAccBack.Text = "Back";
            this.btnMAccBack.UseVisualStyleBackColor = false;
            this.btnMAccBack.Click += new System.EventHandler(this.btnMAccBack_Click);
            // 
            // lblManageAcc
            // 
            this.lblManageAcc.AutoSize = true;
            this.lblManageAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblManageAcc.Font = new System.Drawing.Font("Ebrima", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageAcc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblManageAcc.Location = new System.Drawing.Point(394, 9);
            this.lblManageAcc.Name = "lblManageAcc";
            this.lblManageAcc.Size = new System.Drawing.Size(214, 45);
            this.lblManageAcc.TabIndex = 0;
            this.lblManageAcc.Text = "Accountants";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(30, 85);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 21);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "Id";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(30, 140);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 21);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(30, 195);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(83, 21);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "Address";
            // 
            // lblPhn
            // 
            this.lblPhn.AutoSize = true;
            this.lblPhn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhn.Location = new System.Drawing.Point(30, 250);
            this.lblPhn.Name = "lblPhn";
            this.lblPhn.Size = new System.Drawing.Size(65, 21);
            this.lblPhn.TabIndex = 17;
            this.lblPhn.Text = "Phone";
            // 
            // lblSearchAcc
            // 
            this.lblSearchAcc.AutoSize = true;
            this.lblSearchAcc.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchAcc.Location = new System.Drawing.Point(630, 100);
            this.lblSearchAcc.Name = "lblSearchAcc";
            this.lblSearchAcc.Size = new System.Drawing.Size(71, 21);
            this.lblSearchAcc.TabIndex = 27;
            this.lblSearchAcc.Text = "Search";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Ivory;
            this.txtId.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(168, 85);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(237, 27);
            this.txtId.TabIndex = 28;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Ivory;
            this.txtName.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(168, 140);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 27);
            this.txtName.TabIndex = 29;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.Ivory;
            this.txtAddress.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(168, 195);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(237, 27);
            this.txtAddress.TabIndex = 30;
            // 
            // txtPhn
            // 
            this.txtPhn.BackColor = System.Drawing.Color.Ivory;
            this.txtPhn.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhn.Location = new System.Drawing.Point(168, 250);
            this.txtPhn.Name = "txtPhn";
            this.txtPhn.Size = new System.Drawing.Size(237, 27);
            this.txtPhn.TabIndex = 31;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Ivory;
            this.txtSearch.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(717, 94);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(237, 27);
            this.txtSearch.TabIndex = 32;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnAddAcc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAcc.Location = new System.Drawing.Point(35, 411);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(102, 59);
            this.btnAddAcc.TabIndex = 33;
            this.btnAddAcc.Text = "Add";
            this.btnAddAcc.UseVisualStyleBackColor = false;
            this.btnAddAcc.Click += new System.EventHandler(this.btnAddAcc_Click);
            // 
            // btnUpdateAcc
            // 
            this.btnUpdateAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnUpdateAcc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAcc.Location = new System.Drawing.Point(185, 411);
            this.btnUpdateAcc.Name = "btnUpdateAcc";
            this.btnUpdateAcc.Size = new System.Drawing.Size(102, 59);
            this.btnUpdateAcc.TabIndex = 34;
            this.btnUpdateAcc.Text = "Update";
            this.btnUpdateAcc.UseVisualStyleBackColor = false;
            this.btnUpdateAcc.Click += new System.EventHandler(this.btnUpdateAcc_Click);
            // 
            // btnDltAcc
            // 
            this.btnDltAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnDltAcc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDltAcc.Location = new System.Drawing.Point(335, 411);
            this.btnDltAcc.Name = "btnDltAcc";
            this.btnDltAcc.Size = new System.Drawing.Size(102, 59);
            this.btnDltAcc.TabIndex = 35;
            this.btnDltAcc.Text = "Delete";
            this.btnDltAcc.UseVisualStyleBackColor = false;
            this.btnDltAcc.Click += new System.EventHandler(this.btnDltAcc_Click);
            // 
            // btnClearAcc
            // 
            this.btnClearAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnClearAcc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAcc.Location = new System.Drawing.Point(185, 494);
            this.btnClearAcc.Name = "btnClearAcc";
            this.btnClearAcc.Size = new System.Drawing.Size(102, 59);
            this.btnClearAcc.TabIndex = 37;
            this.btnClearAcc.Text = "Clear";
            this.btnClearAcc.UseVisualStyleBackColor = false;
            this.btnClearAcc.Click += new System.EventHandler(this.btnClearAcc_Click);
            // 
            // dgvAccountant
            // 
            this.dgvAccountant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccountant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccountant.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.dgvAccountant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpId,
            this.EmpName,
            this.EmpAdd,
            this.EmpPhn,
            this.HireDate,
            this.Salary});
            this.dgvAccountant.Location = new System.Drawing.Point(491, 141);
            this.dgvAccountant.Name = "dgvAccountant";
            this.dgvAccountant.RowHeadersWidth = 51;
            this.dgvAccountant.RowTemplate.Height = 24;
            this.dgvAccountant.Size = new System.Drawing.Size(523, 399);
            this.dgvAccountant.TabIndex = 38;
            this.dgvAccountant.DoubleClick += new System.EventHandler(this.dgvAccountant_DoubleClick);
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
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHireDate.Location = new System.Drawing.Point(30, 305);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(98, 21);
            this.lblHireDate.TabIndex = 39;
            this.lblHireDate.Text = "Hire Date";
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHireDate.Location = new System.Drawing.Point(168, 305);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(237, 22);
            this.dtpHireDate.TabIndex = 40;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(30, 360);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(68, 21);
            this.lblSalary.TabIndex = 41;
            this.lblSalary.Text = "Salary";
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.Ivory;
            this.txtSalary.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(168, 360);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(237, 27);
            this.txtSalary.TabIndex = 42;
            // 
            // ManageAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1030, 565);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(this.lblHireDate);
            this.Controls.Add(this.dgvAccountant);
            this.Controls.Add(this.btnClearAcc);
            this.Controls.Add(this.btnDltAcc);
            this.Controls.Add(this.btnUpdateAcc);
            this.Controls.Add(this.btnAddAcc);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtPhn);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblSearchAcc);
            this.Controls.Add(this.lblPhn);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.ManageAccpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAcc";
            this.ManageAccpanel.ResumeLayout(false);
            this.ManageAccpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ManageAccpanel;
        private System.Windows.Forms.Button btnMAccBack;
        private System.Windows.Forms.Label lblManageAcc;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhn;
        private System.Windows.Forms.Label lblSearchAcc;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddAcc;
        private System.Windows.Forms.Button btnUpdateAcc;
        private System.Windows.Forms.Button btnDltAcc;
        private System.Windows.Forms.Button btnClearAcc;
        private System.Windows.Forms.DataGridView dgvAccountant;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpPhn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
    }
}