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

namespace eDentalist.WinUI.WorkSchedule
{
    public partial class frmNewWorkday : Form
    {
        private readonly APIService _apiService = new APIService("UserWorkday");
        private readonly APIService _workdayService = new APIService("Workday");
        private readonly APIService _userService = new APIService("User");
        private readonly APIService _shiftService = new APIService("Shift");
        private int? _id = null;
        public frmNewWorkday(int ? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            //dtpDate.Value.AddHours(-1);
            if (this.ValidateChildren())
            {
                //had to add this and use it for setting the value of workdaySearchRequest because for some reason after passing through the Get for Workday the hours gets increased by one
                //and then causes a bug where during the last hour of the day it would switch to the next day instead of staying on the assigned one, potentially crashing the app
                var dateTemp = dtpDate.Value.AddHours(-1);
                var request = new UserWorkdayUpsertRequest()
                {
                    Date = dtpDate.Value
                    
                };
                var workdaySearchRequest = new WorkdaySearchRequest()
                {
                    Date = dateTemp
                };
                var workdayUpsertRequest = new WorkdayUpsertRequest()
                {
                    Date = dtpDate.Value
                };

                var user = cmbStaffMember.SelectedValue;
                if (int.TryParse(user.ToString(), out int userId))
                {
                    request.UserID = userId;
                }
                var shift = cmbShift.SelectedValue;
                if (int.TryParse(shift.ToString(), out int shiftId))
                {
                    request.ShiftID = shiftId;
                }

                //used to check if a workday on the specified day exists, if it does it will return a list with only one workday and if not it will return all workdays
                var workdayDate = await _workdayService.Get<List<Model.Workday>>(workdaySearchRequest);

                //if the workday doesn't exist, insertion of a workday for the specified date will be performed
                if (workdayDate.Count == 0)
                {
                    await _workdayService.Insert<Model.Workday>(workdayUpsertRequest);
                }

                if (_id.HasValue)
                {
                    await _apiService.Update<Model.UserWorkday>(_id, request);
                }
                else
                {
                    await _apiService.Insert<Model.UserWorkday>(request);
                }
                

                MessageBox.Show("Operation successful!");
            }
        }
        private async Task LoadUser()
        {
            var result = await _userService.GetStaff<List<Model.User>>(null);
            result.Insert(0, new Model.User());
            cmbStaffMember.DisplayMember = "FullName";
            cmbStaffMember.ValueMember = "UserID";
            cmbStaffMember.DataSource = result;
        }
        private async Task LoadShift()
        {
            var result = await _shiftService.Get<List<Model.Shift>>(null);
            result.Insert(0, new Model.Shift());
            cmbShift.DisplayMember = "ShiftNumber";
            cmbShift.ValueMember = "ShiftID";
            cmbShift.DataSource = result;
        }

        private async void frmNewWorkday_Load(object sender, EventArgs e)
        {
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd/MM/yyyy";
            await LoadUser();
            await LoadShift();
            if (_id.HasValue)
            {
                var userWorkday = await _apiService.GetById<Model.UserWorkday>(_id);
                dtpDate.Value = userWorkday.Date;
                cmbStaffMember.SelectedItem = userWorkday.UserID;
                cmbStaffMember.SelectedText = userWorkday.UserFullName;
                cmbStaffMember.SelectedValue = userWorkday.UserID;
                cmbShift.SelectedItem = userWorkday.ShiftID;
                cmbShift.SelectedText = userWorkday.ShiftNumber.ToString();
                cmbShift.SelectedValue = userWorkday.ShiftID;
            }
        }

        private void cmbStaffMember_Validating(object sender, CancelEventArgs e)
        {
            if (cmbStaffMember.SelectedValue == null)
            {
                errorProvider.SetError(cmbStaffMember, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (cmbStaffMember.SelectedValue.Equals(0))
            {
                errorProvider.SetError(cmbStaffMember, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbStaffMember, null);
            }
        }

        private void cmbShift_Validating(object sender, CancelEventArgs e)
        {
            if (cmbShift.SelectedValue == null)
            {
                errorProvider.SetError(cmbShift, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (cmbShift.SelectedValue.Equals(0))
            {
                errorProvider.SetError(cmbShift, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbShift, null);
            }
        }

        private void dtpDate_Validating(object sender, CancelEventArgs e)
        {
            var dateNow = DateTime.Now;
            if (dtpDate.Value.Date <= dateNow)
            {
                errorProvider.SetError(dtpDate, "The specified date can not be older than or equal to todays date!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(dtpDate, null);
            }
        }
    }
}
