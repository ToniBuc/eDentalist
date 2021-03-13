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

namespace eDentalist.WinUI.Appointment
{
    public partial class frmAppointmentOverview : Form
    {
        private readonly APIService _apiService = new APIService("Appointment");
        private int? _workdayId = null;
        public frmAppointmentOverview(int ? workdayId = null)
        {
            InitializeComponent();
            _workdayId = workdayId;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new AppointmentSearchRequest()
            {
                Name = txtSearch.Text
            };
            var result = await _apiService.Get<List<Model.Appointment>>(search);

            dgvAppointments.AutoGenerateColumns = false;
            dgvAppointments.DataSource = result;
        }

        private async void frmAppointmentOverview_Load(object sender, EventArgs e)
        {
            dgvAppointments.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            if (_workdayId.HasValue)
            {
                var search = new AppointmentSearchRequest()
                {
                    WorkdayID = _workdayId
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
    }
}
