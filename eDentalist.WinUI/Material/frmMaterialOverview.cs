using eDentalist.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentalist.WinUI.Material
{
    public partial class frmMaterialOverview : Form
    {
        private readonly APIService _apiService = new APIService("Material");
        public frmMaterialOverview()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new MaterialSearchRequest()
            {
                Name = txtSearch.Text,
            };
            var result = await _apiService.Get<List<Model.Material>>(search);

            dgvMaterials.AutoGenerateColumns = false;
            dgvMaterials.DataSource = result;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmMaterial frm = new frmMaterial();
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Show();
        }

        private void dgvMaterials_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!dgvMaterials.RowCount.Equals(0))
            {
                var id = dgvMaterials.SelectedRows[0].Cells[0].Value;
                frmMaterial frm = new frmMaterial(int.Parse(id.ToString()));
                frm.FormBorderStyle = FormBorderStyle.FixedSingle;
                frm.MaximizeBox = false;
                frm.MinimizeBox = false;
                frm.Show();
            }
        }
    }
}
