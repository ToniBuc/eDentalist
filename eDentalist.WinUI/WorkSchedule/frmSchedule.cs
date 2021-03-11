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
    }
}
