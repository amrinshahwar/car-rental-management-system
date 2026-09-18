namespace CarRentalManagementSystem
{
    partial class Payments
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
            this.Paymentspanel = new System.Windows.Forms.Panel();
            this.btnPaymentsBack = new System.Windows.Forms.Button();
            this.lblPayments = new System.Windows.Forms.Label();
            this.lblPId = new System.Windows.Forms.Label();
            this.lblPInvId = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtPId = new System.Windows.Forms.TextBox();
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.btnAddPayments = new System.Windows.Forms.Button();
            this.btnDltPayments = new System.Windows.Forms.Button();
            this.btnClearPayments = new System.Windows.Forms.Button();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.lblSearchPay = new System.Windows.Forms.Label();
            this.txtSearchPay = new System.Windows.Forms.TextBox();
            this.cmbPInvId = new System.Windows.Forms.ComboBox();
            this.txtPAmount = new System.Windows.Forms.TextBox();
            this.dtpPayDate = new System.Windows.Forms.DateTimePicker();
            this.PayId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Method = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paymentspanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // Paymentspanel
            // 
            this.Paymentspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.Paymentspanel.Controls.Add(this.btnPaymentsBack);
            this.Paymentspanel.Controls.Add(this.lblPayments);
            this.Paymentspanel.Location = new System.Drawing.Point(0, 0);
            this.Paymentspanel.Name = "Paymentspanel";
            this.Paymentspanel.Size = new System.Drawing.Size(1046, 69);
            this.Paymentspanel.TabIndex = 2;
            // 
            // btnPaymentsBack
            // 
            this.btnPaymentsBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnPaymentsBack.FlatAppearance.BorderSize = 0;
            this.btnPaymentsBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentsBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentsBack.Location = new System.Drawing.Point(960, 0);
            this.btnPaymentsBack.Name = "btnPaymentsBack";
            this.btnPaymentsBack.Size = new System.Drawing.Size(82, 35);
            this.btnPaymentsBack.TabIndex = 12;
            this.btnPaymentsBack.Text = "Back";
            this.btnPaymentsBack.UseVisualStyleBackColor = false;
            this.btnPaymentsBack.Click += new System.EventHandler(this.btnPaymentsBack_Click);
            // 
            // lblPayments
            // 
            this.lblPayments.AutoSize = true;
            this.lblPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPayments.Font = new System.Drawing.Font("Ebrima", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayments.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPayments.Location = new System.Drawing.Point(406, 11);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(172, 45);
            this.lblPayments.TabIndex = 0;
            this.lblPayments.Text = "Payments";
            // 
            // lblPId
            // 
            this.lblPId.AutoSize = true;
            this.lblPId.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPId.Location = new System.Drawing.Point(35, 100);
            this.lblPId.Name = "lblPId";
            this.lblPId.Size = new System.Drawing.Size(113, 21);
            this.lblPId.TabIndex = 14;
            this.lblPId.Text = "Payment Id";
            // 
            // lblPInvId
            // 
            this.lblPInvId.AutoSize = true;
            this.lblPInvId.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPInvId.Location = new System.Drawing.Point(35, 165);
            this.lblPInvId.Name = "lblPInvId";
            this.lblPInvId.Size = new System.Drawing.Size(103, 21);
            this.lblPInvId.TabIndex = 15;
            this.lblPInvId.Text = "Invoice Id";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(35, 235);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(82, 21);
            this.lblAmount.TabIndex = 17;
            this.lblAmount.Text = "Amount";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMethod.Location = new System.Drawing.Point(35, 305);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(79, 21);
            this.lblMethod.TabIndex = 18;
            this.lblMethod.Text = "Method";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(35, 375);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 21);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Date";
            // 
            // txtPId
            // 
            this.txtPId.BackColor = System.Drawing.Color.Ivory;
            this.txtPId.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPId.Location = new System.Drawing.Point(185, 100);
            this.txtPId.Name = "txtPId";
            this.txtPId.ReadOnly = true;
            this.txtPId.Size = new System.Drawing.Size(237, 27);
            this.txtPId.TabIndex = 20;
            // 
            // cmbMethod
            // 
            this.cmbMethod.BackColor = System.Drawing.Color.Ivory;
            this.cmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMethod.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Items.AddRange(new object[] {
            "CASH",
            "CARD",
            "BKASH"});
            this.cmbMethod.Location = new System.Drawing.Point(185, 305);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(237, 26);
            this.cmbMethod.TabIndex = 24;
            // 
            // btnAddPayments
            // 
            this.btnAddPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnAddPayments.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPayments.Location = new System.Drawing.Point(40, 462);
            this.btnAddPayments.Name = "btnAddPayments";
            this.btnAddPayments.Size = new System.Drawing.Size(102, 50);
            this.btnAddPayments.TabIndex = 26;
            this.btnAddPayments.Text = "Add";
            this.btnAddPayments.UseVisualStyleBackColor = false;
            this.btnAddPayments.Click += new System.EventHandler(this.btnAddPayments_Click);
            // 
            // btnDltPayments
            // 
            this.btnDltPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnDltPayments.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDltPayments.Location = new System.Drawing.Point(185, 462);
            this.btnDltPayments.Name = "btnDltPayments";
            this.btnDltPayments.Size = new System.Drawing.Size(102, 50);
            this.btnDltPayments.TabIndex = 28;
            this.btnDltPayments.Text = "Delete";
            this.btnDltPayments.UseVisualStyleBackColor = false;
            this.btnDltPayments.Click += new System.EventHandler(this.btnDltPayments_Click);
            // 
            // btnClearPayments
            // 
            this.btnClearPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnClearPayments.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPayments.Location = new System.Drawing.Point(330, 462);
            this.btnClearPayments.Name = "btnClearPayments";
            this.btnClearPayments.Size = new System.Drawing.Size(102, 50);
            this.btnClearPayments.TabIndex = 29;
            this.btnClearPayments.Text = "Clear";
            this.btnClearPayments.UseVisualStyleBackColor = false;
            this.btnClearPayments.Click += new System.EventHandler(this.btnClearPayments_Click);
            // 
            // dgvPayments
            // 
            this.dgvPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PayId,
            this.InvId,
            this.Amount,
            this.Method,
            this.PayDate,
            this.EmpId});
            this.dgvPayments.Location = new System.Drawing.Point(477, 141);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.RowHeadersWidth = 51;
            this.dgvPayments.RowTemplate.Height = 24;
            this.dgvPayments.Size = new System.Drawing.Size(537, 399);
            this.dgvPayments.TabIndex = 30;
            this.dgvPayments.DoubleClick += new System.EventHandler(this.dgvPayments_DoubleClick);
            // 
            // lblSearchPay
            // 
            this.lblSearchPay.AutoSize = true;
            this.lblSearchPay.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchPay.Location = new System.Drawing.Point(630, 100);
            this.lblSearchPay.Name = "lblSearchPay";
            this.lblSearchPay.Size = new System.Drawing.Size(71, 21);
            this.lblSearchPay.TabIndex = 33;
            this.lblSearchPay.Text = "Search";
            // 
            // txtSearchPay
            // 
            this.txtSearchPay.BackColor = System.Drawing.Color.Ivory;
            this.txtSearchPay.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPay.Location = new System.Drawing.Point(717, 94);
            this.txtSearchPay.Name = "txtSearchPay";
            this.txtSearchPay.ReadOnly = true;
            this.txtSearchPay.Size = new System.Drawing.Size(237, 27);
            this.txtSearchPay.TabIndex = 34;
            this.txtSearchPay.TextChanged += new System.EventHandler(this.txtSearchPay_TextChanged);
            // 
            // cmbPInvId
            // 
            this.cmbPInvId.BackColor = System.Drawing.Color.Ivory;
            this.cmbPInvId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPInvId.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPInvId.FormattingEnabled = true;
            this.cmbPInvId.Location = new System.Drawing.Point(185, 165);
            this.cmbPInvId.Name = "cmbPInvId";
            this.cmbPInvId.Size = new System.Drawing.Size(237, 26);
            this.cmbPInvId.TabIndex = 35;
            this.cmbPInvId.SelectedIndexChanged += new System.EventHandler(this.cmbPInvId_SelectedIndexChanged);
            // 
            // txtPAmount
            // 
            this.txtPAmount.BackColor = System.Drawing.Color.Ivory;
            this.txtPAmount.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPAmount.Location = new System.Drawing.Point(185, 235);
            this.txtPAmount.Name = "txtPAmount";
            this.txtPAmount.ReadOnly = true;
            this.txtPAmount.Size = new System.Drawing.Size(237, 27);
            this.txtPAmount.TabIndex = 36;
            // 
            // dtpPayDate
            // 
            this.dtpPayDate.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPayDate.Location = new System.Drawing.Point(185, 375);
            this.dtpPayDate.Name = "dtpPayDate";
            this.dtpPayDate.Size = new System.Drawing.Size(237, 22);
            this.dtpPayDate.TabIndex = 41;
            // 
            // PayId
            // 
            this.PayId.DataPropertyName = "PayId";
            this.PayId.HeaderText = "PayId";
            this.PayId.MinimumWidth = 6;
            this.PayId.Name = "PayId";
            // 
            // InvId
            // 
            this.InvId.DataPropertyName = "InvId";
            this.InvId.HeaderText = "InvId";
            this.InvId.MinimumWidth = 6;
            this.InvId.Name = "InvId";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            // 
            // Method
            // 
            this.Method.DataPropertyName = "Method";
            this.Method.HeaderText = "Method";
            this.Method.MinimumWidth = 6;
            this.Method.Name = "Method";
            // 
            // PayDate
            // 
            this.PayDate.DataPropertyName = "PayDate";
            this.PayDate.HeaderText = "PayDate";
            this.PayDate.MinimumWidth = 6;
            this.PayDate.Name = "PayDate";
            // 
            // EmpId
            // 
            this.EmpId.DataPropertyName = "EmpId";
            this.EmpId.HeaderText = "AccId";
            this.EmpId.MinimumWidth = 6;
            this.EmpId.Name = "EmpId";
            this.EmpId.ReadOnly = true;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1030, 565);
            this.Controls.Add(this.dtpPayDate);
            this.Controls.Add(this.txtPAmount);
            this.Controls.Add(this.cmbPInvId);
            this.Controls.Add(this.txtSearchPay);
            this.Controls.Add(this.lblSearchPay);
            this.Controls.Add(this.lblPInvId);
            this.Controls.Add(this.dgvPayments);
            this.Controls.Add(this.btnClearPayments);
            this.Controls.Add(this.btnDltPayments);
            this.Controls.Add(this.btnAddPayments);
            this.Controls.Add(this.cmbMethod);
            this.Controls.Add(this.txtPId);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblPId);
            this.Controls.Add(this.Paymentspanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payments";
            this.Paymentspanel.ResumeLayout(false);
            this.Paymentspanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Paymentspanel;
        private System.Windows.Forms.Button btnPaymentsBack;
        private System.Windows.Forms.Label lblPayments;
        private System.Windows.Forms.Label lblPId;
        private System.Windows.Forms.Label lblPInvId;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtPId;
        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.Button btnAddPayments;
        private System.Windows.Forms.Button btnDltPayments;
        private System.Windows.Forms.Button btnClearPayments;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Label lblSearchPay;
        private System.Windows.Forms.TextBox txtSearchPay;
        private System.Windows.Forms.ComboBox cmbPInvId;
        private System.Windows.Forms.TextBox txtPAmount;
        private System.Windows.Forms.DateTimePicker dtpPayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayId;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Method;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
    }
}