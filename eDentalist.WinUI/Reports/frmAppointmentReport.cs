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
    public partial class frmAppointmentReport : Form
    {
        private readonly APIService _appService = new APIService("Appointment");
        private readonly APIService _procedureService = new APIService("Procedure");
        public frmAppointmentReport()
        {
            InitializeComponent();
        }

        private async void frmAppointmentReport_Load(object sender, EventArgs e)
        {
            await LoadProcedure();
            reportViewer.ZoomMode = ZoomMode.PageWidth;
        }
        private async Task LoadProcedure()
        {
            var result = await _procedureService.Get<List<Model.Procedure>>(null);
            result.Insert(0, new Model.Procedure());
            cmbProcedure.DisplayMember = "Name";
            cmbProcedure.ValueMember = "ProcedureID";
            cmbProcedure.DataSource = result;
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            int? IDContainer = null;
            if (cmbProcedure.SelectedValue != null)
            {
                var prType = cmbProcedure.SelectedValue;

                if (int.TryParse(prType.ToString(), out int prTypeId))
                {
                    IDContainer = prTypeId;
                }
            }

            var search = new AppointmentSearchRequest()
            {
                From = dtpFrom.Value,
                To = dtpTo.Value,
                ProcedureID = IDContainer
            };

            if (search.ProcedureID == 0)
            {
                search.ProcedureID = null;
            }

            var appointments = await _appService.GetReportAppointments<List<Model.Appointment>>(search);

            if (appointments != null)
            {
                AppointmentBindingSource.DataSource = appointments;
                ReportDataSource source = new ReportDataSource("dsAppointment", AppointmentBindingSource);
                this.reportViewer.LocalReport.DataSources.Add(source);
                this.reportViewer.RefreshReport();
            }
            else
            {
                AppointmentBindingSource.DataSource = null;
                ReportDataSource source = new ReportDataSource("dsAppointment", AppointmentBindingSource);
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
