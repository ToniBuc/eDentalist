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
        public frmAppointmentOverview()
        {
            InitializeComponent();
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
    }
}
