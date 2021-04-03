using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl.Http;
using Flurl;
using eDentalist.Model.Requests;
using eDentalist.WinUI.Reports;

namespace eDentalist.WinUI.Staff
{
    public partial class frmStaffMembers : Form
    {
        private readonly APIService _apiService = new APIService("User");
        public frmStaffMembers()
        {
            InitializeComponent();
        }

        private async  void btnSearch_Click(object sender, EventArgs e)
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
                if (x.UserRoleName != "Patient")
                {
                    result.Add(x);
                }
            }

            dgvStaffMembers.AutoGenerateColumns = false;
            dgvStaffMembers.DataSource = result;
        }

        private void dgvStaffMembers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!dgvStaffMembers.RowCount.Equals(0))
            {
                var id = dgvStaffMembers.SelectedRows[0].Cells[0].Value;
                if (APIService.UserID == int.Parse(id.ToString()) || APIService.Role == "Administrator")
                {
                    frmStaffMemberDetail frm = new frmStaffMemberDetail(int.Parse(id.ToString()));
                    frm.FormBorderStyle = FormBorderStyle.FixedSingle;
                    frm.MaximizeBox = false;
                    frm.MinimizeBox = false;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("You do not have permission to access this user's information!", "Authorization", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            if (APIService.Role == "Administrator")
            {
                frmNewStaffMember frm = new frmNewStaffMember();
                frm.FormBorderStyle = FormBorderStyle.FixedSingle;
                frm.MaximizeBox = false;
                frm.MinimizeBox = false;
                frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have permission to access this function!", "Authorization", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            frmCityOverview frm = new frmCityOverview();
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Show();
        }

        private void btnReportStaff_Click(object sender, EventArgs e)
        {
            frmStaffReport frm = new frmStaffReport();
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Show();
        }
    }
}
