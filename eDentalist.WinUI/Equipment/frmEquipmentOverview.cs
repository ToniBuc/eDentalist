﻿using eDentalist.Model.Requests;
using eDentalist.WinUI.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentalist.WinUI.Equipment
{
    public partial class frmEquipmentOverview : Form
    {
        private readonly APIService _apiService = new APIService("Equipment");
        public frmEquipmentOverview()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new EquipmentSearchRequest()
            {
                Name = txtSearch.Text,
            };
            var result = await _apiService.Get<List<Model.Equipment>>(search);

            dgvEquipment.AutoGenerateColumns = false;
            dgvEquipment.DataSource = result;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmEquipment frm = new frmEquipment();
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Show();
        }

        private void dgvEquipment_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!dgvEquipment.RowCount.Equals(0))
            {
                var id = dgvEquipment.SelectedRows[0].Cells[0].Value;
                frmEquipment frm = new frmEquipment(int.Parse(id.ToString()));
                frm.FormBorderStyle = FormBorderStyle.FixedSingle;
                frm.MaximizeBox = false;
                frm.MinimizeBox = false;
                frm.Show();
            }
        }

        private void frmEquipmentOverview_Load(object sender, EventArgs e)
        {
            dgvEquipment.Columns["DateAdded"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvEquipment.Columns["DateLastUsed"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmEquipmentReport frm = new frmEquipmentReport();
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Show();
        }
    }
}
