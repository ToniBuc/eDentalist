using eDentalist.Model.Requests;
using eDentalist.WinUI.Appointment;
using eDentalist.WinUI.Equipment;
using eDentalist.WinUI.HygieneProcess;
using eDentalist.WinUI.Material;
using eDentalist.WinUI.Patient;
using eDentalist.WinUI.Requisition;
using eDentalist.WinUI.Staff;
using eDentalist.WinUI.WorkSchedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentalist.WinUI
{
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;
        private readonly APIService _apiService = new APIService("Appointment");
        public frmIndex()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            frmStaffMembers frm = new frmStaffMembers();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Show();
        }

        private void btnHygiene_Click(object sender, EventArgs e)
        {
            frmHygieneProcessOverview frm = new frmHygieneProcessOverview();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Show();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            frmMaterialOverview frm = new frmMaterialOverview();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Show();
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            frmEquipmentOverview frm = new frmEquipmentOverview();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Show();
        }

        private void btnRequisition_Click(object sender, EventArgs e)
        {
            frmRequisitionOverview frm = new frmRequisitionOverview();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPatientOverview frm = new frmPatientOverview();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAppointmentOverview frm = new frmAppointmentOverview();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Show();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            frmSchedule frm = new frmSchedule();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.FixedSingle;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Show();
        }

        //bug that needs fixing, related to date sent through being one hour ahead than what it should be
        private async void frmIndex_Load(object sender, EventArgs e)
        {
            //pbxLogo.Image = Image.FromFile(@"./logo.png");
            lblUsername.Text = APIService.Username;
            lblDate.Text = DateTime.Now.Date.ToShortDateString();
            var search = new AppointmentSearchRequest()
            {
                //hours need to be lowered by one because for an unknown reason after search gets passed into the Get, it increases the date by an hour (possible timezone issue somehow?)
                Date = DateTime.Now.AddHours(-1),
                Time = DateTime.Now.TimeOfDay
            };
            var result = await _apiService.Get<List<Model.Appointment>>(search);

            dgvAppointments.AutoGenerateColumns = false;
            dgvAppointments.DataSource = result;

            dgvAppointments.ClearSelection();
        }
    }
}
