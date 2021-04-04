namespace eDentalist.WinUI.Reports
{
    partial class frmEquipmentReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EquipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtEquipmentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEquipmentType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.AppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EquipmentBindingSource
            // 
            this.EquipmentBindingSource.DataSource = typeof(eDentalist.Model.Equipment);
            // 
            // reportViewer
            // 
            reportDataSource1.Name = "dsEquipment";
            reportDataSource1.Value = this.EquipmentBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "eDentalist.WinUI.Reports.EquipmentReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 83);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(800, 367);
            this.reportViewer.TabIndex = 0;
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.Location = new System.Drawing.Point(12, 57);
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.Size = new System.Drawing.Size(228, 20);
            this.txtEquipmentName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Equipment name:";
            // 
            // cmbEquipmentType
            // 
            this.cmbEquipmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipmentType.FormattingEnabled = true;
            this.cmbEquipmentType.Location = new System.Drawing.Point(246, 56);
            this.cmbEquipmentType.Name = "cmbEquipmentType";
            this.cmbEquipmentType.Size = new System.Drawing.Size(228, 21);
            this.cmbEquipmentType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Equipment type:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(480, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // AppointmentBindingSource
            // 
            this.AppointmentBindingSource.DataSource = typeof(eDentalist.Model.Appointment);
            // 
            // frmEquipmentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbEquipmentType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEquipmentName);
            this.Controls.Add(this.reportViewer);
            this.Name = "frmEquipmentReport";
            this.Text = "frmEquipmentReport";
            this.Load += new System.EventHandler(this.frmEquipmentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource EquipmentBindingSource;
        private System.Windows.Forms.TextBox txtEquipmentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEquipmentType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource AppointmentBindingSource;
    }
}