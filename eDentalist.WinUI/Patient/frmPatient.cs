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

namespace eDentalist.WinUI.Patient
{
    public partial class frmPatient : Form
    {
        private readonly APIService _apiService = new APIService("User");
        private readonly APIService _anamService = new APIService("Anamnesis");
        private int? _id = null;
        public frmPatient(int ? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmPatient_Load(object sender, EventArgs e)
        {
            dgvAnamneses.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            //dgvAnamneses.AllowUserToAddRows = false;
            if (_id.HasValue)
            {
                var user = await _apiService.GetById<Model.User>(_id);

                txtFirstName.Text = user.FirstName;
                txtLastName.Text = user.LastName;
                txtJMBG.Text = user.JMBG;
                txtDateOfBirth.Text = user.DateOfBirth.ToString();
                txtEmail.Text = user.Email;
                txtPhoneNumber.Text = user.PhoneNumber;
                txtAddress.Text = user.Address;
                txtUsername.Text = user.Username;
                txtGender.Text = user.GenderName;
                txtCity.Text = user.CityName;

                var search = new AnamnesisSearchRequest()
                {
                    PatientID = _id
                };

                var result = await _anamService.Get<List<Model.Anamnesis>>(search);

                dgvAnamneses.AutoGenerateColumns = false;
                dgvAnamneses.DataSource = result;
            }
        }

        private void dgvAnamneses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!dgvAnamneses.RowCount.Equals(0)) 
            {
                var anamId = dgvAnamneses.SelectedRows[0].Cells[0].Value;
                var appId = dgvAnamneses.SelectedRows[0].Cells[1].Value;
                frmAnamnesis frm = new frmAnamnesis(int.Parse(appId.ToString()), int.Parse(anamId.ToString()));
                frm.FormBorderStyle = FormBorderStyle.FixedSingle;
                frm.MaximizeBox = false;
                frm.MinimizeBox = false;
                frm.Show();
            }
            
        }
    }
}
