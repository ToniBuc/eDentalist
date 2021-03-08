namespace eDentalist.WinUI.Equipment
{
    partial class frmEquipment
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDateLastUsed = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDateAdded = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEquipmentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEquipmentType = new System.Windows.Forms.ComboBox();
            this.cbCondition = new System.Windows.Forms.CheckBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRequisition = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(213, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Description:";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Location = new System.Drawing.Point(43, 282);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(245, 125);
            this.rtxtDescription.TabIndex = 19;
            this.rtxtDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Date last used:";
            // 
            // dtpDateLastUsed
            // 
            this.dtpDateLastUsed.Location = new System.Drawing.Point(43, 235);
            this.dtpDateLastUsed.Name = "dtpDateLastUsed";
            this.dtpDateLastUsed.Size = new System.Drawing.Size(245, 20);
            this.dtpDateLastUsed.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Date added:";
            // 
            // dtpDateAdded
            // 
            this.dtpDateAdded.Location = new System.Drawing.Point(43, 187);
            this.dtpDateAdded.Name = "dtpDateAdded";
            this.dtpDateAdded.Size = new System.Drawing.Size(245, 20);
            this.dtpDateAdded.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Type:";
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.Location = new System.Drawing.Point(43, 46);
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.Size = new System.Drawing.Size(245, 20);
            this.txtEquipmentName.TabIndex = 12;
            this.txtEquipmentName.Validating += new System.ComponentModel.CancelEventHandler(this.txtEquipmentName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name:";
            // 
            // cmbEquipmentType
            // 
            this.cmbEquipmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipmentType.FormattingEnabled = true;
            this.cmbEquipmentType.Location = new System.Drawing.Point(43, 95);
            this.cmbEquipmentType.Name = "cmbEquipmentType";
            this.cmbEquipmentType.Size = new System.Drawing.Size(245, 21);
            this.cmbEquipmentType.TabIndex = 22;
            this.cmbEquipmentType.Validating += new System.ComponentModel.CancelEventHandler(this.cmbEquipmentType_Validating);
            // 
            // cbCondition
            // 
            this.cbCondition.AutoSize = true;
            this.cbCondition.Location = new System.Drawing.Point(132, 417);
            this.cbCondition.Name = "cbCondition";
            this.cbCondition.Size = new System.Drawing.Size(75, 17);
            this.cbCondition.TabIndex = 23;
            this.cbCondition.Text = "Functional";
            this.cbCondition.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(43, 141);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(245, 20);
            this.txtAmount.TabIndex = 25;
            this.txtAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmount_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Amount:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnRequisition
            // 
            this.btnRequisition.Location = new System.Drawing.Point(43, 413);
            this.btnRequisition.Name = "btnRequisition";
            this.btnRequisition.Size = new System.Drawing.Size(75, 23);
            this.btnRequisition.TabIndex = 26;
            this.btnRequisition.Text = "Requisition";
            this.btnRequisition.UseVisualStyleBackColor = true;
            this.btnRequisition.Click += new System.EventHandler(this.btnRequisition_Click);
            // 
            // frmEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 533);
            this.Controls.Add(this.btnRequisition);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCondition);
            this.Controls.Add(this.cmbEquipmentType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDateLastUsed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDateAdded);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEquipmentName);
            this.Controls.Add(this.label1);
            this.Name = "frmEquipment";
            this.Text = "frmEquipment";
            this.Load += new System.EventHandler(this.frmEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDateLastUsed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateAdded;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEquipmentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEquipmentType;
        private System.Windows.Forms.CheckBox cbCondition;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnRequisition;
    }
}