using eDentalist.Model.Requests;
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

namespace eDentalist.WinUI.Appointment
{
    public partial class frmAppointmentOverview : Form
    {
        private readonly APIService _apiService = new APIService("Appointment");
        private int? _workdayId = null;
        private int? _userId = null;
        public frmAppointmentOverview(int ? workdayId = null, int? userId = null)
        {
            InitializeComponent();
            _workdayId = workdayId;
            _userId = userId;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new AppointmentSearchRequest()
            {
                Name = txtSearch.Text, //dentist name
                PatientName = txtPatientName.Text
            };
            var result = await _apiService.Get<List<Model.Appointment>>(search);

            dgvAppointments.AutoGenerateColumns = false;
            dgvAppointments.DataSource = result;
        }

        private async void frmAppointmentOverview_Load(object sender, EventArgs e)
        {
            dgvAppointments.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            if (_workdayId.HasValue && _userId.HasValue)
            {
                var search = new AppointmentSearchRequest()
                {
                    WorkdayID = _workdayId,
                    DentistID = _userId
                };
                var result = await _apiService.Get<List<Model.Appointment>>(search);

                dgvAppointments.AutoGenerateColumns = false;
                dgvAppointments.DataSource = result;
            }
        }

        private void dgvAppointments_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!dgvAppointments.RowCount.Equals(0))
            {
                var id = dgvAppointments.SelectedRows[0].Cells[0].Value;
                frmAppointment frm = new frmAppointment(int.Parse(id.ToString()));
                frm.FormBorderStyle = FormBorderStyle.FixedSingle;
                frm.MaximizeBox = false;
                frm.MinimizeBox = false;
                frm.Show();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmAppointmentReport frm = new frmAppointmentReport();
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Show();
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            frmBillReport frm = new frmBillReport();
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Show();
        }
    }
}
