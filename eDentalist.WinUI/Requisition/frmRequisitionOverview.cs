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

namespace eDentalist.WinUI.Requisition
{
    public partial class frmRequisitionOverview : Form
    {
        private readonly APIService _apiService = new APIService("Requisition");
        public frmRequisitionOverview()
        {
            InitializeComponent();
        }

        private async Task LoadRequisitionType()
        {
            cmbRequisitionType.Items.Insert(0, "");
            cmbRequisitionType.Items.Insert(1, "Equipment");
            cmbRequisitionType.Items.Insert(2, "Material");
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new RequisitionSearchRequest();
            if (cmbRequisitionType.Text == "")
            {
                search.RequisitionType = "All";
            }
            else if (cmbRequisitionType.Text == "Equipment")
            {
                search.RequisitionType = "Equipment";
            }
            else if (cmbRequisitionType.Text == "Material")
            {
                search.RequisitionType = "Material";
            }

            var result = await _apiService.Get<List<Model.Requisition>>(search);

            dgvRequisitions.AutoGenerateColumns = false;
            dgvRequisitions.DataSource = result;
        }

        private async void frmRequisitionOverview_Load(object sender, EventArgs e)
        {
            await LoadRequisitionType();
        }

        private void dgvRequisitions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!dgvRequisitions.RowCount.Equals(0))
            {
                var id = dgvRequisitions.SelectedRows[0].Cells[0].Value;
                var name = dgvRequisitions.SelectedRows[0].Cells[1].Value;
                frmRequisition frm = new frmRequisition(null, name.ToString(), int.Parse(id.ToString()));
                frm.FormBorderStyle = FormBorderStyle.FixedSingle;
                frm.MaximizeBox = false;
                frm.MinimizeBox = false;
                frm.Show();
            }
        }
    }
}
