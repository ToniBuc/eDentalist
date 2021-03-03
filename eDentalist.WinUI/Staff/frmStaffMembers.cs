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
    }
}
