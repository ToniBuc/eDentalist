using eDentalist.Model.Requests;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentalist.WinUI.Reports
{
    public partial class frmMaterialReport : Form
    {
        private readonly APIService _materialService = new APIService("Material");
        public frmMaterialReport()
        {
            InitializeComponent();
        }

        private void frmMaterialReport_Load(object sender, EventArgs e)
        {
            reportViewer.ZoomMode = ZoomMode.PageWidth;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new MaterialSearchRequest()
            {
                Name = txtMaterial.Text
            };

            var materials = await _materialService.Get<List<Model.Material>>(search);

            if (materials != null)
            {
                MaterialBindingSource.DataSource = materials;
                ReportDataSource source = new ReportDataSource("dsMaterial", MaterialBindingSource);
                this.reportViewer.LocalReport.DataSources.Add(source);
                this.reportViewer.RefreshReport();
            }
            else
            {
                MaterialBindingSource.DataSource = null;
                ReportDataSource source = new ReportDataSource("dsMaterial", MaterialBindingSource);
                this.reportViewer.LocalReport.DataSources.Add(source);
                this.reportViewer.RefreshReport();
            }
        }
    }
}
