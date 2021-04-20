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
    public partial class frmAppointment : Form
    {
        private readonly APIService _apiService = new APIService("Appointment");
        private readonly APIService _userService = new APIService("User");
        private readonly APIService _statusService = new APIService("AppointmentStatus");
        private readonly APIService _userworkdayService = new APIService("UserWorkday");
        private readonly APIService _workdayService = new APIService("Workday");
        private int? _id = null;
        public frmAppointment(int ? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async Task LoadStaff()
        {
            var appointment = await _apiService.GetById<Model.Appointment>(_id);
            //var search = new UserWorkdaySearchRequest()
            //{
            //    Date = appointment.Date
            //};
            //var userworkday = await _userworkdayService.Get<List<Model.UserWorkday>>(search);
            var search = new WorkdaySearchRequest()
            {
                Date = appointment.Date
            };
            var workday = await _workdayService.Get<List<Model.UserWorkday>>(search);

            var staffSearch = new UserSearchRequest()
            {
                WorkdayID = workday[0].WorkdayID
            };
            var result = await _userService.GetStaff<List<Model.User>>(staffSearch);
            result.Insert(0, new Model.User());
            cmbStaff.DisplayMember = "FullName";
            cmbStaff.ValueMember = "UserID";
            cmbStaff.DataSource = result;
        }

        private async Task LoadStatus()
        {
            var result = await _statusService.Get<List<Model.AppointmentStatus>>(null);
            result.Insert(0, new Model.AppointmentStatus());
            cmbStatus.DisplayMember = "Name";
            cmbStatus.ValueMember = "AppointmentStatusID";
            cmbStatus.DataSource = result;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new AppointmentUpdateRequest();

                var staff = cmbStaff.SelectedValue;
                if (int.TryParse(staff.ToString(), out int staffId))
                {
                    request.DentistID = staffId;
                }
                var status = cmbStatus.SelectedValue;
                if (int.TryParse(status.ToString(), out int statusId))
                {
                    request.AppointmentStatusID = statusId;
                }
                
                if (APIService.UserID == request.DentistID || APIService.Role == "Administrator")
                {
                    await _apiService.Update<Model.Appointment>(_id, request);

                    MessageBox.Show("Operation successful!");
                }
                else
                {
                    MessageBox.Show("You do not have permission to assign this staff member to an appointment!", "Authorization", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                
            }
        }

        private async void frmAppointment_Load(object sender, EventArgs e)
        {
            await LoadStaff();
            await LoadStatus();

            var appointment = await _apiService.GetById<Model.Appointment>(_id);

            txtPatient.Text = appointment.PatientName;
            txtProcedure.Text = appointment.ProcedureName;
            txtDateOfAppointment.Text = appointment.Date.Date.ToString("dd/MM/yyyy");
            txtStartTime.Text = appointment.From;
            txtEndTime.Text = appointment.To;
            cmbStatus.SelectedValue = appointment.AppointmentStatusID;
            if (appointment.DentistID.HasValue)
            {
                cmbStaff.SelectedValue = appointment.DentistID;
            }

            if (appointment.Date.Date <= DateTime.Now.Date)
            {
                cmbStatus.Enabled = false;
                cmbStaff.Enabled = false;
                btnSave.Enabled = false;
            }
        }

        private void cmbStatus_Validating(object sender, CancelEventArgs e)
        {
            if (cmbStatus.SelectedValue.Equals(0))
            {
                errorProvider.SetError(cmbStatus, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbStatus, null);
            }
        }

        private void cmbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStaff.Items.Count <= 1)
            {
                MessageBox.Show("No dentists working on this date, either decline the appointment or assign a dentist to work on the specified appointment date!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
