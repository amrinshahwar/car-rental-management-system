namespace CarRentalManagementSystem
{
    partial class Invoices
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
            this.Invoicespanel = new System.Windows.Forms.Panel();
            this.btnInvoicesBack = new System.Windows.Forms.Button();
            this.lblInvoices = new System.Windows.Forms.Label();
            this.lblInvId = new System.Windows.Forms.Label();
            this.lblInvRentId = new System.Windows.Forms.Label();
            this.lblInvAmount = new System.Windows.Forms.Label();
            this.lblInvStatus = new System.Windows.Forms.Label();
            this.txtInvId = new System.Windows.Forms.TextBox();
            this.cmbInvRentId = new System.Windows.Forms.ComboBox();
            this.txtInvAmount = new System.Windows.Forms.TextBox();
            this.cmbInvStatus = new System.Windows.Forms.ComboBox();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.lblSearchInv = new System.Windows.Forms.Label();
            this.txtSearchInv = new System.Windows.Forms.TextBox();
            this.btnAddInv = new System.Windows.Forms.Button();
            this.btnUpdateInv = new System.Windows.Forms.Button();
            this.btnDltInv = new System.Windows.Forms.Button();
            this.btnClearInv = new System.Windows.Forms.Button();
            this.lblInvDate = new System.Windows.Forms.Label();
            this.dtpInvDate = new System.Windows.Forms.DateTimePicker();
            this.InvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Invoicespanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // Invoicespanel
            // 
            this.Invoicespanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.Invoicespanel.Controls.Add(this.btnInvoicesBack);
            this.Invoicespanel.Controls.Add(this.lblInvoices);
            this.Invoicespanel.Location = new System.Drawing.Point(0, 0);
            this.Invoicespanel.Name = "Invoicespanel";
            this.Invoicespanel.Size = new System.Drawing.Size(1046, 69);
            this.Invoicespanel.TabIndex = 3;
            // 
            // btnInvoicesBack
            // 
            this.btnInvoicesBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnInvoicesBack.FlatAppearance.BorderSize = 0;
            this.btnInvoicesBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoicesBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoicesBack.Location = new System.Drawing.Point(960, 0);
            this.btnInvoicesBack.Name = "btnInvoicesBack";
            this.btnInvoicesBack.Size = new System.Drawing.Size(82, 35);
            this.btnInvoicesBack.TabIndex = 12;
            this.btnInvoicesBack.Text = "Back";
            this.btnInvoicesBack.UseVisualStyleBackColor = false;
            this.btnInvoicesBack.Click += new System.EventHandler(this.btnInvoicesBack_Click);
            // 
            // lblInvoices
            // 
            this.lblInvoices.AutoSize = true;
            this.lblInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInvoices.Font = new System.Drawing.Font("Ebrima", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoices.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblInvoices.Location = new System.Drawing.Point(406, 11);
            this.lblInvoices.Name = "lblInvoices";
            this.lblInvoices.Size = new System.Drawing.Size(146, 45);
            this.lblInvoices.TabIndex = 0;
            this.lblInvoices.Text = "Invoices";
            // 
            // lblInvId
            // 
            this.lblInvId.AutoSize = true;
            this.lblInvId.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvId.Location = new System.Drawing.Point(35, 100);
            this.lblInvId.Name = "lblInvId";
            this.lblInvId.Size = new System.Drawing.Size(103, 21);
            this.lblInvId.TabIndex = 16;
            this.lblInvId.Text = "Invoice Id";
            // 
            // lblInvRentId
            // 
            this.lblInvRentId.AutoSize = true;
            this.lblInvRentId.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvRentId.Location = new System.Drawing.Point(35, 165);
            this.lblInvRentId.Name = "lblInvRentId";
            this.lblInvRentId.Size = new System.Drawing.Size(94, 21);
            this.lblInvRentId.TabIndex = 18;
            this.lblInvRentId.Text = "Rental Id";
            // 
            // lblInvAmount
            // 
            this.lblInvAmount.AutoSize = true;
            this.lblInvAmount.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvAmount.Location = new System.Drawing.Point(35, 235);
            this.lblInvAmount.Name = "lblInvAmount";
            this.lblInvAmount.Size = new System.Drawing.Size(82, 21);
            this.lblInvAmount.TabIndex = 19;
            this.lblInvAmount.Text = "Amount";
            // 
            // lblInvStatus
            // 
            this.lblInvStatus.AutoSize = true;
            this.lblInvStatus.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvStatus.Location = new System.Drawing.Point(35, 370);
            this.lblInvStatus.Name = "lblInvStatus";
            this.lblInvStatus.Size = new System.Drawing.Size(66, 21);
            this.lblInvStatus.TabIndex = 20;
            this.lblInvStatus.Text = "Status";
            // 
            // txtInvId
            // 
            this.txtInvId.BackColor = System.Drawing.Color.Ivory;
            this.txtInvId.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvId.Location = new System.Drawing.Point(185, 100);
            this.txtInvId.Name = "txtInvId";
            this.txtInvId.Size = new System.Drawing.Size(237, 27);
            this.txtInvId.TabIndex = 22;
            // 
            // cmbInvRentId
            // 
            this.cmbInvRentId.BackColor = System.Drawing.Color.Ivory;
            this.cmbInvRentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInvRentId.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInvRentId.FormattingEnabled = true;
            this.cmbInvRentId.Items.AddRange(new object[] {
            ""});
            this.cmbInvRentId.Location = new System.Drawing.Point(185, 165);
            this.cmbInvRentId.Name = "cmbInvRentId";
            this.cmbInvRentId.Size = new System.Drawing.Size(237, 26);
            this.cmbInvRentId.TabIndex = 25;
            this.cmbInvRentId.SelectedIndexChanged += new System.EventHandler(this.CalculateTotal);
            // 
            // txtInvAmount
            // 
            this.txtInvAmount.BackColor = System.Drawing.Color.Ivory;
            this.txtInvAmount.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvAmount.Location = new System.Drawing.Point(185, 235);
            this.txtInvAmount.Name = "txtInvAmount";
            this.txtInvAmount.ReadOnly = true;
            this.txtInvAmount.Size = new System.Drawing.Size(237, 27);
            this.txtInvAmount.TabIndex = 27;
            this.txtInvAmount.TextChanged += new System.EventHandler(this.CalculateTotal);
            // 
            // cmbInvStatus
            // 
            this.cmbInvStatus.BackColor = System.Drawing.Color.Ivory;
            this.cmbInvStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInvStatus.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInvStatus.FormattingEnabled = true;
            this.cmbInvStatus.Items.AddRange(new object[] {
            "PAID",
            "UNPAID"});
            this.cmbInvStatus.Location = new System.Drawing.Point(185, 370);
            this.cmbInvStatus.Name = "cmbInvStatus";
            this.cmbInvStatus.Size = new System.Drawing.Size(237, 26);
            this.cmbInvStatus.TabIndex = 28;
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvId,
            this.RentId,
            this.Amount,
            this.InvDate,
            this.Status,
            this.EmpId});
            this.dgvInvoices.Location = new System.Drawing.Point(477, 141);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.RowHeadersWidth = 51;
            this.dgvInvoices.RowTemplate.Height = 24;
            this.dgvInvoices.Size = new System.Drawing.Size(537, 399);
            this.dgvInvoices.TabIndex = 31;
            this.dgvInvoices.DoubleClick += new System.EventHandler(this.dgvInvoices_DoubleClick);
            // 
            // lblSearchInv
            // 
            this.lblSearchInv.AutoSize = true;
            this.lblSearchInv.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchInv.Location = new System.Drawing.Point(630, 100);
            this.lblSearchInv.Name = "lblSearchInv";
            this.lblSearchInv.Size = new System.Drawing.Size(71, 21);
            this.lblSearchInv.TabIndex = 32;
            this.lblSearchInv.Text = "Search";
            // 
            // txtSearchInv
            // 
            this.txtSearchInv.BackColor = System.Drawing.Color.Ivory;
            this.txtSearchInv.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchInv.Location = new System.Drawing.Point(717, 94);
            this.txtSearchInv.Name = "txtSearchInv";
            this.txtSearchInv.Size = new System.Drawing.Size(237, 27);
            this.txtSearchInv.TabIndex = 33;
            this.txtSearchInv.TextChanged += new System.EventHandler(this.txtSearchInv_TextChanged);
            // 
            // btnAddInv
            // 
            this.btnAddInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnAddInv.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInv.Location = new System.Drawing.Point(40, 420);
            this.btnAddInv.Name = "btnAddInv";
            this.btnAddInv.Size = new System.Drawing.Size(93, 47);
            this.btnAddInv.TabIndex = 34;
            this.btnAddInv.Text = "Add";
            this.btnAddInv.UseVisualStyleBackColor = false;
            this.btnAddInv.Click += new System.EventHandler(this.btnAddInv_Click);
            // 
            // btnUpdateInv
            // 
            this.btnUpdateInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnUpdateInv.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInv.Location = new System.Drawing.Point(190, 420);
            this.btnUpdateInv.Name = "btnUpdateInv";
            this.btnUpdateInv.Size = new System.Drawing.Size(93, 47);
            this.btnUpdateInv.TabIndex = 36;
            this.btnUpdateInv.Text = "Update";
            this.btnUpdateInv.UseVisualStyleBackColor = false;
            this.btnUpdateInv.Click += new System.EventHandler(this.btnUpdateInv_Click);
            // 
            // btnDltInv
            // 
            this.btnDltInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnDltInv.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDltInv.Location = new System.Drawing.Point(340, 420);
            this.btnDltInv.Name = "btnDltInv";
            this.btnDltInv.Size = new System.Drawing.Size(93, 47);
            this.btnDltInv.TabIndex = 37;
            this.btnDltInv.Text = "Delete";
            this.btnDltInv.UseVisualStyleBackColor = false;
            this.btnDltInv.Click += new System.EventHandler(this.btnDltInv_Click);
            // 
            // btnClearInv
            // 
            this.btnClearInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnClearInv.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearInv.Location = new System.Drawing.Point(190, 493);
            this.btnClearInv.Name = "btnClearInv";
            this.btnClearInv.Size = new System.Drawing.Size(93, 47);
            this.btnClearInv.TabIndex = 38;
            this.btnClearInv.Text = "Clear";
            this.btnClearInv.UseVisualStyleBackColor = false;
            this.btnClearInv.Click += new System.EventHandler(this.btnClearInv_Click);
            // 
            // lblInvDate
            // 
            this.lblInvDate.AutoSize = true;
            this.lblInvDate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvDate.Location = new System.Drawing.Point(35, 305);
            this.lblInvDate.Name = "lblInvDate";
            this.lblInvDate.Size = new System.Drawing.Size(52, 21);
            this.lblInvDate.TabIndex = 39;
            this.lblInvDate.Text = "Date";
            // 
            // dtpInvDate
            // 
            this.dtpInvDate.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvDate.Location = new System.Drawing.Point(185, 305);
            this.dtpInvDate.Name = "dtpInvDate";
            this.dtpInvDate.Size = new System.Drawing.Size(237, 22);
            this.dtpInvDate.TabIndex = 40;
            // 
            // InvId
            // 
            this.InvId.DataPropertyName = "InvId";
            this.InvId.HeaderText = "InvId";
            this.InvId.MinimumWidth = 6;
            this.InvId.Name = "InvId";
            this.InvId.ReadOnly = true;
            // 
            // RentId
            // 
            this.RentId.DataPropertyName = "RentId";
            this.RentId.HeaderText = "RentId";
            this.RentId.MinimumWidth = 6;
            this.RentId.Name = "RentId";
            this.RentId.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // InvDate
            // 
            this.InvDate.DataPropertyName = "InvDate";
            this.InvDate.HeaderText = "InvDate";
            this.InvDate.MinimumWidth = 6;
            this.InvDate.Name = "InvDate";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            // 
            // EmpId
            // 
            this.EmpId.DataPropertyName = "EmpId";
            this.EmpId.HeaderText = "AccId";
            this.EmpId.MinimumWidth = 6;
            this.EmpId.Name = "EmpId";
            this.EmpId.ReadOnly = true;
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1030, 565);
            this.Controls.Add(this.dtpInvDate);
            this.Controls.Add(this.lblInvDate);
            this.Controls.Add(this.btnClearInv);
            this.Controls.Add(this.btnDltInv);
            this.Controls.Add(this.btnUpdateInv);
            this.Controls.Add(this.btnAddInv);
            this.Controls.Add(this.txtSearchInv);
            this.Controls.Add(this.lblSearchInv);
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.cmbInvStatus);
            this.Controls.Add(this.txtInvAmount);
            this.Controls.Add(this.cmbInvRentId);
            this.Controls.Add(this.txtInvId);
            this.Controls.Add(this.lblInvStatus);
            this.Controls.Add(this.lblInvAmount);
            this.Controls.Add(this.lblInvRentId);
            this.Controls.Add(this.lblInvId);
            this.Controls.Add(this.Invoicespanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Invoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoices";
            this.Invoicespanel.ResumeLayout(false);
            this.Invoicespanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Invoicespanel;
        private System.Windows.Forms.Button btnInvoicesBack;
        private System.Windows.Forms.Label lblInvoices;
        private System.Windows.Forms.Label lblInvId;
        private System.Windows.Forms.Label lblInvRentId;
        private System.Windows.Forms.Label lblInvAmount;
        private System.Windows.Forms.Label lblInvStatus;
        private System.Windows.Forms.TextBox txtInvId;
        private System.Windows.Forms.ComboBox cmbInvRentId;
        private System.Windows.Forms.TextBox txtInvAmount;
        private System.Windows.Forms.ComboBox cmbInvStatus;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Label lblSearchInv;
        private System.Windows.Forms.TextBox txtSearchInv;
        private System.Windows.Forms.Button btnAddInv;
        private System.Windows.Forms.Button btnUpdateInv;
        private System.Windows.Forms.Button btnDltInv;
        private System.Windows.Forms.Button btnClearInv;
        private System.Windows.Forms.Label lblInvDate;
        private System.Windows.Forms.DateTimePicker dtpInvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
    }
}