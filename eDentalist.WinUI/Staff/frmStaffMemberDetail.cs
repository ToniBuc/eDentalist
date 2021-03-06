using eDentalist.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private readonly APIService _cityService = new APIService("City");
        private int? _id = null;
        public frmStaffMemberDetail(int? userId = null)
        {
            InitializeComponent();
            _id = userId;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new UserUpdateRequest()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    JMBG = txtJMBG.Text,
                    DateOfBirth = dtpDateOfBirth.Value,
                    Email = txtEmail.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Address = txtAddress.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    PasswordConfirmation = txtPasswordConfirmation.Text,
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

                var city = cmbCity.SelectedValue;
                if (int.TryParse(city.ToString(), out int cityId))
                {
                    request.CityID = cityId;
                }

                await _service.Update<Model.User>(_id, request);

                MessageBox.Show("Operation successful!");
            }
        }

        private async Task LoadGender()
        {
            var result = await _genderService.Get<List<Model.Gender>>(null);
            result.Insert(0, new Model.Gender());
            cmbGender.DisplayMember = "Name";
            cmbGender.ValueMember = "GenderID";
            cmbGender.DataSource = result;
        }
        private async Task LoadUserRole()
        {
            var result = await _userRoleService.Get<List<Model.UserRole>>(null);
            result.Insert(0, new Model.UserRole());
            cmbUserRole.DisplayMember = "Name";
            cmbUserRole.ValueMember = "UserRoleID";
            cmbUserRole.DataSource = result;
        }
        private async Task LoadCity()
        {
            var result = await _cityService.Get<List<Model.City>>(null);
            result.Insert(0, new Model.City());
            cmbCity.DisplayMember = "Name";
            cmbCity.ValueMember = "CityID";
            cmbCity.DataSource = result;
        }

        private async void frmStaffMemberDetail_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var user = await _service.GetById<Model.User>(_id);

                //loading in image
                if (user.Image.Length > 0)
                {
                    byte[] imgSource = user.Image;
                    Bitmap image;
                    using (MemoryStream stream = new MemoryStream(imgSource))
                    {
                        image = new Bitmap(stream);
                    }
                    pictureBox.Image = image;
                }
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
                await LoadCity();
                cmbCity.SelectedItem = user.CityID;
                cmbCity.SelectedText = user.CityName;
                cmbCity.SelectedValue = user.CityID;
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProvider.SetError(txtFirstName, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtFirstName, null);
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorProvider.SetError(txtLastName, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtLastName, null);
            }
        }

        private void txtJMBG_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtJMBG.Text))
            {
                errorProvider.SetError(txtJMBG, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtJMBG, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (txtUsername.Text.Length < 4)
            {
                errorProvider.SetError(txtUsername, "Username needs to be at least 4 characters long!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtUsername, null);
            }
        }

        private void cmbUserRole_Validating(object sender, CancelEventArgs e)
        {
            if (cmbUserRole.SelectedValue.Equals(0))
            {
                errorProvider.SetError(cmbUserRole, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbUserRole, null);
            }
        }

        private void cmbGender_Validating(object sender, CancelEventArgs e)
        {
            if (cmbGender.SelectedValue.Equals(0))
            {
                errorProvider.SetError(cmbGender, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbGender, null);
            }
        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                errorProvider.SetError(txtPhoneNumber, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPhoneNumber, null);
            }
        }

        private void cmbCity_Validating(object sender, CancelEventArgs e)
        {
            if (cmbCity.SelectedValue.Equals(0))
            {
                errorProvider.SetError(cmbCity, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbCity, null);
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorProvider.SetError(txtAddress, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtAddress, null);
            }
        }
    }
}
