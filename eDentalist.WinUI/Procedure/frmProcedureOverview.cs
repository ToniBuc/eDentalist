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

namespace eDentalist.WinUI.Procedure
{
    public partial class frmProcedureOverview : Form
    {
        private readonly APIService _apiService = new APIService("Procedure");
        public frmProcedureOverview()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new ProcedureSearchRequest()
            {
                Name = txtSearch.Text,
            };
            var result = await _apiService.Get<List<Model.Procedure>>(search);

            dgvProcedures.AutoGenerateColumns = false;
            dgvProcedures.DataSource = result;
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (APIService.Role == "Administrator")
            {
                frmProcedure frm = new frmProcedure();
                frm.FormBorderStyle = FormBorderStyle.FixedSingle;
                frm.MaximizeBox = false;
                frm.MinimizeBox = false;
                frm.Show();
            }
            else
            {
                MessageBox.Show("You do not have permission to add new procedures!", "Authorization", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvProcedures_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!dgvProcedures.RowCount.Equals(0))
            {
                var id = dgvProcedures.SelectedRows[0].Cells[0].Value;
                frmProcedure frm = new frmProcedure(int.Parse(id.ToString()));
                frm.FormBorderStyle = FormBorderStyle.FixedSingle;
                frm.MaximizeBox = false;
                frm.MinimizeBox = false;
                frm.Show();
            }
        }
    }
}
