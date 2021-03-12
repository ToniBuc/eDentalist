using eDentalist.Model.Requests;
using eDentalist.WinUI.Appointment;
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
    public partial class frmSchedule : Form
    {
        private readonly APIService _apiService = new APIService("UserWorkday");
        public frmSchedule()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new UserWorkdaySearchRequest()
            {
                Name = txtSearch.Text
            };

            var result = await _apiService.Get<List<Model.UserWorkday>>(search);

            dgvSchedule.AutoGenerateColumns = false;
            dgvSchedule.DataSource = result;
        }

        private void btnAddWorkday_Click(object sender, EventArgs e)
        {
            frmNewWorkday frm = new frmNewWorkday();
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Show();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            var id = dgvSchedule.SelectedRows[0].Cells[1].Value;
            frmAppointmentOverview frm = new frmAppointmentOverview(int.Parse(id.ToString()));
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Show();
        }

        private async void dgvSchedule_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!dgvSchedule.RowCount.Equals(0))
            {
                var id = dgvSchedule.SelectedRows[0].Cells[0].Value;

                var dateCheck = await _apiService.GetById<Model.UserWorkday>(id);
                var today = DateTime.Now;
                if (dateCheck.Date.Date > today.Date)
                {
                    frmNewWorkday frm = new frmNewWorkday(int.Parse(id.ToString()));
                    frm.FormBorderStyle = FormBorderStyle.FixedSingle;
                    frm.MaximizeBox = false;
                    frm.MinimizeBox = false;
                    frm.Show();
                }
            }
        }
    }
}
