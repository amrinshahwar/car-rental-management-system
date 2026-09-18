namespace CarRentalManagementSystem
{
    partial class AccountantDash
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
            this.AccDashPanel = new System.Windows.Forms.Panel();
            this.lblAccountantDashboard = new System.Windows.Forms.Label();
            this.btnAccLogout = new System.Windows.Forms.Button();
            this.lblAccountant = new System.Windows.Forms.Label();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btncrossAcc = new System.Windows.Forms.Button();
            this.AccDashPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccDashPanel
            // 
            this.AccDashPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.AccDashPanel.Controls.Add(this.lblAccountantDashboard);
            this.AccDashPanel.Controls.Add(this.btnAccLogout);
            this.AccDashPanel.Controls.Add(this.lblAccountant);
            this.AccDashPanel.Location = new System.Drawing.Point(0, 0);
            this.AccDashPanel.Name = "AccDashPanel";
            this.AccDashPanel.Size = new System.Drawing.Size(277, 452);
            this.AccDashPanel.TabIndex = 1;
            // 
            // lblAccountantDashboard
            // 
            this.lblAccountantDashboard.AutoSize = true;
            this.lblAccountantDashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountantDashboard.Location = new System.Drawing.Point(24, 212);
            this.lblAccountantDashboard.Name = "lblAccountantDashboard";
            this.lblAccountantDashboard.Size = new System.Drawing.Size(216, 43);
            this.lblAccountantDashboard.TabIndex = 2;
            this.lblAccountantDashboard.Text = "Dashboard";
            // 
            // btnAccLogout
            // 
            this.btnAccLogout.FlatAppearance.BorderSize = 0;
            this.btnAccLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccLogout.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccLogout.Location = new System.Drawing.Point(173, 416);
            this.btnAccLogout.Name = "btnAccLogout";
            this.btnAccLogout.Size = new System.Drawing.Size(104, 33);
            this.btnAccLogout.TabIndex = 0;
            this.btnAccLogout.Text = "Logout";
            this.btnAccLogout.UseVisualStyleBackColor = true;
            this.btnAccLogout.Click += new System.EventHandler(this.btnAccLogout_Click);
            // 
            // lblAccountant
            // 
            this.lblAccountant.AutoSize = true;
            this.lblAccountant.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountant.Location = new System.Drawing.Point(24, 156);
            this.lblAccountant.Name = "lblAccountant";
            this.lblAccountant.Size = new System.Drawing.Size(226, 43);
            this.lblAccountant.TabIndex = 1;
            this.lblAccountant.Text = "Accountant";
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.Location = new System.Drawing.Point(360, 164);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(363, 119);
            this.btnPayments.TabIndex = 4;
            this.btnPayments.Text = "Manage Payments";
            this.btnPayments.UseVisualStyleBackColor = false;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnInvoices.FlatAppearance.BorderSize = 0;
            this.btnInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoices.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoices.Location = new System.Drawing.Point(360, 23);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(363, 119);
            this.btnInvoices.TabIndex = 5;
            this.btnInvoices.Text = "Manage Invoices";
            this.btnInvoices.UseVisualStyleBackColor = false;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btnExpenses.FlatAppearance.BorderSize = 0;
            this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenses.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenses.Location = new System.Drawing.Point(360, 305);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(363, 119);
            this.btnExpenses.TabIndex = 6;
            this.btnExpenses.Text = "Manage Expenses";
            this.btnExpenses.UseVisualStyleBackColor = false;
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // btncrossAcc
            // 
            this.btncrossAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(154)))), ((int)(((byte)(91)))));
            this.btncrossAcc.FlatAppearance.BorderSize = 0;
            this.btncrossAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncrossAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrossAcc.ForeColor = System.Drawing.Color.Black;
            this.btncrossAcc.Location = new System.Drawing.Point(770, 0);
            this.btncrossAcc.Name = "btncrossAcc";
            this.btncrossAcc.Size = new System.Drawing.Size(32, 29);
            this.btncrossAcc.TabIndex = 7;
            this.btncrossAcc.Text = "X";
            this.btncrossAcc.UseVisualStyleBackColor = false;
            this.btncrossAcc.Click += new System.EventHandler(this.btncrossAcc_Click);
            // 
            // AccountantDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncrossAcc);
            this.Controls.Add(this.btnExpenses);
            this.Controls.Add(this.btnInvoices);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.AccDashPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountantDash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountantDash";
            this.AccDashPanel.ResumeLayout(false);
            this.AccDashPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AccDashPanel;
        private System.Windows.Forms.Label lblAccountantDashboard;
        private System.Windows.Forms.Button btnAccLogout;
        private System.Windows.Forms.Label lblAccountant;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnExpenses;
        private System.Windows.Forms.Button btncrossAcc;
    }
}