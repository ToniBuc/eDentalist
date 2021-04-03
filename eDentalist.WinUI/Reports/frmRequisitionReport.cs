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
    public partial class frmRequisitionReport : Form
    {
        private readonly APIService _requisitionService = new APIService("Requisition");
        public frmRequisitionReport()
        {
            InitializeComponent();
        }

        private async void frmRequisitionReport_Load(object sender, EventArgs e)
        {
            await LoadItemType();
            reportViewer.ZoomMode = ZoomMode.PageWidth;
        }
        private async Task LoadItemType()
        {
            cmbItemType.Items.Insert(0, "");
            cmbItemType.Items.Insert(1, "Equipment");
            cmbItemType.Items.Insert(2, "Material");
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new RequisitionSearchRequest();
            if (cmbItemType.Text == "")
            {
                search.RequisitionType = "All";
            }
            else if (cmbItemType.Text == "Equipment")
            {
                search.RequisitionType = "Equipment";
            }
            else if (cmbItemType.Text == "Material")
            {
                search.RequisitionType = "Material";
            }

            var requsitions = await _requisitionService.Get<List<Model.Requisition>>(search);

            if (requsitions != null)
            {
                RequisitionBindingSource.DataSource = requsitions;
                ReportDataSource source = new ReportDataSource("dsRequisition", RequisitionBindingSource);
                this.reportViewer.LocalReport.DataSources.Add(source);
                this.reportViewer.RefreshReport();
            }
            else
            {
                RequisitionBindingSource.DataSource = null;
                ReportDataSource source = new ReportDataSource("dsRequisition", RequisitionBindingSource);
                this.reportViewer.LocalReport.DataSources.Add(source);
                this.reportViewer.RefreshReport();
            }
        }
    }
}
