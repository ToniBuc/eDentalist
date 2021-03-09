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
    public partial class frmPatientOverview : Form
    {
        private readonly APIService _apiService = new APIService("User");
        public frmPatientOverview()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new UserSearchRequest()
            {
                FirstName = txtSearch.Text,
                LastName = txtSearch.Text
            };

            var userList = await _apiService.Get<List<Model.User>>(search);
            var result = new List<Model.User>();

            foreach (var x in userList)
            {
                if (x.UserRoleName == "Patient")
                {
                    result.Add(x);
                }
            }

            dgvPatients.AutoGenerateColumns = false;
            dgvPatients.DataSource = result;
        }

        private void dgvPatients_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!dgvPatients.RowCount.Equals(0))
            {
                var id = dgvPatients.SelectedRows[0].Cells[0].Value;
                frmPatient frm = new frmPatient(int.Parse(id.ToString()));
                frm.FormBorderStyle = FormBorderStyle.FixedSingle;
                frm.MaximizeBox = false;
                frm.MinimizeBox = false;
                frm.Show();
            }
        }
    }
}
