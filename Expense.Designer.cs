namespace CarRentalManagementSystem
{
    partial class Expense
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
            this.Expensepanel = new System.Windows.Forms.Panel();
            this.btnExpBack = new System.Windows.Forms.Button();
            this.lblExpense = new System.Windows.Forms.Label();
            this.lblExpMaintainId = new System.Windows.Forms.Label();
            this.lblExpCarReg = new System.Windows.Forms.Label();
            this.lblExpCarModel = new System.Windows.Forms.Label();
            this.lblExpMaintainType = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lblExpCost = new System.Windows.Forms.Label();
            this.cmbExpCarReg = new System.Windows.Forms.ComboBox();
            this.cmbExpCarModel = new System.Windows.Forms.ComboBox();
            this.cmbExpMaintenanceType = new System.Windows.Forms.ComboBox();
            this.dtpExpDate = new System.Windows.Forms.DateTimePicker();
            this.txtExpCost = new System.Windows.Forms.TextBox();
            this.btnAddExp = new System.Windows.Forms.Button();
            this.btnUpdateExp = new System.Windows.Forms.Button();
            this.btnDltExp = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvExp = new System.Windows.Forms.DataGridView();
            this.lblExpSearch = new System.Windows.Forms.Label();
            this.txtExpSearch = new System.Windows.Forms.TextBox();
            this.cmbMId = new System.Windows.Forms.ComboBox();
            this.lblExpId = new System.Windows.Forms.Label();
            this.txtExpId = new System.Windows.Forms.TextBox();
            this.ExpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expensepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExp)).BeginInit();
            this.SuspendLayout();
            // 
            // Expensepanel
            // 
            this.Expensepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.Expensepanel.Controls.Add(this.btnExpBack);
            this.Expensepanel.Controls.Add(this.lblExpense);
            this.Expensepanel.Location = new System.Drawing.Point(0, 0);
            this.Expensepanel.Name = "Expensepanel";
            this.Expensepanel.Size = new System.Drawing.Size(1046, 69);
            this.Expensepanel.TabIndex = 6;
            // 
            // btnExpBack
            // 
            this.btnExpBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnExpBack.FlatAppearance.BorderSize = 0;
            this.btnExpBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpBack.Location = new System.Drawing.Point(960, 0);
            this.btnExpBack.Name = "btnExpBack";
            this.btnExpBack.Size = new System.Drawing.Size(82, 35);
            this.btnExpBack.TabIndex = 12;
            this.btnExpBack.Text = "Back";
            this.btnExpBack.UseVisualStyleBackColor = false;
            this.btnExpBack.Click += new System.EventHandler(this.btnExpBack_Click);
            // 
            // lblExpense
            // 
            this.lblExpense.AutoSize = true;
            this.lblExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblExpense.Font = new System.Drawing.Font("Ebrima", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpense.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblExpense.Location = new System.Drawing.Point(450, 9);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(147, 45);
            this.lblExpense.TabIndex = 0;
            this.lblExpense.Text = "Expense";
            // 
            // lblExpMaintainId
            // 
            this.lblExpMaintainId.AutoSize = true;
            this.lblExpMaintainId.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpMaintainId.Location = new System.Drawing.Point(35, 140);
            this.lblExpMaintainId.Name = "lblExpMaintainId";
            this.lblExpMaintainId.Size = new System.Drawing.Size(151, 21);
            this.lblExpMaintainId.TabIndex = 17;
            this.lblExpMaintainId.Text = "Maintenance Id";
            // 
            // lblExpCarReg
            // 
            this.lblExpCarReg.AutoSize = true;
            this.lblExpCarReg.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpCarReg.Location = new System.Drawing.Point(35, 190);
            this.lblExpCarReg.Name = "lblExpCarReg";
            this.lblExpCarReg.Size = new System.Drawing.Size(160, 21);
            this.lblExpCarReg.TabIndex = 19;
            this.lblExpCarReg.Text = "Car Registration";
            // 
            // lblExpCarModel
            // 
            this.lblExpCarModel.AutoSize = true;
            this.lblExpCarModel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpCarModel.Location = new System.Drawing.Point(35, 240);
            this.lblExpCarModel.Name = "lblExpCarModel";
            this.lblExpCarModel.Size = new System.Drawing.Size(106, 21);
            this.lblExpCarModel.TabIndex = 20;
            this.lblExpCarModel.Text = "Car Model";
            // 
            // lblExpMaintainType
            // 
            this.lblExpMaintainType.AutoSize = true;
            this.lblExpMaintainType.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpMaintainType.Location = new System.Drawing.Point(35, 290);
            this.lblExpMaintainType.Name = "lblExpMaintainType";
            this.lblExpMaintainType.Size = new System.Drawing.Size(177, 21);
            this.lblExpMaintainType.TabIndex = 21;
            this.lblExpMaintainType.Text = "Maintenance Type";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpDate.Location = new System.Drawing.Point(35, 340);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(52, 21);
            this.lblExpDate.TabIndex = 23;
            this.lblExpDate.Text = "Date";
            // 
            // lblExpCost
            // 
            this.lblExpCost.AutoSize = true;
            this.lblExpCost.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpCost.Location = new System.Drawing.Point(35, 390);
            this.lblExpCost.Name = "lblExpCost";
            this.lblExpCost.Size = new System.Drawing.Size(51, 21);
            this.lblExpCost.TabIndex = 24;
            this.lblExpCost.Text = "Cost";
            // 
            // cmbExpCarReg
            // 
            this.cmbExpCarReg.BackColor = System.Drawing.Color.Ivory;
            this.cmbExpCarReg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpCarReg.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpCarReg.FormattingEnabled = true;
            this.cmbExpCarReg.Items.AddRange(new object[] {
            ""});
            this.cmbExpCarReg.Location = new System.Drawing.Point(234, 190);
            this.cmbExpCarReg.Name = "cmbExpCarReg";
            this.cmbExpCarReg.Size = new System.Drawing.Size(237, 26);
            this.cmbExpCarReg.TabIndex = 32;
            // 
            // cmbExpCarModel
            // 
            this.cmbExpCarModel.BackColor = System.Drawing.Color.Ivory;
            this.cmbExpCarModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpCarModel.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpCarModel.FormattingEnabled = true;
            this.cmbExpCarModel.Items.AddRange(new object[] {
            ""});
            this.cmbExpCarModel.Location = new System.Drawing.Point(234, 240);
            this.cmbExpCarModel.Name = "cmbExpCarModel";
            this.cmbExpCarModel.Size = new System.Drawing.Size(237, 26);
            this.cmbExpCarModel.TabIndex = 33;
            // 
            // cmbExpMaintenanceType
            // 
            this.cmbExpMaintenanceType.BackColor = System.Drawing.Color.Ivory;
            this.cmbExpMaintenanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpMaintenanceType.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpMaintenanceType.FormattingEnabled = true;
            this.cmbExpMaintenanceType.Items.AddRange(new object[] {
            "Engine Repair",
            "Dent Repair",
            "Tire Replacement",
            "Fuel Change",
            "General "});
            this.cmbExpMaintenanceType.Location = new System.Drawing.Point(234, 290);
            this.cmbExpMaintenanceType.Name = "cmbExpMaintenanceType";
            this.cmbExpMaintenanceType.Size = new System.Drawing.Size(237, 26);
            this.cmbExpMaintenanceType.TabIndex = 34;
            // 
            // dtpExpDate
            // 
            this.dtpExpDate.Font = new System.Drawing.Font("Mongolian Baiti", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpDate.Location = new System.Drawing.Point(234, 340);
            this.dtpExpDate.Name = "dtpExpDate";
            this.dtpExpDate.Size = new System.Drawing.Size(237, 22);
            this.dtpExpDate.TabIndex = 36;
            // 
            // txtExpCost
            // 
            this.txtExpCost.BackColor = System.Drawing.Color.Ivory;
            this.txtExpCost.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpCost.Location = new System.Drawing.Point(234, 390);
            this.txtExpCost.Name = "txtExpCost";
            this.txtExpCost.Size = new System.Drawing.Size(237, 27);
            this.txtExpCost.TabIndex = 37;
            // 
            // btnAddExp
            // 
            this.btnAddExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnAddExp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExp.Location = new System.Drawing.Point(38, 443);
            this.btnAddExp.Name = "btnAddExp";
            this.btnAddExp.Size = new System.Drawing.Size(102, 50);
            this.btnAddExp.TabIndex = 41;
            this.btnAddExp.Text = "Add";
            this.btnAddExp.UseVisualStyleBackColor = false;
            this.btnAddExp.Click += new System.EventHandler(this.btnAddExp_Click);
            // 
            // btnUpdateExp
            // 
            this.btnUpdateExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnUpdateExp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateExp.Location = new System.Drawing.Point(190, 443);
            this.btnUpdateExp.Name = "btnUpdateExp";
            this.btnUpdateExp.Size = new System.Drawing.Size(102, 50);
            this.btnUpdateExp.TabIndex = 42;
            this.btnUpdateExp.Text = "Update";
            this.btnUpdateExp.UseVisualStyleBackColor = false;
            this.btnUpdateExp.Click += new System.EventHandler(this.btnUpdateExp_Click);
            // 
            // btnDltExp
            // 
            this.btnDltExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnDltExp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDltExp.Location = new System.Drawing.Point(344, 443);
            this.btnDltExp.Name = "btnDltExp";
            this.btnDltExp.Size = new System.Drawing.Size(102, 50);
            this.btnDltExp.TabIndex = 43;
            this.btnDltExp.Text = "Delete";
            this.btnDltExp.UseVisualStyleBackColor = false;
            this.btnDltExp.Click += new System.EventHandler(this.btnDltExp_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(190, 503);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 50);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvExp
            // 
            this.dgvExp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.dgvExp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExpId,
            this.MId,
            this.RegNo,
            this.Model,
            this.MType,
            this.Date,
            this.Cost,
            this.EmpId});
            this.dgvExp.Location = new System.Drawing.Point(490, 141);
            this.dgvExp.Name = "dgvExp";
            this.dgvExp.RowHeadersWidth = 51;
            this.dgvExp.RowTemplate.Height = 24;
            this.dgvExp.Size = new System.Drawing.Size(524, 399);
            this.dgvExp.TabIndex = 45;
            this.dgvExp.DoubleClick += new System.EventHandler(this.dgvExpense_DoubleClick);
            // 
            // lblExpSearch
            // 
            this.lblExpSearch.AutoSize = true;
            this.lblExpSearch.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpSearch.Location = new System.Drawing.Point(630, 100);
            this.lblExpSearch.Name = "lblExpSearch";
            this.lblExpSearch.Size = new System.Drawing.Size(71, 21);
            this.lblExpSearch.TabIndex = 46;
            this.lblExpSearch.Text = "Search";
            // 
            // txtExpSearch
            // 
            this.txtExpSearch.BackColor = System.Drawing.Color.Ivory;
            this.txtExpSearch.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpSearch.Location = new System.Drawing.Point(717, 94);
            this.txtExpSearch.Name = "txtExpSearch";
            this.txtExpSearch.Size = new System.Drawing.Size(237, 27);
            this.txtExpSearch.TabIndex = 47;
            this.txtExpSearch.TextChanged += new System.EventHandler(this.txtExpSearch_TextChanged);
            // 
            // cmbMId
            // 
            this.cmbMId.BackColor = System.Drawing.Color.Ivory;
            this.cmbMId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMId.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMId.FormattingEnabled = true;
            this.cmbMId.Items.AddRange(new object[] {
            ""});
            this.cmbMId.Location = new System.Drawing.Point(234, 140);
            this.cmbMId.Name = "cmbMId";
            this.cmbMId.Size = new System.Drawing.Size(237, 26);
            this.cmbMId.TabIndex = 48;
            this.cmbMId.SelectedIndexChanged += new System.EventHandler(this.cmbMId_SelectedIndexChanged);
            // 
            // lblExpId
            // 
            this.lblExpId.AutoSize = true;
            this.lblExpId.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpId.Location = new System.Drawing.Point(36, 90);
            this.lblExpId.Name = "lblExpId";
            this.lblExpId.Size = new System.Drawing.Size(110, 21);
            this.lblExpId.TabIndex = 49;
            this.lblExpId.Text = "Expense Id";
            // 
            // txtExpId
            // 
            this.txtExpId.BackColor = System.Drawing.Color.Ivory;
            this.txtExpId.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpId.Location = new System.Drawing.Point(234, 90);
            this.txtExpId.Name = "txtExpId";
            this.txtExpId.Size = new System.Drawing.Size(237, 27);
            this.txtExpId.TabIndex = 50;
            // 
            // ExpId
            // 
            this.ExpId.DataPropertyName = "ExpId";
            this.ExpId.HeaderText = "ExpId";
            this.ExpId.MinimumWidth = 6;
            this.ExpId.Name = "ExpId";
            this.ExpId.ReadOnly = true;
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
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            // 
            // EmpId
            // 
            this.EmpId.DataPropertyName = "EmpId";
            this.EmpId.HeaderText = "AccId";
            this.EmpId.MinimumWidth = 6;
            this.EmpId.Name = "EmpId";
            this.EmpId.ReadOnly = true;
            // 
            // Expense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1030, 565);
            this.Controls.Add(this.txtExpId);
            this.Controls.Add(this.lblExpId);
            this.Controls.Add(this.cmbMId);
            this.Controls.Add(this.txtExpSearch);
            this.Controls.Add(this.lblExpSearch);
            this.Controls.Add(this.dgvExp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDltExp);
            this.Controls.Add(this.btnUpdateExp);
            this.Controls.Add(this.btnAddExp);
            this.Controls.Add(this.txtExpCost);
            this.Controls.Add(this.dtpExpDate);
            this.Controls.Add(this.cmbExpMaintenanceType);
            this.Controls.Add(this.cmbExpCarModel);
            this.Controls.Add(this.cmbExpCarReg);
            this.Controls.Add(this.lblExpCost);
            this.Controls.Add(this.lblExpDate);
            this.Controls.Add(this.lblExpMaintainType);
            this.Controls.Add(this.lblExpCarModel);
            this.Controls.Add(this.lblExpCarReg);
            this.Controls.Add(this.lblExpMaintainId);
            this.Controls.Add(this.Expensepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Expense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense";
            this.Expensepanel.ResumeLayout(false);
            this.Expensepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Expensepanel;
        private System.Windows.Forms.Button btnExpBack;
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.Label lblExpMaintainId;
        private System.Windows.Forms.Label lblExpCarReg;
        private System.Windows.Forms.Label lblExpCarModel;
        private System.Windows.Forms.Label lblExpMaintainType;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.Label lblExpCost;
        private System.Windows.Forms.ComboBox cmbExpCarReg;
        private System.Windows.Forms.ComboBox cmbExpCarModel;
        private System.Windows.Forms.ComboBox cmbExpMaintenanceType;
        private System.Windows.Forms.DateTimePicker dtpExpDate;
        private System.Windows.Forms.TextBox txtExpCost;
        private System.Windows.Forms.Button btnAddExp;
        private System.Windows.Forms.Button btnUpdateExp;
        private System.Windows.Forms.Button btnDltExp;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvExp;
        private System.Windows.Forms.Label lblExpSearch;
        private System.Windows.Forms.TextBox txtExpSearch;
        private System.Windows.Forms.ComboBox cmbMId;
        private System.Windows.Forms.Label lblExpId;
        private System.Windows.Forms.TextBox txtExpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn MType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpId;
    }
}