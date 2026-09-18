namespace CarRentalManagementSystem
{
    partial class Rentals
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
            this.Rentpanel = new System.Windows.Forms.Panel();
            this.btnRentBack = new System.Windows.Forms.Button();
            this.lblRent = new System.Windows.Forms.Label();
            this.lblRentalId = new System.Windows.Forms.Label();
            this.lblRCustId = new System.Windows.Forms.Label();
            this.lblCarReg = new System.Windows.Forms.Label();
            this.lblRentDate = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblBaseFee = new System.Windows.Forms.Label();
            this.lblLateFee = new System.Windows.Forms.Label();
            this.lblRentStatus = new System.Windows.Forms.Label();
            this.txtRentId = new System.Windows.Forms.TextBox();
            this.cmbRentCustId = new System.Windows.Forms.ComboBox();
            this.cmbRentCarReg = new System.Windows.Forms.ComboBox();
            this.dtpRentDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.txtBaseFee = new System.Windows.Forms.TextBox();
            this.txtLateFee = new System.Windows.Forms.TextBox();
            this.cmbRentStatus = new System.Windows.Forms.ComboBox();
            this.btnAddRent = new System.Windows.Forms.Button();
            this.btnUpdateRent = new System.Windows.Forms.Button();
            this.btnClearRent = new System.Windows.Forms.Button();
            this.dgvRentals = new System.Windows.Forms.DataGridView();
            this.lblRentSearch = new System.Windows.Forms.Label();
            this.txtRentSearch = new System.Windows.Forms.TextBox();
            this.btnDltRent = new System.Windows.Forms.Button();
            this.RentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LateFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rentpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // Rentpanel
            // 
            this.Rentpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.Rentpanel.Controls.Add(this.btnRentBack);
            this.Rentpanel.Controls.Add(this.lblRent);
            this.Rentpanel.Location = new System.Drawing.Point(0, 0);
            this.Rentpanel.Name = "Rentpanel";
            this.Rentpanel.Size = new System.Drawing.Size(1046, 69);
            this.Rentpanel.TabIndex = 4;
            // 
            // btnRentBack
            // 
            this.btnRentBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnRentBack.FlatAppearance.BorderSize = 0;
            this.btnRentBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentBack.Location = new System.Drawing.Point(960, 0);
            this.btnRentBack.Name = "btnRentBack";
            this.btnRentBack.Size = new System.Drawing.Size(82, 35);
            this.btnRentBack.TabIndex = 12;
            this.btnRentBack.Text = "Back";
            this.btnRentBack.UseVisualStyleBackColor = false;
            this.btnRentBack.Click += new System.EventHandler(this.btnRentBack_Click);
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRent.Font = new System.Drawing.Font("Ebrima", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRent.Location = new System.Drawing.Point(450, 9);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(135, 45);
            this.lblRent.TabIndex = 0;
            this.lblRent.Text = "Rentals";
            // 
            // lblRentalId
            // 
            this.lblRentalId.AutoSize = true;
            this.lblRentalId.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalId.Location = new System.Drawing.Point(27, 85);
            this.lblRentalId.Name = "lblRentalId";
            this.lblRentalId.Size = new System.Drawing.Size(94, 21);
            this.lblRentalId.TabIndex = 15;
            this.lblRentalId.Text = "Rental Id";
            // 
            // lblRCustId
            // 
            this.lblRCustId.AutoSize = true;
            this.lblRCustId.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRCustId.Location = new System.Drawing.Point(27, 130);
            this.lblRCustId.Name = "lblRCustId";
            this.lblRCustId.Size = new System.Drawing.Size(122, 21);
            this.lblRCustId.TabIndex = 16;
            this.lblRCustId.Text = "Customer Id";
            // 
            // lblCarReg
            // 
            this.lblCarReg.AutoSize = true;
            this.lblCarReg.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarReg.Location = new System.Drawing.Point(27, 175);
            this.lblCarReg.Name = "lblCarReg";
            this.lblCarReg.Size = new System.Drawing.Size(109, 21);
            this.lblCarReg.TabIndex = 17;
            this.lblCarReg.Text = "Car RegNo";
            // 
            // lblRentDate
            // 
            this.lblRentDate.AutoSize = true;
            this.lblRentDate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentDate.Location = new System.Drawing.Point(27, 220);
            this.lblRentDate.Name = "lblRentDate";
            this.lblRentDate.Size = new System.Drawing.Size(117, 21);
            this.lblRentDate.TabIndex = 18;
            this.lblRentDate.Text = "Rental Date";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(27, 265);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(94, 21);
            this.lblDueDate.TabIndex = 19;
            this.lblDueDate.Text = "Due Date";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.Location = new System.Drawing.Point(27, 310);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(119, 21);
            this.lblReturnDate.TabIndex = 20;
            this.lblReturnDate.Text = "Return Date";
            // 
            // lblBaseFee
            // 
            this.lblBaseFee.AutoSize = true;
            this.lblBaseFee.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseFee.Location = new System.Drawing.Point(27, 355);
            this.lblBaseFee.Name = "lblBaseFee";
            this.lblBaseFee.Size = new System.Drawing.Size(91, 21);
            this.lblBaseFee.TabIndex = 21;
            this.lblBaseFee.Text = "Base Fee";
            // 
            // lblLateFee
            // 
            this.lblLateFee.AutoSize = true;
            this.lblLateFee.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLateFee.Location = new System.Drawing.Point(27, 400);
            this.lblLateFee.Name = "lblLateFee";
            this.lblLateFee.Size = new System.Drawing.Size(88, 21);
            this.lblLateFee.TabIndex = 22;
            this.lblLateFee.Text = "Late Fee";
            // 
            // lblRentStatus
            // 
            this.lblRentStatus.AutoSize = true;
            this.lblRentStatus.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentStatus.Location = new System.Drawing.Point(27, 445);
            this.lblRentStatus.Name = "lblRentStatus";
            this.lblRentStatus.Size = new System.Drawing.Size(66, 21);
            this.lblRentStatus.TabIndex = 24;
            this.lblRentStatus.Text = "Status";
            // 
            // txtRentId
            // 
            this.txtRentId.BackColor = System.Drawing.Color.Ivory;
            this.txtRentId.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentId.Location = new System.Drawing.Point(173, 85);
            this.txtRentId.Name = "txtRentId";
            this.txtRentId.Size = new System.Drawing.Size(237, 27);
            this.txtRentId.TabIndex = 29;
            // 
            // cmbRentCustId
            // 
            this.cmbRentCustId.BackColor = System.Drawing.Color.Ivory;
            this.cmbRentCustId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRentCustId.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRentCustId.FormattingEnabled = true;
            this.cmbRentCustId.Items.AddRange(new object[] {
            ""});
            this.cmbRentCustId.Location = new System.Drawing.Point(173, 130);
            this.cmbRentCustId.Name = "cmbRentCustId";
            this.cmbRentCustId.Size = new System.Drawing.Size(237, 26);
            this.cmbRentCustId.TabIndex = 30;
            // 
            // cmbRentCarReg
            // 
            this.cmbRentCarReg.BackColor = System.Drawing.Color.Ivory;
            this.cmbRentCarReg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRentCarReg.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRentCarReg.FormattingEnabled = true;
            this.cmbRentCarReg.Items.AddRange(new object[] {
            ""});
            this.cmbRentCarReg.Location = new System.Drawing.Point(173, 175);
            this.cmbRentCarReg.Name = "cmbRentCarReg";
            this.cmbRentCarReg.Size = new System.Drawing.Size(237, 26);
            this.cmbRentCarReg.TabIndex = 31;
            this.cmbRentCarReg.SelectedIndexChanged += new System.EventHandler(this.cmbRentCarReg_SelectedIndexChanged);
            // 
            // dtpRentDate
            // 
            this.dtpRentDate.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpRentDate.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRentDate.Location = new System.Drawing.Point(173, 220);
            this.dtpRentDate.Name = "dtpRentDate";
            this.dtpRentDate.Size = new System.Drawing.Size(237, 22);
            this.dtpRentDate.TabIndex = 32;
            this.dtpRentDate.ValueChanged += new System.EventHandler(this.dtpRentDate_ValueChanged);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpDueDate.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDueDate.Location = new System.Drawing.Point(173, 265);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(237, 22);
            this.dtpDueDate.TabIndex = 33;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpReturnDate.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturnDate.Location = new System.Drawing.Point(173, 310);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(237, 22);
            this.dtpReturnDate.TabIndex = 34;
            this.dtpReturnDate.ValueChanged += new System.EventHandler(this.dtpReturnDate_ValueChanged);
            // 
            // txtBaseFee
            // 
            this.txtBaseFee.BackColor = System.Drawing.Color.Ivory;
            this.txtBaseFee.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaseFee.Location = new System.Drawing.Point(173, 355);
            this.txtBaseFee.Name = "txtBaseFee";
            this.txtBaseFee.ReadOnly = true;
            this.txtBaseFee.Size = new System.Drawing.Size(237, 27);
            this.txtBaseFee.TabIndex = 35;
            // 
            // txtLateFee
            // 
            this.txtLateFee.BackColor = System.Drawing.Color.Ivory;
            this.txtLateFee.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLateFee.Location = new System.Drawing.Point(173, 400);
            this.txtLateFee.Name = "txtLateFee";
            this.txtLateFee.Size = new System.Drawing.Size(237, 27);
            this.txtLateFee.TabIndex = 36;
            // 
            // cmbRentStatus
            // 
            this.cmbRentStatus.BackColor = System.Drawing.Color.Ivory;
            this.cmbRentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRentStatus.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRentStatus.FormattingEnabled = true;
            this.cmbRentStatus.Items.AddRange(new object[] {
            "Pending",
            "Active",
            "Returned",
            "Late",
            "Cancelled"});
            this.cmbRentStatus.Location = new System.Drawing.Point(173, 445);
            this.cmbRentStatus.Name = "cmbRentStatus";
            this.cmbRentStatus.Size = new System.Drawing.Size(237, 26);
            this.cmbRentStatus.TabIndex = 38;
            // 
            // btnAddRent
            // 
            this.btnAddRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnAddRent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRent.Location = new System.Drawing.Point(12, 491);
            this.btnAddRent.Name = "btnAddRent";
            this.btnAddRent.Size = new System.Drawing.Size(88, 47);
            this.btnAddRent.TabIndex = 39;
            this.btnAddRent.Text = "Add";
            this.btnAddRent.UseVisualStyleBackColor = false;
            this.btnAddRent.Click += new System.EventHandler(this.btnAddRent_Click);
            // 
            // btnUpdateRent
            // 
            this.btnUpdateRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnUpdateRent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRent.Location = new System.Drawing.Point(112, 491);
            this.btnUpdateRent.Name = "btnUpdateRent";
            this.btnUpdateRent.Size = new System.Drawing.Size(88, 47);
            this.btnUpdateRent.TabIndex = 40;
            this.btnUpdateRent.Text = "Update";
            this.btnUpdateRent.UseVisualStyleBackColor = false;
            this.btnUpdateRent.Click += new System.EventHandler(this.btnUpdateRent_Click);
            // 
            // btnClearRent
            // 
            this.btnClearRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnClearRent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearRent.Location = new System.Drawing.Point(312, 491);
            this.btnClearRent.Name = "btnClearRent";
            this.btnClearRent.Size = new System.Drawing.Size(88, 47);
            this.btnClearRent.TabIndex = 41;
            this.btnClearRent.Text = "Clear";
            this.btnClearRent.UseVisualStyleBackColor = false;
            this.btnClearRent.Click += new System.EventHandler(this.btnClearRent_Click);
            // 
            // dgvRentals
            // 
            this.dgvRentals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRentals.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.dgvRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RentId,
            this.CustId,
            this.RegNo,
            this.RentDate,
            this.DueDate,
            this.ReturnDate,
            this.BaseFee,
            this.LateFee,
            this.RentStatus,
            this.EmpId});
            this.dgvRentals.Location = new System.Drawing.Point(430, 136);
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.RowHeadersWidth = 51;
            this.dgvRentals.RowTemplate.Height = 24;
            this.dgvRentals.Size = new System.Drawing.Size(592, 402);
            this.dgvRentals.TabIndex = 42;
            this.dgvRentals.DoubleClick += new System.EventHandler(this.dgvRentals_DoubleClick);
            // 
            // lblRentSearch
            // 
            this.lblRentSearch.AutoSize = true;
            this.lblRentSearch.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentSearch.Location = new System.Drawing.Point(620, 96);
            this.lblRentSearch.Name = "lblRentSearch";
            this.lblRentSearch.Size = new System.Drawing.Size(71, 21);
            this.lblRentSearch.TabIndex = 43;
            this.lblRentSearch.Text = "Search";
            // 
            // txtRentSearch
            // 
            this.txtRentSearch.BackColor = System.Drawing.Color.Ivory;
            this.txtRentSearch.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRentSearch.Location = new System.Drawing.Point(716, 90);
            this.txtRentSearch.Name = "txtRentSearch";
            this.txtRentSearch.Size = new System.Drawing.Size(237, 27);
            this.txtRentSearch.TabIndex = 44;
            this.txtRentSearch.TextChanged += new System.EventHandler(this.txtRentSearch_TextChanged);
            // 
            // btnDltRent
            // 
            this.btnDltRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnDltRent.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDltRent.Location = new System.Drawing.Point(212, 491);
            this.btnDltRent.Name = "btnDltRent";
            this.btnDltRent.Size = new System.Drawing.Size(88, 47);
            this.btnDltRent.TabIndex = 45;
            this.btnDltRent.Text = "Delete";
            this.btnDltRent.UseVisualStyleBackColor = false;
            this.btnDltRent.Click += new System.EventHandler(this.btnDltRent_Click);
            // 
            // RentId
            // 
            this.RentId.DataPropertyName = "RentId";
            this.RentId.HeaderText = "RentId";
            this.RentId.MinimumWidth = 6;
            this.RentId.Name = "RentId";
            this.RentId.ReadOnly = true;
            // 
            // CustId
            // 
            this.CustId.DataPropertyName = "CustId";
            this.CustId.HeaderText = "CustId";
            this.CustId.MinimumWidth = 6;
            this.CustId.Name = "CustId";
            // 
            // RegNo
            // 
            this.RegNo.DataPropertyName = "RegNo";
            this.RegNo.HeaderText = "RegNo";
            this.RegNo.MinimumWidth = 6;
            this.RegNo.Name = "RegNo";
            // 
            // RentDate
            // 
            this.RentDate.DataPropertyName = "RentDate";
            this.RentDate.HeaderText = "RentDate";
            this.RentDate.MinimumWidth = 6;
            this.RentDate.Name = "RentDate";
            // 
            // DueDate
            // 
            this.DueDate.DataPropertyName = "DueDate";
            this.DueDate.HeaderText = "DueDate";
            this.DueDate.MinimumWidth = 6;
            this.DueDate.Name = "DueDate";
            // 
            // ReturnDate
            // 
            this.ReturnDate.DataPropertyName = "ReturnDate";
            this.ReturnDate.HeaderText = "ReturnDate";
            this.ReturnDate.MinimumWidth = 6;
            this.ReturnDate.Name = "ReturnDate";
            // 
            // BaseFee
            // 
            this.BaseFee.DataPropertyName = "BaseFee";
            this.BaseFee.HeaderText = "BaseFee";
            this.BaseFee.MinimumWidth = 6;
            this.BaseFee.Name = "BaseFee";
            // 
            // LateFee
            // 
            this.LateFee.DataPropertyName = "LateFee";
            this.LateFee.HeaderText = "LateFee";
            this.LateFee.MinimumWidth = 6;
            this.LateFee.Name = "LateFee";
            // 
            // RentStatus
            // 
            this.RentStatus.DataPropertyName = "RentStatus";
            this.RentStatus.HeaderText = "RentStatus";
            this.RentStatus.MinimumWidth = 6;
            this.RentStatus.Name = "RentStatus";
            // 
            // EmpId
            // 
            this.EmpId.DataPropertyName = "EmpId";
            this.EmpId.HeaderText = "StaffId";
            this.EmpId.MinimumWidth = 6;
            this.EmpId.Name = "EmpId";
            this.EmpId.ReadOnly = true;
            // 
            // Rentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1030, 565);
            this.Controls.Add(this.btnDltRent);
            this.Controls.Add(this.txtRentSearch);
            this.Controls.Add(this.lblRentSearch);
            this.Controls.Add(this.dgvRentals);
            this.Controls.Add(this.btnClearRent);
            this.Controls.Add(this.btnUpdateRent);
            this.Controls.Add(this.btnAddRent);
            this.Controls.Add(this.cmbRentStatus);
            this.Controls.Add(this.txtLateFee);
            this.Controls.Add(this.txtBaseFee);
            this.Controls.Add(this.dtpReturnDate);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.dtpRentDate);
            this.Controls.Add(this.cmbRentCarReg);
            this.Controls.Add(this.cmbRentCustId);
            this.Controls.Add(this.txtRentId);
            this.Controls.Add(this.lblRentStatus);
            this.Controls.Add(this.lblLateFee);
            this.Controls.Add(this.lblBaseFee);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblRentDate);
            this.Controls.Add(this.lblCarReg);
            this.Controls.Add(this.lblRCustId);
            this.Controls.Add(this.lblRentalId);
            this.Controls.Add(this.Rentpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rentals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rentals";
            this.Rentpanel.ResumeLayout(false);
            this.Rentpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Rentpanel;
        private System.Windows.Forms.Button btnRentBack;
        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.Label lblRentalId;
        private System.Windows.Forms.Label lblRCustId;
        private System.Windows.Forms.Label lblCarReg;
        private System.Windows.Forms.Label lblRentDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblBaseFee;
        private System.Windows.Forms.Label lblLateFee;
        private System.Windows.Forms.Label lblRentStatus;
        private System.Windows.Forms.TextBox txtRentId;
        private System.Windows.Forms.ComboBox cmbRentCustId;
        private System.Windows.Forms.ComboBox cmbRentCarReg;
        private System.Windows.Forms.DateTimePicker dtpRentDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.TextBox txtBaseFee;
        private System.Windows.Forms.TextBox txtLateFee;
        private System.Windows.Forms.ComboBox cmbRentStatus;
        private System.Windows.Forms.Button btnAddRent;
        private System.Windows.Forms.Button btnUpdateRent;
        private System.Windows.Forms.Button btnClearRent;
        private System.Windows.Forms.DataGridView dgvRentals;
        private System.Windows.Forms.Label lblRentSearch;
        private System.Windows.Forms.TextBox txtRentSearch;
        private System.Windows.Forms.Button btnDltRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn LateFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
    }
}