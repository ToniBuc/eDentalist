namespace eDentalist.WinUI.Staff
{
    partial class frmCityOverview
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
            this.dgvCities = new System.Windows.Forms.DataGridView();
            this.CityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZIPCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCities
            // 
            this.dgvCities.AllowUserToAddRows = false;
            this.dgvCities.AllowUserToDeleteRows = false;
            this.dgvCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CityID,
            this.City,
            this.Country,
            this.ZIPCode});
            this.dgvCities.Location = new System.Drawing.Point(11, 92);
            this.dgvCities.Name = "dgvCities";
            this.dgvCities.ReadOnly = true;
            this.dgvCities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCities.Size = new System.Drawing.Size(460, 370);
            this.dgvCities.TabIndex = 0;
            this.dgvCities.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvCities_MouseDoubleClick);
            // 
            // CityID
            // 
            this.CityID.DataPropertyName = "CityID";
            this.CityID.HeaderText = "CityID";
            this.CityID.Name = "CityID";
            this.CityID.ReadOnly = true;
            this.CityID.Visible = false;
            // 
            // City
            // 
            this.City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.City.DataPropertyName = "Name";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Country
            // 
            this.Country.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Country.DataPropertyName = "CountryName";
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            // 
            // ZIPCode
            // 
            this.ZIPCode.DataPropertyName = "ZIPCode";
            this.ZIPCode.HeaderText = "ZIP Code";
            this.ZIPCode.Name = "ZIPCode";
            this.ZIPCode.ReadOnly = true;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(198, 66);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(181, 20);
            this.txtCountry.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(385, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(11, 66);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(181, 20);
            this.txtCity.TabIndex = 3;
            // 
            // btnAddCity
            // 
            this.btnAddCity.Location = new System.Drawing.Point(11, 468);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(76, 23);
            this.btnAddCity.TabIndex = 5;
            this.btnAddCity.Text = "Add new city";
            this.btnAddCity.UseVisualStyleBackColor = true;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Country:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eDentalist.WinUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(371, 475);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmCityOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(483, 582);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.dgvCities);
            this.Name = "frmCityOverview";
            this.Text = "frmCityOverview";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCities;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZIPCode;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}