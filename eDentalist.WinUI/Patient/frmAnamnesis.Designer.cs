namespace eDentalist.WinUI.Patient
{
    partial class frmAnamnesis
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
            this.txtDate = new System.Windows.Forms.TextBox();
            this.rtxtAnamnesis = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtTherapy = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtAdditionalNotes = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtProcedure = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDentist = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(269, 56);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(159, 20);
            this.txtDate.TabIndex = 1;
            // 
            // rtxtAnamnesis
            // 
            this.rtxtAnamnesis.Location = new System.Drawing.Point(29, 111);
            this.rtxtAnamnesis.Name = "rtxtAnamnesis";
            this.rtxtAnamnesis.Size = new System.Drawing.Size(847, 285);
            this.rtxtAnamnesis.TabIndex = 2;
            this.rtxtAnamnesis.Text = "";
            this.rtxtAnamnesis.Validating += new System.ComponentModel.CancelEventHandler(this.rtxtAnamnesis_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Anamnesis:";
            // 
            // rtxtTherapy
            // 
            this.rtxtTherapy.Location = new System.Drawing.Point(29, 422);
            this.rtxtTherapy.Name = "rtxtTherapy";
            this.rtxtTherapy.Size = new System.Drawing.Size(311, 96);
            this.rtxtTherapy.TabIndex = 4;
            this.rtxtTherapy.Text = "";
            this.rtxtTherapy.Validating += new System.ComponentModel.CancelEventHandler(this.rtxtTherapy_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Therapy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Additional notes:";
            // 
            // rtxtAdditionalNotes
            // 
            this.rtxtAdditionalNotes.Location = new System.Drawing.Point(346, 422);
            this.rtxtAdditionalNotes.Name = "rtxtAdditionalNotes";
            this.rtxtAdditionalNotes.Size = new System.Drawing.Size(311, 96);
            this.rtxtAdditionalNotes.TabIndex = 6;
            this.rtxtAdditionalNotes.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 532);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dentist:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(265, 547);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtProcedure
            // 
            this.txtProcedure.Location = new System.Drawing.Point(29, 56);
            this.txtProcedure.Name = "txtProcedure";
            this.txtProcedure.ReadOnly = true;
            this.txtProcedure.Size = new System.Drawing.Size(230, 20);
            this.txtProcedure.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Procedure:";
            // 
            // txtDentist
            // 
            this.txtDentist.Location = new System.Drawing.Point(29, 550);
            this.txtDentist.Name = "txtDentist";
            this.txtDentist.ReadOnly = true;
            this.txtDentist.Size = new System.Drawing.Size(230, 20);
            this.txtDentist.TabIndex = 13;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmAnamnesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 582);
            this.Controls.Add(this.txtDentist);
            this.Controls.Add(this.txtProcedure);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtxtAdditionalNotes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtxtTherapy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxtAnamnesis);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label1);
            this.Name = "frmAnamnesis";
            this.Text = "frmAnamnesis";
            this.Load += new System.EventHandler(this.frmAnamnesis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.RichTextBox rtxtAnamnesis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtTherapy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxtAdditionalNotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtProcedure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDentist;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}