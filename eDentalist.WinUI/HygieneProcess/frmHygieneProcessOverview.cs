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

namespace eDentalist.WinUI.HygieneProcess
{
    public partial class frmHygieneProcessOverview : Form
    {
        private readonly APIService _apiService = new APIService("HygieneProcess");
        private readonly APIService _typeService = new APIService("HygieneProcessType");
        public frmHygieneProcessOverview()
        {
            InitializeComponent();
        }
        private async void frmHygieneProcessOverview_Load(object sender, EventArgs e)
        {
            await LoadHygieneProcessType();
        }

        private async Task LoadHygieneProcessType()
        {
            var result = await _typeService.Get<List<Model.HygieneProcessType>>(null);
            result.Insert(0, new Model.HygieneProcessType());
            cmbHygieneProcessType.DisplayMember = "Name";
            cmbHygieneProcessType.ValueMember = "HygieneProcessTypeID";
            cmbHygieneProcessType.DataSource = result;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            int? IDContainer = null;
            if (cmbHygieneProcessType.SelectedValue != null)
            {
                var prType = cmbHygieneProcessType.SelectedValue;

                if (int.TryParse(prType.ToString(), out int prTypeId))
                {
                    IDContainer = prTypeId;
                }
            }
            var search = new HygieneProcessSearchRequest()
            {
                HygieneProcessTypeID = IDContainer

            };

            //c
            if (search.HygieneProcessTypeID == null)
            {
                search.HygieneProcessTypeID = 0;
            }

            var processList = await _apiService.Get<List<Model.HygieneProcess>>(search);
            var result = new List<Model.HygieneProcess>();

            foreach (var x in processList)
            {
                result.Add(x);
            }

            dgvHygieneProcesses.AutoGenerateColumns = false;
            dgvHygieneProcesses.DataSource = result;
        }


    }
}
