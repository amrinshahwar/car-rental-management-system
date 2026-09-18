namespace CarRentalManagementSystem
{
    partial class Customers
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
            this.Custpanel = new System.Windows.Forms.Panel();
            this.btnCustBack = new System.Windows.Forms.Button();
            this.lblCust = new System.Windows.Forms.Label();
            this.lblCustId = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustAddress = new System.Windows.Forms.Label();
            this.lblCustPhn = new System.Windows.Forms.Label();
            this.lblSearchCust = new System.Windows.Forms.Label();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.txtCustPhn = new System.Windows.Forms.TextBox();
            this.txtCustSearch = new System.Windows.Forms.TextBox();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.btnUpdateCust = new System.Windows.Forms.Button();
            this.btnDltCust = new System.Windows.Forms.Button();
            this.btnClearCust = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.CustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustAdd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustPhn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Custpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // Custpanel
            // 
            this.Custpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.Custpanel.Controls.Add(this.btnCustBack);
            this.Custpanel.Controls.Add(this.lblCust);
            this.Custpanel.Location = new System.Drawing.Point(0, 0);
            this.Custpanel.Name = "Custpanel";
            this.Custpanel.Size = new System.Drawing.Size(1046, 69);
            this.Custpanel.TabIndex = 3;
            // 
            // btnCustBack
            // 
            this.btnCustBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnCustBack.FlatAppearance.BorderSize = 0;
            this.btnCustBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustBack.Location = new System.Drawing.Point(960, 0);
            this.btnCustBack.Name = "btnCustBack";
            this.btnCustBack.Size = new System.Drawing.Size(82, 35);
            this.btnCustBack.TabIndex = 12;
            this.btnCustBack.Text = "Back";
            this.btnCustBack.UseVisualStyleBackColor = false;
            this.btnCustBack.Click += new System.EventHandler(this.btnCustBack_Click);
            // 
            // lblCust
            // 
            this.lblCust.AutoSize = true;
            this.lblCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCust.Font = new System.Drawing.Font("Ebrima", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCust.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCust.Location = new System.Drawing.Point(414, 9);
            this.lblCust.Name = "lblCust";
            this.lblCust.Size = new System.Drawing.Size(185, 45);
            this.lblCust.TabIndex = 0;
            this.lblCust.Text = "Customers";
            // 
            // lblCustId
            // 
            this.lblCustId.AutoSize = true;
            this.lblCustId.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustId.Location = new System.Drawing.Point(30, 115);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(29, 21);
            this.lblCustId.TabIndex = 14;
            this.lblCustId.Text = "Id";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(30, 195);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(62, 21);
            this.lblCustName.TabIndex = 15;
            this.lblCustName.Text = "Name";
            // 
            // lblCustAddress
            // 
            this.lblCustAddress.AutoSize = true;
            this.lblCustAddress.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustAddress.Location = new System.Drawing.Point(30, 275);
            this.lblCustAddress.Name = "lblCustAddress";
            this.lblCustAddress.Size = new System.Drawing.Size(83, 21);
            this.lblCustAddress.TabIndex = 16;
            this.lblCustAddress.Text = "Address";
            // 
            // lblCustPhn
            // 
            this.lblCustPhn.AutoSize = true;
            this.lblCustPhn.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustPhn.Location = new System.Drawing.Point(30, 355);
            this.lblCustPhn.Name = "lblCustPhn";
            this.lblCustPhn.Size = new System.Drawing.Size(65, 21);
            this.lblCustPhn.TabIndex = 17;
            this.lblCustPhn.Text = "Phone";
            // 
            // lblSearchCust
            // 
            this.lblSearchCust.AutoSize = true;
            this.lblSearchCust.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCust.Location = new System.Drawing.Point(630, 100);
            this.lblSearchCust.Name = "lblSearchCust";
            this.lblSearchCust.Size = new System.Drawing.Size(71, 21);
            this.lblSearchCust.TabIndex = 27;
            this.lblSearchCust.Text = "Search";
            // 
            // txtCustId
            // 
            this.txtCustId.BackColor = System.Drawing.Color.Ivory;
            this.txtCustId.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustId.Location = new System.Drawing.Point(168, 115);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(237, 27);
            this.txtCustId.TabIndex = 28;
            // 
            // txtCustName
            // 
            this.txtCustName.BackColor = System.Drawing.Color.Ivory;
            this.txtCustName.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(168, 195);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(237, 27);
            this.txtCustName.TabIndex = 29;
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.BackColor = System.Drawing.Color.Ivory;
            this.txtCustAddress.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustAddress.Location = new System.Drawing.Point(168, 275);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(237, 27);
            this.txtCustAddress.TabIndex = 30;
            // 
            // txtCustPhn
            // 
            this.txtCustPhn.BackColor = System.Drawing.Color.Ivory;
            this.txtCustPhn.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustPhn.Location = new System.Drawing.Point(168, 355);
            this.txtCustPhn.Name = "txtCustPhn";
            this.txtCustPhn.Size = new System.Drawing.Size(237, 27);
            this.txtCustPhn.TabIndex = 31;
            // 
            // txtCustSearch
            // 
            this.txtCustSearch.BackColor = System.Drawing.Color.Ivory;
            this.txtCustSearch.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustSearch.Location = new System.Drawing.Point(717, 94);
            this.txtCustSearch.Name = "txtCustSearch";
            this.txtCustSearch.Size = new System.Drawing.Size(237, 27);
            this.txtCustSearch.TabIndex = 32;
            this.txtCustSearch.TextChanged += new System.EventHandler(this.txtCustSearch_TextChanged);
            // 
            // btnAddCust
            // 
            this.btnAddCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnAddCust.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCust.Location = new System.Drawing.Point(35, 411);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(102, 59);
            this.btnAddCust.TabIndex = 33;
            this.btnAddCust.Text = "Add";
            this.btnAddCust.UseVisualStyleBackColor = false;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // btnUpdateCust
            // 
            this.btnUpdateCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnUpdateCust.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCust.Location = new System.Drawing.Point(185, 411);
            this.btnUpdateCust.Name = "btnUpdateCust";
            this.btnUpdateCust.Size = new System.Drawing.Size(102, 59);
            this.btnUpdateCust.TabIndex = 34;
            this.btnUpdateCust.Text = "Update";
            this.btnUpdateCust.UseVisualStyleBackColor = false;
            this.btnUpdateCust.Click += new System.EventHandler(this.btnUpdateCust_Click);
            // 
            // btnDltCust
            // 
            this.btnDltCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnDltCust.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDltCust.Location = new System.Drawing.Point(335, 411);
            this.btnDltCust.Name = "btnDltCust";
            this.btnDltCust.Size = new System.Drawing.Size(102, 59);
            this.btnDltCust.TabIndex = 35;
            this.btnDltCust.Text = "Delete";
            this.btnDltCust.UseVisualStyleBackColor = false;
            this.btnDltCust.Click += new System.EventHandler(this.btnDltCust_Click);
            // 
            // btnClearCust
            // 
            this.btnClearCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnClearCust.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCust.Location = new System.Drawing.Point(185, 494);
            this.btnClearCust.Name = "btnClearCust";
            this.btnClearCust.Size = new System.Drawing.Size(102, 59);
            this.btnClearCust.TabIndex = 37;
            this.btnClearCust.Text = "Clear";
            this.btnClearCust.UseVisualStyleBackColor = false;
            this.btnClearCust.Click += new System.EventHandler(this.btnClearCust_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustId,
            this.CustName,
            this.CustAdd,
            this.CustPhn,
            this.EmpId});
            this.dgvCustomer.Location = new System.Drawing.Point(491, 141);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(523, 399);
            this.dgvCustomer.TabIndex = 38;
            this.dgvCustomer.DoubleClick += new System.EventHandler(this.dgvCustomer_DoubleClick);
            // 
            // CustId
            // 
            this.CustId.DataPropertyName = "CustId";
            this.CustId.HeaderText = "CustId";
            this.CustId.MinimumWidth = 6;
            this.CustId.Name = "CustId";
            // 
            // CustName
            // 
            this.CustName.DataPropertyName = "CustName";
            this.CustName.HeaderText = "CustName";
            this.CustName.MinimumWidth = 6;
            this.CustName.Name = "CustName";
            // 
            // CustAdd
            // 
            this.CustAdd.DataPropertyName = "CustAdd";
            this.CustAdd.HeaderText = "CustAdd";
            this.CustAdd.MinimumWidth = 6;
            this.CustAdd.Name = "CustAdd";
            // 
            // CustPhn
            // 
            this.CustPhn.DataPropertyName = "CustPhn";
            this.CustPhn.HeaderText = "CustPhn";
            this.CustPhn.MinimumWidth = 6;
            this.CustPhn.Name = "CustPhn";
            // 
            // EmpId
            // 
            this.EmpId.DataPropertyName = "EmpId";
            this.EmpId.HeaderText = "StaffId";
            this.EmpId.MinimumWidth = 6;
            this.EmpId.Name = "EmpId";
            this.EmpId.ReadOnly = true;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1030, 565);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.btnClearCust);
            this.Controls.Add(this.btnDltCust);
            this.Controls.Add(this.btnUpdateCust);
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.txtCustSearch);
            this.Controls.Add(this.txtCustPhn);
            this.Controls.Add(this.txtCustAddress);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.txtCustId);
            this.Controls.Add(this.lblSearchCust);
            this.Controls.Add(this.lblCustPhn);
            this.Controls.Add(this.lblCustAddress);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblCustId);
            this.Controls.Add(this.Custpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Custpanel.ResumeLayout(false);
            this.Custpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Custpanel;
        private System.Windows.Forms.Button btnCustBack;
        private System.Windows.Forms.Label lblCust;
        private System.Windows.Forms.Label lblCustId;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCustAddress;
        private System.Windows.Forms.Label lblCustPhn;
        private System.Windows.Forms.Label lblSearchCust;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.TextBox txtCustPhn;
        private System.Windows.Forms.TextBox txtCustSearch;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Button btnUpdateCust;
        private System.Windows.Forms.Button btnDltCust;
        private System.Windows.Forms.Button btnClearCust;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustPhn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
    }
}