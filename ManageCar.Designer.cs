namespace CarRentalManagementSystem
{
    partial class ManageCar
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
            this.ManageCarpanel = new System.Windows.Forms.Panel();
            this.btnMCarLogout = new System.Windows.Forms.Button();
            this.lblManageCar = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbAvailable = new System.Windows.Forms.ComboBox();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnSaveCar = new System.Windows.Forms.Button();
            this.btnDltCar = new System.Windows.Forms.Button();
            this.btnClearCar = new System.Windows.Forms.Button();
            this.dgvCar = new System.Windows.Forms.DataGridView();
            this.RegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearchCar = new System.Windows.Forms.Label();
            this.txtSearchCar = new System.Windows.Forms.TextBox();
            this.ManageCarpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageCarpanel
            // 
            this.ManageCarpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.ManageCarpanel.Controls.Add(this.btnMCarLogout);
            this.ManageCarpanel.Controls.Add(this.lblManageCar);
            this.ManageCarpanel.Location = new System.Drawing.Point(-1, -2);
            this.ManageCarpanel.Name = "ManageCarpanel";
            this.ManageCarpanel.Size = new System.Drawing.Size(1046, 69);
            this.ManageCarpanel.TabIndex = 0;
            // 
            // btnMCarLogout
            // 
            this.btnMCarLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnMCarLogout.FlatAppearance.BorderSize = 0;
            this.btnMCarLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMCarLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMCarLogout.Location = new System.Drawing.Point(960, 0);
            this.btnMCarLogout.Name = "btnMCarLogout";
            this.btnMCarLogout.Size = new System.Drawing.Size(82, 35);
            this.btnMCarLogout.TabIndex = 12;
            this.btnMCarLogout.Text = "Back";
            this.btnMCarLogout.UseVisualStyleBackColor = false;
            this.btnMCarLogout.Click += new System.EventHandler(this.btnMCarLogout_Click);
            // 
            // lblManageCar
            // 
            this.lblManageCar.AutoSize = true;
            this.lblManageCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblManageCar.Font = new System.Drawing.Font("Ebrima", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageCar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblManageCar.Location = new System.Drawing.Point(469, 11);
            this.lblManageCar.Name = "lblManageCar";
            this.lblManageCar.Size = new System.Drawing.Size(87, 45);
            this.lblManageCar.TabIndex = 0;
            this.lblManageCar.Text = "Cars";
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReg.Location = new System.Drawing.Point(30, 90);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(77, 21);
            this.lblReg.TabIndex = 1;
            this.lblReg.Text = "Reg No";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(30, 155);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(64, 21);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "Brand";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(30, 220);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(68, 21);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(30, 285);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(57, 21);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(30, 350);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(98, 21);
            this.lblAvailable.TabIndex = 4;
            this.lblAvailable.Text = "Available";
            // 
            // txtRegNo
            // 
            this.txtRegNo.BackColor = System.Drawing.Color.Ivory;
            this.txtRegNo.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegNo.Location = new System.Drawing.Point(169, 90);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(237, 27);
            this.txtRegNo.TabIndex = 5;
            // 
            // txtBrand
            // 
            this.txtBrand.BackColor = System.Drawing.Color.Ivory;
            this.txtBrand.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(169, 155);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(237, 27);
            this.txtBrand.TabIndex = 6;
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.Color.Ivory;
            this.txtModel.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(169, 214);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(237, 27);
            this.txtModel.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Ivory;
            this.txtPrice.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(169, 285);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(237, 27);
            this.txtPrice.TabIndex = 8;
            // 
            // cmbAvailable
            // 
            this.cmbAvailable.BackColor = System.Drawing.Color.Ivory;
            this.cmbAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAvailable.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAvailable.FormattingEnabled = true;
            this.cmbAvailable.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cmbAvailable.Location = new System.Drawing.Point(169, 350);
            this.cmbAvailable.Name = "cmbAvailable";
            this.cmbAvailable.Size = new System.Drawing.Size(237, 26);
            this.cmbAvailable.TabIndex = 9;
            // 
            // btnAddCar
            // 
            this.btnAddCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnAddCar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCar.Location = new System.Drawing.Point(41, 410);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(102, 59);
            this.btnAddCar.TabIndex = 11;
            this.btnAddCar.Text = "Add";
            this.btnAddCar.UseVisualStyleBackColor = false;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnSaveCar
            // 
            this.btnSaveCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnSaveCar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCar.Location = new System.Drawing.Point(194, 410);
            this.btnSaveCar.Name = "btnSaveCar";
            this.btnSaveCar.Size = new System.Drawing.Size(102, 59);
            this.btnSaveCar.TabIndex = 12;
            this.btnSaveCar.Text = "Update";
            this.btnSaveCar.UseVisualStyleBackColor = false;
            this.btnSaveCar.Click += new System.EventHandler(this.btnSaveCar_Click);
            // 
            // btnDltCar
            // 
            this.btnDltCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnDltCar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDltCar.Location = new System.Drawing.Point(346, 410);
            this.btnDltCar.Name = "btnDltCar";
            this.btnDltCar.Size = new System.Drawing.Size(102, 59);
            this.btnDltCar.TabIndex = 13;
            this.btnDltCar.Text = "Delete";
            this.btnDltCar.UseVisualStyleBackColor = false;
            this.btnDltCar.Click += new System.EventHandler(this.btnDltCar_Click);
            // 
            // btnClearCar
            // 
            this.btnClearCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnClearCar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCar.Location = new System.Drawing.Point(194, 488);
            this.btnClearCar.Name = "btnClearCar";
            this.btnClearCar.Size = new System.Drawing.Size(102, 59);
            this.btnClearCar.TabIndex = 14;
            this.btnClearCar.Text = "Clear";
            this.btnClearCar.UseVisualStyleBackColor = false;
            this.btnClearCar.Click += new System.EventHandler(this.btnClearCar_Click);
            // 
            // dgvCar
            // 
            this.dgvCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.dgvCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegNo,
            this.Brand,
            this.Model,
            this.Price,
            this.Available});
            this.dgvCar.Location = new System.Drawing.Point(491, 141);
            this.dgvCar.Name = "dgvCar";
            this.dgvCar.RowHeadersWidth = 51;
            this.dgvCar.RowTemplate.Height = 24;
            this.dgvCar.Size = new System.Drawing.Size(523, 399);
            this.dgvCar.TabIndex = 17;
            this.dgvCar.DoubleClick += new System.EventHandler(this.dgvCar_DoubleClick);
            // 
            // RegNo
            // 
            this.RegNo.DataPropertyName = "RegNo";
            this.RegNo.HeaderText = "RegNo";
            this.RegNo.MinimumWidth = 6;
            this.RegNo.Name = "RegNo";
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "Brand";
            this.Brand.MinimumWidth = 6;
            this.Brand.Name = "Brand";
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // Available
            // 
            this.Available.DataPropertyName = "Available";
            this.Available.HeaderText = "Available";
            this.Available.MinimumWidth = 6;
            this.Available.Name = "Available";
            // 
            // lblSearchCar
            // 
            this.lblSearchCar.AutoSize = true;
            this.lblSearchCar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCar.Location = new System.Drawing.Point(630, 100);
            this.lblSearchCar.Name = "lblSearchCar";
            this.lblSearchCar.Size = new System.Drawing.Size(71, 21);
            this.lblSearchCar.TabIndex = 27;
            this.lblSearchCar.Text = "Search";
            // 
            // txtSearchCar
            // 
            this.txtSearchCar.BackColor = System.Drawing.Color.Ivory;
            this.txtSearchCar.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCar.Location = new System.Drawing.Point(717, 94);
            this.txtSearchCar.Name = "txtSearchCar";
            this.txtSearchCar.Size = new System.Drawing.Size(237, 27);
            this.txtSearchCar.TabIndex = 28;
            this.txtSearchCar.TextChanged += new System.EventHandler(this.txtSearchCar_TextChanged);
            // 
            // ManageCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1030, 565);
            this.Controls.Add(this.txtSearchCar);
            this.Controls.Add(this.lblSearchCar);
            this.Controls.Add(this.dgvCar);
            this.Controls.Add(this.btnClearCar);
            this.Controls.Add(this.btnDltCar);
            this.Controls.Add(this.btnSaveCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.cmbAvailable);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtRegNo);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.ManageCarpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Managecar";
            this.ManageCarpanel.ResumeLayout(false);
            this.ManageCarpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ManageCarpanel;
        private System.Windows.Forms.Label lblManageCar;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbAvailable;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnSaveCar;
        private System.Windows.Forms.Button btnDltCar;
        private System.Windows.Forms.Button btnClearCar;
        private System.Windows.Forms.Button btnMCarLogout;
        private System.Windows.Forms.DataGridView dgvCar;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available;
        private System.Windows.Forms.Label lblSearchCar;
        private System.Windows.Forms.TextBox txtSearchCar;
    }
}