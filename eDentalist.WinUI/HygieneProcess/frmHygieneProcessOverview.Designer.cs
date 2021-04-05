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
            this.HygieneProcessID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffMember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmbHygieneProcessType = new System.Windows.Forms.ComboBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHygieneProcesses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHygieneProcesses
            // 
            this.dgvHygieneProcesses.AllowUserToAddRows = false;
            this.dgvHygieneProcesses.AllowUserToDeleteRows = false;
            this.dgvHygieneProcesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHygieneProcesses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HygieneProcessID,
            this.StaffMember,
            this.Type,
            this.Date,
            this.Description,
            this.Status});
            this.dgvHygieneProcesses.Location = new System.Drawing.Point(12, 60);
            this.dgvHygieneProcesses.Name = "dgvHygieneProcesses";
            this.dgvHygieneProcesses.ReadOnly = true;
            this.dgvHygieneProcesses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHygieneProcesses.Size = new System.Drawing.Size(776, 378);
            this.dgvHygieneProcesses.TabIndex = 0;
            this.dgvHygieneProcesses.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvHygieneProcesses_MouseDoubleClick);
            // 
            // HygieneProcessID
            // 
            this.HygieneProcessID.DataPropertyName = "HygieneProcessID";
            this.HygieneProcessID.HeaderText = "HygieneProcessID";
            this.HygieneProcessID.Name = "HygieneProcessID";
            this.HygieneProcessID.ReadOnly = true;
            this.HygieneProcessID.Visible = false;
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
            // cmbHygieneProcessType
            // 
            this.cmbHygieneProcessType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(256, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eDentalist.WinUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(688, 445);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmHygieneProcessOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.cmbHygieneProcessType);
            this.Controls.Add(this.dgvHygieneProcesses);
            this.Name = "frmHygieneProcessOverview";
            this.Text = "frmHygieneProcessOverview";
            this.Load += new System.EventHandler(this.frmHygieneProcessOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHygieneProcesses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHygieneProcesses;
        private System.Windows.Forms.ComboBox cmbHygieneProcessType;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn HygieneProcessID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}