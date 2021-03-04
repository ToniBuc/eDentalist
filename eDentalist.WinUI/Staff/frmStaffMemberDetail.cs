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

namespace eDentalist.WinUI.Staff
{
    public partial class frmStaffMemberDetail : Form
    {
        private readonly APIService _service = new APIService("User");
        private readonly APIService _genderService = new APIService("Gender");
        private readonly APIService _userRoleService = new APIService("UserRole");
        private int? _id = null;
        public frmStaffMemberDetail(int? userId = null)
        {
            InitializeComponent();
            _id = userId;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var request = new UserUpdateRequest()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                //UserRoleID = 1, //temporary
                //UserRoleID = userTemp.Result.UserRoleID,
                JMBG = txtJMBG.Text,
                DateOfBirth = dtpDateOfBirth.Value,
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Address = txtAddress.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                PasswordConfirmation = txtPasswordConfirmation.Text,
                CityID = 1 //temporary
            };

            var gender = cmbGender.SelectedValue;
            if (int.TryParse(gender.ToString(), out int genderId))
            {
                request.GenderID = genderId;
            }

            var userRole = cmbUserRole.SelectedValue;
            if (int.TryParse(userRole.ToString(), out int userId))
            {
                request.UserRoleID = userId;
            }

            await _service.Update<Model.User>(_id, request);

        }

        private async Task LoadGender()
        {
            var genders = await _genderService.Get<List<Model.Gender>>(null);
            genders.Insert(0, new Model.Gender());
            cmbGender.DisplayMember = "Name";
            cmbGender.ValueMember = "GenderID";
            cmbGender.DataSource = genders;
        }
        private async Task LoadUserRole()
        {
            var result = await _userRoleService.Get<List<Model.UserRole>>(null);
            result.Insert(0, new Model.UserRole());
            cmbUserRole.DisplayMember = "Name";
            cmbUserRole.ValueMember = "UserRoleID";
            cmbUserRole.DataSource = result;
        }

        private async void frmStaffMemberDetail_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var user = await _service.GetById<Model.User>(_id);

                txtFirstName.Text = user.FirstName;
                txtLastName.Text = user.LastName;
                txtJMBG.Text = user.JMBG;
                dtpDateOfBirth.Value = user.DateOfBirth;
                txtEmail.Text = user.Email;
                txtPhoneNumber.Text = user.PhoneNumber;
                txtAddress.Text = user.Address;
                txtUsername.Text = user.Username;
                await LoadUserRole();
                cmbUserRole.SelectedItem = user.UserRoleID;
                cmbUserRole.SelectedText = user.UserRoleName;
                cmbUserRole.SelectedValue = user.UserRoleID;
                await LoadGender();
                cmbGender.SelectedItem = user.GenderID;
                cmbGender.SelectedText = user.GenderName;
                cmbGender.SelectedValue = user.GenderID;
            }
        }
    }
}
