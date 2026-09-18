namespace CarRentalManagementSystem
{
    partial class StaffDash
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
            this.StaffDashPanel = new System.Windows.Forms.Panel();
            this.lblStaffDashboard = new System.Windows.Forms.Label();
            this.btnStaffLogout = new System.Windows.Forms.Button();
            this.lblStaff = new System.Windows.Forms.Label();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnRentals = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btncrossStaff = new System.Windows.Forms.Button();
            this.StaffDashPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StaffDashPanel
            // 
            this.StaffDashPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.StaffDashPanel.Controls.Add(this.lblStaffDashboard);
            this.StaffDashPanel.Controls.Add(this.btnStaffLogout);
            this.StaffDashPanel.Controls.Add(this.lblStaff);
            this.StaffDashPanel.Location = new System.Drawing.Point(0, 0);
            this.StaffDashPanel.Name = "StaffDashPanel";
            this.StaffDashPanel.Size = new System.Drawing.Size(277, 452);
            this.StaffDashPanel.TabIndex = 2;
            // 
            // lblStaffDashboard
            // 
            this.lblStaffDashboard.AutoSize = true;
            this.lblStaffDashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffDashboard.Location = new System.Drawing.Point(24, 212);
            this.lblStaffDashboard.Name = "lblStaffDashboard";
            this.lblStaffDashboard.Size = new System.Drawing.Size(216, 43);
            this.lblStaffDashboard.TabIndex = 2;
            this.lblStaffDashboard.Text = "Dashboard";
            // 
            // btnStaffLogout
            // 
            this.btnStaffLogout.FlatAppearance.BorderSize = 0;
            this.btnStaffLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffLogout.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffLogout.Location = new System.Drawing.Point(173, 416);
            this.btnStaffLogout.Name = "btnStaffLogout";
            this.btnStaffLogout.Size = new System.Drawing.Size(104, 33);
            this.btnStaffLogout.TabIndex = 0;
            this.btnStaffLogout.Text = "Logout";
            this.btnStaffLogout.UseVisualStyleBackColor = true;
            this.btnStaffLogout.Click += new System.EventHandler(this.btnStaffLogout_Click);
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.Location = new System.Drawing.Point(74, 156);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(103, 43);
            this.lblStaff.TabIndex = 1;
            this.lblStaff.Text = "Staff";
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Location = new System.Drawing.Point(360, 23);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(363, 119);
            this.btnCustomers.TabIndex = 5;
            this.btnCustomers.Text = "Manage Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnRentals
            // 
            this.btnRentals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnRentals.FlatAppearance.BorderSize = 0;
            this.btnRentals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentals.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentals.Location = new System.Drawing.Point(360, 164);
            this.btnRentals.Name = "btnRentals";
            this.btnRentals.Size = new System.Drawing.Size(363, 119);
            this.btnRentals.TabIndex = 6;
            this.btnRentals.Text = "Manage Rentals";
            this.btnRentals.UseVisualStyleBackColor = false;
            this.btnRentals.Click += new System.EventHandler(this.btnRentals_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnMaintenance.FlatAppearance.BorderSize = 0;
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenance.Location = new System.Drawing.Point(360, 305);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(363, 119);
            this.btnMaintenance.TabIndex = 7;
            this.btnMaintenance.Text = "Manage Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = false;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btncrossStaff
            // 
            this.btncrossStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btncrossStaff.FlatAppearance.BorderSize = 0;
            this.btncrossStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrossStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrossStaff.ForeColor = System.Drawing.Color.Black;
            this.btncrossStaff.Location = new System.Drawing.Point(770, 0);
            this.btncrossStaff.Name = "btncrossStaff";
            this.btncrossStaff.Size = new System.Drawing.Size(32, 29);
            this.btncrossStaff.TabIndex = 8;
            this.btncrossStaff.Text = "X";
            this.btncrossStaff.UseVisualStyleBackColor = false;
            this.btncrossStaff.Click += new System.EventHandler(this.btncrossStaff_Click);
            // 
            // StaffDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncrossStaff);
            this.Controls.Add(this.btnMaintenance);
            this.Controls.Add(this.btnRentals);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.StaffDashPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffDash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffDash";
            this.StaffDashPanel.ResumeLayout(false);
            this.StaffDashPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StaffDashPanel;
        private System.Windows.Forms.Label lblStaffDashboard;
        private System.Windows.Forms.Button btnStaffLogout;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnRentals;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btncrossStaff;
    }
}