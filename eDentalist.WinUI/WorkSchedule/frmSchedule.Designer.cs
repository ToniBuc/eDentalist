namespace eDentalist.WinUI.WorkSchedule
{
    partial class frmSchedule
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
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddWorkday = new System.Windows.Forms.Button();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.UserWorkdayID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkdayID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dentist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.AllowUserToDeleteRows = false;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserWorkdayID,
            this.WorkdayID,
            this.UserID,
            this.Dentist,
            this.Role,
            this.Date,
            this.Shift});
            this.dgvSchedule.Location = new System.Drawing.Point(12, 65);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedule.Size = new System.Drawing.Size(776, 373);
            this.dgvSchedule.TabIndex = 0;
            this.dgvSchedule.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvSchedule_MouseDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(241, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(260, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddWorkday
            // 
            this.btnAddWorkday.Location = new System.Drawing.Point(13, 444);
            this.btnAddWorkday.Name = "btnAddWorkday";
            this.btnAddWorkday.Size = new System.Drawing.Size(77, 23);
            this.btnAddWorkday.TabIndex = 3;
            this.btnAddWorkday.Text = "Add workday";
            this.btnAddWorkday.UseVisualStyleBackColor = true;
            this.btnAddWorkday.Click += new System.EventHandler(this.btnAddWorkday_Click);
            // 
            // btnAppointments
            // 
            this.btnAppointments.Location = new System.Drawing.Point(96, 444);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(116, 23);
            this.btnAppointments.TabIndex = 4;
            this.btnAppointments.Text = "Check appointments";
            this.btnAppointments.UseVisualStyleBackColor = true;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            // 
            // UserWorkdayID
            // 
            this.UserWorkdayID.DataPropertyName = "UserWorkdayID";
            this.UserWorkdayID.HeaderText = "UserWorkdayID";
            this.UserWorkdayID.Name = "UserWorkdayID";
            this.UserWorkdayID.ReadOnly = true;
            this.UserWorkdayID.Visible = false;
            // 
            // WorkdayID
            // 
            this.WorkdayID.DataPropertyName = "WorkdayID";
            this.WorkdayID.HeaderText = "WorkdayID";
            this.WorkdayID.Name = "WorkdayID";
            this.WorkdayID.ReadOnly = true;
            this.WorkdayID.Visible = false;
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Visible = false;
            // 
            // Dentist
            // 
            this.Dentist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dentist.DataPropertyName = "UserFullName";
            this.Dentist.HeaderText = "Dentist";
            this.Dentist.Name = "Dentist";
            this.Dentist.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Role.DataPropertyName = "UserRole";
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Shift
            // 
            this.Shift.DataPropertyName = "ShiftNumber";
            this.Shift.HeaderText = "Shift";
            this.Shift.Name = "Shift";
            this.Shift.ReadOnly = true;
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.btnAppointments);
            this.Controls.Add(this.btnAddWorkday);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvSchedule);
            this.Name = "frmSchedule";
            this.Text = "frmSchedule";
            this.Load += new System.EventHandler(this.frmSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddWorkday;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserWorkdayID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkdayID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dentist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift;
    }
}