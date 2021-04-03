namespace eDentalist.WinUI.Staff
{
    partial class frmStaffMembers
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
            this.StaffMembers = new System.Windows.Forms.GroupBox();
            this.dgvStaffMembers = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnReportStaff = new System.Windows.Forms.Button();
            this.btnCity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StaffMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // StaffMembers
            // 
            this.StaffMembers.Controls.Add(this.dgvStaffMembers);
            this.StaffMembers.Location = new System.Drawing.Point(12, 73);
            this.StaffMembers.Name = "StaffMembers";
            this.StaffMembers.Size = new System.Drawing.Size(349, 355);
            this.StaffMembers.TabIndex = 0;
            this.StaffMembers.TabStop = false;
            this.StaffMembers.Text = "StaffMembers";
            // 
            // dgvStaffMembers
            // 
            this.dgvStaffMembers.AllowUserToAddRows = false;
            this.dgvStaffMembers.AllowUserToDeleteRows = false;
            this.dgvStaffMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.FirstName,
            this.LastName,
            this.StaffRole});
            this.dgvStaffMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaffMembers.Location = new System.Drawing.Point(3, 16);
            this.dgvStaffMembers.Name = "dgvStaffMembers";
            this.dgvStaffMembers.ReadOnly = true;
            this.dgvStaffMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaffMembers.Size = new System.Drawing.Size(343, 336);
            this.dgvStaffMembers.TabIndex = 0;
            this.dgvStaffMembers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvStaffMembers_MouseDoubleClick);
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // StaffRole
            // 
            this.StaffRole.DataPropertyName = "UserRoleName";
            this.StaffRole.HeaderText = "Staff role";
            this.StaffRole.Name = "StaffRole";
            this.StaffRole.ReadOnly = true;
            this.StaffRole.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(283, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(15, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(262, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(15, 435);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(81, 23);
            this.btnAddStaff.TabIndex = 3;
            this.btnAddStaff.Text = "Add new staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnReportStaff
            // 
            this.btnReportStaff.Location = new System.Drawing.Point(277, 435);
            this.btnReportStaff.Name = "btnReportStaff";
            this.btnReportStaff.Size = new System.Drawing.Size(81, 23);
            this.btnReportStaff.TabIndex = 4;
            this.btnReportStaff.Text = "Report";
            this.btnReportStaff.UseVisualStyleBackColor = true;
            this.btnReportStaff.Click += new System.EventHandler(this.btnReportStaff_Click);
            // 
            // btnCity
            // 
            this.btnCity.Location = new System.Drawing.Point(102, 435);
            this.btnCity.Name = "btnCity";
            this.btnCity.Size = new System.Drawing.Size(81, 23);
            this.btnCity.TabIndex = 5;
            this.btnCity.Text = "Cities";
            this.btnCity.UseVisualStyleBackColor = true;
            this.btnCity.Click += new System.EventHandler(this.btnCity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Staff member:";
            // 
            // frmStaffMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(375, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCity);
            this.Controls.Add(this.btnReportStaff);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.StaffMembers);
            this.Name = "frmStaffMembers";
            this.Text = "frmStaffMembers";
            this.StaffMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox StaffMembers;
        private System.Windows.Forms.DataGridView dgvStaffMembers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnReportStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffRole;
        private System.Windows.Forms.Button btnCity;
        private System.Windows.Forms.Label label1;
    }
}