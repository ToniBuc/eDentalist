namespace eDentalist.WinUI
{
    partial class frmIndex
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnStaff = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRequisition = new System.Windows.Forms.Button();
            this.btnEquipment = new System.Windows.Forms.Button();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.btnHygiene = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 605);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1072, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // btnStaff
            // 
            this.btnStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.Location = new System.Drawing.Point(12, 121);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(193, 38);
            this.btnStaff.TabIndex = 4;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnRequisition);
            this.panel1.Controls.Add(this.btnEquipment);
            this.panel1.Controls.Add(this.btnMaterial);
            this.panel1.Controls.Add(this.btnHygiene);
            this.panel1.Controls.Add(this.btnStaff);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 605);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 38);
            this.button1.TabIndex = 9;
            this.button1.Text = "Patients";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRequisition
            // 
            this.btnRequisition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequisition.Location = new System.Drawing.Point(12, 297);
            this.btnRequisition.Name = "btnRequisition";
            this.btnRequisition.Size = new System.Drawing.Size(193, 38);
            this.btnRequisition.TabIndex = 8;
            this.btnRequisition.Text = "Requisition";
            this.btnRequisition.UseVisualStyleBackColor = true;
            this.btnRequisition.Click += new System.EventHandler(this.btnRequisition_Click);
            // 
            // btnEquipment
            // 
            this.btnEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipment.Location = new System.Drawing.Point(12, 253);
            this.btnEquipment.Name = "btnEquipment";
            this.btnEquipment.Size = new System.Drawing.Size(193, 38);
            this.btnEquipment.TabIndex = 7;
            this.btnEquipment.Text = "Equipment";
            this.btnEquipment.UseVisualStyleBackColor = true;
            this.btnEquipment.Click += new System.EventHandler(this.btnEquipment_Click);
            // 
            // btnMaterial
            // 
            this.btnMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterial.Location = new System.Drawing.Point(12, 209);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(193, 38);
            this.btnMaterial.TabIndex = 6;
            this.btnMaterial.Text = "Materials";
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // btnHygiene
            // 
            this.btnHygiene.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHygiene.Location = new System.Drawing.Point(12, 165);
            this.btnHygiene.Name = "btnHygiene";
            this.btnHygiene.Size = new System.Drawing.Size(193, 38);
            this.btnHygiene.TabIndex = 5;
            this.btnHygiene.Text = "Hygiene";
            this.btnHygiene.UseVisualStyleBackColor = true;
            this.btnHygiene.Click += new System.EventHandler(this.btnHygiene_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(220, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 148);
            this.panel2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Appointments";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 627);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "frmIndex";
            this.Text = "frmIndex";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHygiene;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnEquipment;
        private System.Windows.Forms.Button btnRequisition;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}



