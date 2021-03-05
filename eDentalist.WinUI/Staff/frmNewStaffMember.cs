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
    public partial class frmNewStaffMember : Form
    {
        private readonly APIService _service = new APIService("User");
        private readonly APIService _genderService = new APIService("Gender");
        private readonly APIService _userRoleService = new APIService("UserRole");
        private readonly APIService _cityService = new APIService("City");
        public frmNewStaffMember()
        {
            InitializeComponent();
        }

        UserInsertRequest request = new UserInsertRequest();
        private async void txtSave_Click(object sender, EventArgs e)
        {
            request.FirstName = txtFirstName.Text;
            request.LastName = txtLastName.Text;
            request.JMBG = txtJMBG.Text;
            request.DateOfBirth = dtpDateOfBirth.Value;
            request.Email = txtEmail.Text;
            request.PhoneNumber = txtPhoneNumber.Text;
            request.Address = txtAddress.Text;
            request.Username = txtUsername.Text;
            request.Password = txtPassword.Text;
            request.PasswordConfirmation = txtPasswordConfirmation.Text;

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

            await _service.Insert<Model.User>(request);

            MessageBox.Show("Operation successful!");
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

        private async void frmNewStaffMember_Load(object sender, EventArgs e)
        {
            await LoadGender();
            await LoadUserRole();
            await LoadCity();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                var file = File.ReadAllBytes(fileName);

                request.Image = file;
                txtImageInput.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictureBox.Image = image;
            }
        }
    }
}
