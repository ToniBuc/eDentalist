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
    public partial class frmCityOverview : Form
    {
        private readonly APIService _apiService = new APIService("City");
        public frmCityOverview()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new CitySearchRequest()
            {
                CityName = txtCity.Text,
                CountryName = txtCountry.Text
            };
            var result = await _apiService.Get<List<Model.City>>(search);

            dgvCities.AutoGenerateColumns = false;
            dgvCities.DataSource = result;
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            frmCity frm = new frmCity();
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Show();
        }

        private void dgvCities_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!dgvCities.RowCount.Equals(0))
            {
                var id = dgvCities.SelectedRows[0].Cells[0].Value;
                frmCity frm = new frmCity(int.Parse(id.ToString()));
                frm.FormBorderStyle = FormBorderStyle.FixedSingle;
                frm.MaximizeBox = false;
                frm.MinimizeBox = false;
                frm.Show();
            }
        }
    }
}
