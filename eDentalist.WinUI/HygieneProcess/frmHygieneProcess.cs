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

namespace eDentalist.WinUI.HygieneProcess
{
    public partial class frmHygieneProcess : Form
    {
        private readonly APIService _apiService = new APIService("HygieneProcess");
        private readonly APIService _userService = new APIService("User");
        private readonly APIService _typeService = new APIService("HygieneProcessType");
        private int? _id = null;
        public frmHygieneProcess(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmHygieneProcess_Load(object sender, EventArgs e)
        {
            await LoadUser();
            await LoadHygieneProcessType();

            if (_id.HasValue)
            {
                var hygieneProcess = await _apiService.GetById<Model.HygieneProcess>(_id);
                dtpDateOfPerformance.Value = hygieneProcess.DateOfPerformance;
                cmbStaffMember.SelectedItem = hygieneProcess.UserID;
                cmbStaffMember.SelectedText = hygieneProcess.StaffName;
                cmbStaffMember.SelectedValue = hygieneProcess.UserID;
                cmbHygieneProcessType.SelectedItem = hygieneProcess.HygieneProcessTypeID;
                cmbHygieneProcessType.SelectedText = hygieneProcess.HygieneProcessTypeName;
                cmbHygieneProcessType.SelectedValue = hygieneProcess.HygieneProcessTypeID;
                cbStatus.Checked = hygieneProcess.Status;
                rtxtDescription.Text = hygieneProcess.Description;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new HygieneProcessUpsertRequest()
                {
                    DateOfPerformance = dtpDateOfPerformance.Value,
                    Description = rtxtDescription.Text,
                    Status = cbStatus.Checked
                };

                var user = cmbStaffMember.SelectedValue;
                if (int.TryParse(user.ToString(), out int userId))
                {
                    request.UserID = userId;
                }
                var prType = cmbHygieneProcessType.SelectedValue;
                if (int.TryParse(prType.ToString(), out int prTypeId))
                {
                    request.HygieneProcessTypeID = prTypeId;
                }

                if (_id.HasValue)
                {
                    await _apiService.Update<Model.HygieneProcess>(_id, request);
                }
                else
                {
                    await _apiService.Insert<Model.HygieneProcess>(request);
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
        private async Task LoadHygieneProcessType()
        {
            var result = await _typeService.Get<List<Model.HygieneProcessType>>(null);
            result.Insert(0, new Model.HygieneProcessType());
            cmbHygieneProcessType.DisplayMember = "Name";
            cmbHygieneProcessType.ValueMember = "HygieneProcessTypeID";
            cmbHygieneProcessType.DataSource = result;
        }

        private void cmbStaffMember_Validating(object sender, CancelEventArgs e)
        {
            if (cmbStaffMember.SelectedValue.Equals(0))
            {
                errorProvider.SetError(cmbStaffMember, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbStaffMember, null);
            }
        }

        private void cmbHygieneProcessType_Validating(object sender, CancelEventArgs e)
        {
            if (cmbHygieneProcessType.SelectedValue.Equals(0))
            {
                errorProvider.SetError(cmbHygieneProcessType, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbHygieneProcessType, null);
            }
        }
    }
}
