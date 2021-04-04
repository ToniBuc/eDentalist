namespace eDentalist.WinUI.Requisition
{
    partial class frmRequisitionOverview
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
            this.dgvRequisitions = new System.Windows.Forms.DataGridView();
            this.RequisitionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequisitionedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRequisitioned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbRequisitionType = new System.Windows.Forms.ComboBox();
            this.btnReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRequisitions
            // 
            this.dgvRequisitions.AllowUserToAddRows = false;
            this.dgvRequisitions.AllowUserToDeleteRows = false;
            this.dgvRequisitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequisitions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RequisitionID,
            this.Item,
            this.RequisitionedBy,
            this.Amount,
            this.DateRequisitioned,
            this.Status});
            this.dgvRequisitions.Location = new System.Drawing.Point(12, 63);
            this.dgvRequisitions.Name = "dgvRequisitions";
            this.dgvRequisitions.ReadOnly = true;
            this.dgvRequisitions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequisitions.Size = new System.Drawing.Size(776, 375);
            this.dgvRequisitions.TabIndex = 0;
            this.dgvRequisitions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvRequisitions_MouseDoubleClick);
            // 
            // RequisitionID
            // 
            this.RequisitionID.DataPropertyName = "RequisitionID";
            this.RequisitionID.HeaderText = "RequisitionID";
            this.RequisitionID.Name = "RequisitionID";
            this.RequisitionID.ReadOnly = true;
            this.RequisitionID.Visible = false;
            // 
            // Item
            // 
            this.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item.DataPropertyName = "ItemName";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // RequisitionedBy
            // 
            this.RequisitionedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RequisitionedBy.DataPropertyName = "RequisitionedBy";
            this.RequisitionedBy.HeaderText = "Requisitioned by";
            this.RequisitionedBy.Name = "RequisitionedBy";
            this.RequisitionedBy.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // DateRequisitioned
            // 
            this.DateRequisitioned.DataPropertyName = "DateRequisitioned";
            this.DateRequisitioned.HeaderText = "Date requisitioned";
            this.DateRequisitioned.Name = "DateRequisitioned";
            this.DateRequisitioned.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Status.Width = 62;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(256, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbRequisitionType
            // 
            this.cmbRequisitionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRequisitionType.FormattingEnabled = true;
            this.cmbRequisitionType.Location = new System.Drawing.Point(12, 36);
            this.cmbRequisitionType.Name = "cmbRequisitionType";
            this.cmbRequisitionType.Size = new System.Drawing.Size(238, 21);
            this.cmbRequisitionType.TabIndex = 4;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(713, 444);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // frmRequisitionOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbRequisitionType);
            this.Controls.Add(this.dgvRequisitions);
            this.Name = "frmRequisitionOverview";
            this.Text = "frmRequisitionOverview";
            this.Load += new System.EventHandler(this.frmRequisitionOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequisitions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRequisitions;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbRequisitionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequisitionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequisitionedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRequisitioned;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
        private System.Windows.Forms.Button btnReport;
    }
}