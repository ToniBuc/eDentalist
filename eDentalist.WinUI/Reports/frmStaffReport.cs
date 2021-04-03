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
    public partial class frmStaffReport : Form
    {
        private readonly APIService _userService = new APIService("User");
        public frmStaffReport()
        {
            InitializeComponent();
        }

        private void frmStaffReport_Load(object sender, EventArgs e)
        {
            reportViewer.ZoomMode = ZoomMode.PageWidth;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new UserSearchRequest()
            {
                FirstName = txtStaff.Text,
                LastName = txtStaff.Text,
                From = dtpFrom.Value,
                To = dtpTo.Value
            };

            var staff = await _userService.GetStaff<List<Model.User>>(search);

            if (staff != null)
            {
                UserBindingSource.DataSource = staff;
                ReportDataSource source = new ReportDataSource("dsStaff", UserBindingSource);
                this.reportViewer.LocalReport.DataSources.Add(source);
                this.reportViewer.RefreshReport();
            }
            else
            {
                UserBindingSource.DataSource = null;
                ReportDataSource source = new ReportDataSource("dsStaff", UserBindingSource);
                this.reportViewer.LocalReport.DataSources.Add(source);
                this.reportViewer.RefreshReport();
            }
        }

        private void dtpFrom_Validating(object sender, CancelEventArgs e)
        {
            if (dtpFrom.Value.Date > dtpTo.Value.Date)
            {
                errorProvider.SetError(dtpFrom, "The From date can not be after the To date!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(dtpFrom, null);
            }
        }

        private void dtpTo_Validating(object sender, CancelEventArgs e)
        {
            if (dtpTo.Value.Date < dtpFrom.Value.Date)
            {
                errorProvider.SetError(dtpFrom, "The To date can not be before the From date!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(dtpFrom, null);
            }
        }
    }
}
