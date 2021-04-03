using eDentalist.Model.Requests;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentalist.WinUI.Reports
{
    public partial class frmEquipmentReport : Form
    {
        private readonly APIService _equipmentService = new APIService("Equipment");
        private readonly APIService _typeService = new APIService("EquipmentType");
        public frmEquipmentReport()
        {
            InitializeComponent();
        }

        private async void frmEquipmentReport_Load(object sender, EventArgs e)
        {
            await LoadEquipmentType();
            reportViewer.ZoomMode = ZoomMode.PageWidth;
        }
        private async Task LoadEquipmentType()
        {
            var result = await _typeService.Get<List<Model.EquipmentType>>(null);
            result.Insert(0, new Model.EquipmentType());
            cmbEquipmentType.DisplayMember = "Name";
            cmbEquipmentType.ValueMember = "EquipmentTypeID";
            cmbEquipmentType.DataSource = result;
        }
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new EquipmentSearchRequest()
            {
                Name = txtEquipmentName.Text
            };

            var type = cmbEquipmentType.SelectedValue;
            if (int.TryParse(type.ToString(), out int typeId))
            {
                if (typeId != 0)
                {
                    search.EquipmentTypeID = typeId;
                } 
            }

            var equipment = await _equipmentService.Get<List<Model.Equipment>>(search);

            if (equipment != null)
            {
                EquipmentBindingSource.DataSource = equipment;
                ReportDataSource source = new ReportDataSource("dsEquipment", EquipmentBindingSource);
                this.reportViewer.LocalReport.DataSources.Add(source);
                this.reportViewer.RefreshReport();
            }
            else
            {
                EquipmentBindingSource.DataSource = null;
                ReportDataSource source = new ReportDataSource("dsEquipment", EquipmentBindingSource);
                this.reportViewer.LocalReport.DataSources.Add(source);
                this.reportViewer.RefreshReport();
            }
        }
    }
}
