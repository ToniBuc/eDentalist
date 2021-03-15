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
    public partial class frmCity : Form
    {
        private readonly APIService _apiService = new APIService("City");
        private readonly APIService _countryService = new APIService("Country");
        private int? _id = null;
        public frmCity(int ? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new CityUpsertRequest()
                {
                    Name = txtCity.Text,
                    ZIPCode = txtZIPCode.Text
                };

                var country = cmbCountry.SelectedValue;
                if (int.TryParse(country.ToString(), out int countryId))
                {
                    request.CountryID = countryId;
                }

                if (_id.HasValue)
                {
                    await _apiService.Update<Model.City>(_id, request);
                }
                else
                {
                    await _apiService.Insert<Model.City>(request);
                }
                
                MessageBox.Show("Operation successful!");
            }
        }

        private async Task LoadCountry()
        {
            var result = await _countryService.Get<List<Model.Country>>(null);
            result.Insert(0, new Model.Country());
            cmbCountry.DisplayMember = "Name";
            cmbCountry.ValueMember = "CountryID";
            cmbCountry.DataSource = result;
        }

        private async void frmCity_Load(object sender, EventArgs e)
        {
            await LoadCountry();
            if (_id.HasValue)
            {
                var city = await _apiService.GetById<Model.City>(_id);
                txtCity.Text = city.Name;
                txtZIPCode.Text = city.ZIPCode;
                cmbCountry.SelectedValue = city.CountryID;
            }
        }

        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                errorProvider.SetError(txtCity, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtCity, null);
            }
        }

        private void cmbCountry_Validating(object sender, CancelEventArgs e)
        {
            if (cmbCountry.SelectedValue.Equals(0))
            {
                errorProvider.SetError(cmbCountry, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbCountry, null);
            }
        }
    }
}
