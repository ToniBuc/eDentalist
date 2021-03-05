namespace eDentalist.WinUI.HygieneProcess
{
    partial class frmHygieneProcessOverview
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
            this.dgvHygieneProcesses = new System.Windows.Forms.DataGridView();
            this.cmbHygieneProcessType = new System.Windows.Forms.ComboBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.StaffMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHygieneProcesses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHygieneProcesses
            // 
            this.dgvHygieneProcesses.AllowUserToAddRows = false;
            this.dgvHygieneProcesses.AllowUserToDeleteRows = false;
            this.dgvHygieneProcesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHygieneProcesses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StaffMember,
            this.Type,
            this.Date,
            this.Description,
            this.Status});
            this.dgvHygieneProcesses.Location = new System.Drawing.Point(12, 60);
            this.dgvHygieneProcesses.Name = "dgvHygieneProcesses";
            this.dgvHygieneProcesses.ReadOnly = true;
            this.dgvHygieneProcesses.Size = new System.Drawing.Size(776, 378);
            this.dgvHygieneProcesses.TabIndex = 0;
            // 
            // cmbHygieneProcessType
            // 
            this.cmbHygieneProcessType.FormattingEnabled = true;
            this.cmbHygieneProcessType.Location = new System.Drawing.Point(12, 33);
            this.cmbHygieneProcessType.Name = "cmbHygieneProcessType";
            this.cmbHygieneProcessType.Size = new System.Drawing.Size(238, 21);
            this.cmbHygieneProcessType.TabIndex = 1;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(13, 445);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(256, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // StaffMember
            // 
            this.StaffMember.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffMember.DataPropertyName = "StaffName";
            this.StaffMember.HeaderText = "Staff member (job title)";
            this.StaffMember.Name = "StaffMember";
            this.StaffMember.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "HygieneProcessTypeName";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "DateOfPerformance";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.FalseValue = "";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.TrueValue = "";
            // 
            // frmHygieneProcessOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.cmbHygieneProcessType);
            this.Controls.Add(this.dgvHygieneProcesses);
            this.Name = "frmHygieneProcessOverview";
            this.Text = "frmHygieneProcessOverview";
            this.Load += new System.EventHandler(this.frmHygieneProcessOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHygieneProcesses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHygieneProcesses;
        private System.Windows.Forms.ComboBox cmbHygieneProcessType;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}