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
    public partial class frmBillReport : Form
    {
        private readonly APIService _billService = new APIService("Bill");
        public frmBillReport()
        {
            InitializeComponent();
        }

        private async void frmBillReport_Load(object sender, EventArgs e)
        {
            await LoadStatus();
            reportViewer.ZoomMode = ZoomMode.PageWidth;
        }
        private async Task LoadStatus()
        {
            cmbStatus.Items.Insert(0, "");
            cmbStatus.Items.Insert(1, "Paid");
            cmbStatus.Items.Insert(2, "Not paid");
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            //added because the dates being passed into the Get for some reason end up being 
            //two hours ahead of the ones that get stored in the search request
            var dateFromTemp = dtpFrom.Value.AddHours(-2);
            var dateToTemp = dtpTo.Value.AddHours(-2);
            var search = new BillSearchRequest()
            {
                From = dateFromTemp,
                To = dateToTemp,
                PatientName = txtPatient.Text
            };
            if (cmbStatus.Text == "")
            {
                search.StatusString = "All";
            }
            else if (cmbStatus.Text == "Paid")
            {
                search.Status = true;
            }
            else if (cmbStatus.Text == "Not paid")
            {
                search.Status = false;
            }

            var bills = await _billService.Get<List<Model.Bill>>(search);

            if (bills != null)
            {
                BillBindingSource.DataSource = bills;
                ReportDataSource source = new ReportDataSource("dsBill", BillBindingSource);
                this.reportViewer.LocalReport.DataSources.Add(source);
                this.reportViewer.RefreshReport();
            }
            else
            {
                BillBindingSource.DataSource = null;
                ReportDataSource source = new ReportDataSource("dsBill", BillBindingSource);
                this.reportViewer.LocalReport.DataSources.Add(source);
                this.reportViewer.RefreshReport();
            }
        }
    }
}
