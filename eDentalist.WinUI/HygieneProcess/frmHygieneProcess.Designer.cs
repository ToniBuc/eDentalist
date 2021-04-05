namespace eDentalist.WinUI.HygieneProcess
{
    partial class frmHygieneProcess
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbHygieneProcessType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateOfPerformance = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.cmbStaffMember = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff member: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type:";
            // 
            // cmbHygieneProcessType
            // 
            this.cmbHygieneProcessType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHygieneProcessType.FormattingEnabled = true;
            this.cmbHygieneProcessType.Location = new System.Drawing.Point(39, 94);
            this.cmbHygieneProcessType.Name = "cmbHygieneProcessType";
            this.cmbHygieneProcessType.Size = new System.Drawing.Size(241, 21);
            this.cmbHygieneProcessType.TabIndex = 2;
            this.cmbHygieneProcessType.Validating += new System.ComponentModel.CancelEventHandler(this.cmbHygieneProcessType_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date:";
            // 
            // dtpDateOfPerformance
            // 
            this.dtpDateOfPerformance.Location = new System.Drawing.Point(39, 138);
            this.dtpDateOfPerformance.Name = "dtpDateOfPerformance";
            this.dtpDateOfPerformance.Size = new System.Drawing.Size(241, 20);
            this.dtpDateOfPerformance.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description:";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(39, 186);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(241, 134);
            this.rtxtDescription.TabIndex = 4;
            this.rtxtDescription.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(205, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Location = new System.Drawing.Point(134, 330);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(65, 17);
            this.cbStatus.TabIndex = 9;
            this.cbStatus.Text = "Finished";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // cmbStaffMember
            // 
            this.cmbStaffMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStaffMember.FormattingEnabled = true;
            this.cmbStaffMember.Location = new System.Drawing.Point(39, 53);
            this.cmbStaffMember.Name = "cmbStaffMember";
            this.cmbStaffMember.Size = new System.Drawing.Size(241, 21);
            this.cmbStaffMember.TabIndex = 1;
            this.cmbStaffMember.Validating += new System.ComponentModel.CancelEventHandler(this.cmbStaffMember_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eDentalist.WinUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(212, 363);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmHygieneProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(324, 470);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbStaffMember);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDateOfPerformance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbHygieneProcessType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHygieneProcess";
            this.Text = "frmHygieneProcess";
            this.Load += new System.EventHandler(this.frmHygieneProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbHygieneProcessType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateOfPerformance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.ComboBox cmbStaffMember;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}