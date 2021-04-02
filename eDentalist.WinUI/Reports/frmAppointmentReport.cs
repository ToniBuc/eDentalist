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
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.Value = DateTimePicker.MinimumDateTime;
            dtpFrom.CustomFormat = " ";
            
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.Value = DateTimePicker.MinimumDateTime;
            dtpTo.CustomFormat = " ";
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

            if (search.From == DateTimePicker.MinimumDateTime)
            {
                search.From = null;
            }
            if (search.To == DateTimePicker.MinimumDateTime)
            {
                search.To = null;
            }
            if (search.ProcedureID == 0)
            {
                search.ProcedureID = null;
            }

            var appointments = await _appService.Get<List<Model.Appointment>>(search);

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

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpFrom.CustomFormat = "dd/MM/yyyy";
            //dtpFrom.Value = DateTime.Now;
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            dtpTo.CustomFormat = "dd/MM/yyyy";
            //dtpTo.Value = DateTime.Now;
        }

        private void dtpFrom_DropDown(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now;
        }

        private void dtpTo_DropDown(object sender, EventArgs e)
        {
            dtpTo.Value = DateTime.Now;
        }
    }
}
