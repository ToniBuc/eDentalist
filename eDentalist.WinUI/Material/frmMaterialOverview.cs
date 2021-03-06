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
    }
}
