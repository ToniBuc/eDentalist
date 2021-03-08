using eDentalist.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eDentalist.WinUI.Requisition
{
    public partial class frmRequisition : Form
    {
        private readonly APIService _apiService = new APIService("Requisition");
        private readonly APIService _userService = new APIService("User");
        private int? _reqId = null;
        private int? _id = null;
        private string _name = null;
        public frmRequisition(int ? id = null, string name = null, int ? reqId = null)
        {
            InitializeComponent();
            _reqId = reqId;
            _id = id;
            _name = name;
        }

        private async Task LoadUser()
        {
            var result = await _userService.GetStaff<List<Model.User>>(null);
            result.Insert(0, new Model.User());
            cmbRequisitionedBy.DisplayMember = "FullName";
            cmbRequisitionedBy.ValueMember = "UserID";
            cmbRequisitionedBy.DataSource = result;
        }

        private async void frmRequisition_Load(object sender, EventArgs e)
        {
            await LoadUser();
            dtpDateRequisitioned.Format = DateTimePickerFormat.Custom;
            dtpDateRequisitioned.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            if (_id.HasValue)
            {
                cbStatus.Visible = false;
                txtItemName.Text = _name;
            }
            if (_reqId.HasValue)
            {
                cbStatus.Visible = true;
                var requsition = await _apiService.GetById<Model.Requisition>(_reqId);
                txtItemName.Text = _name;
                txtAmount.Text = requsition.Amount.ToString();
                dtpDateRequisitioned.Value = requsition.DateRequisitioned;
                cmbRequisitionedBy.SelectedItem = requsition.UserID;
                cmbRequisitionedBy.SelectedText = requsition.RequisitionedBy;
                cmbRequisitionedBy.SelectedValue = requsition.UserID;
                cbStatus.Checked = requsition.Status;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {


                if (!_id.HasValue && _reqId.HasValue)
                {
                    var request = new RequisitionUpdateRequest()
                    {
                        ItemName = txtItemName.Text,
                        Amount = int.Parse(txtAmount.Text),
                        DateRequisitioned = dtpDateRequisitioned.Value,
                        Status = cbStatus.Checked
                    };

                    var user = cmbRequisitionedBy.SelectedValue;
                    if (int.TryParse(user.ToString(), out int userId))
                    {
                        request.UserID = userId;
                    }

                    await _apiService.Update<Model.Requisition>(_reqId, request);
                }
                else if (_id.HasValue && !_reqId.HasValue)
                {
                    var request = new RequisitionInsertRequest()
                    {
                        ItemName = txtItemName.Text,
                        Amount = int.Parse(txtAmount.Text),
                        DateRequisitioned = dtpDateRequisitioned.Value,
                        MaterialID = _id,
                        EquipmentID = _id
                    };

                    var user = cmbRequisitionedBy.SelectedValue;
                    if (int.TryParse(user.ToString(), out int userId))
                    {
                        request.UserID = userId;
                    }

                    await _apiService.Insert<Model.Requisition>(request);
                }

                MessageBox.Show("Operation successful!");
            }
        }

        private void txtAmount_Validating(object sender, CancelEventArgs e)
        {
            string regex = "[0-9]+$";
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                errorProvider.SetError(txtAmount, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtAmount.Text, regex))
            {
                errorProvider.SetError(txtAmount, "This field must contain a number!");
                e.Cancel = true;
            }
            else if (int.Parse(txtAmount.Text) < 0)
            {
                errorProvider.SetError(txtAmount, "This field can not contain a negative number!");
                e.Cancel = true;
            }
            else if (int.Parse(txtAmount.Text) > 1000)
            {
                errorProvider.SetError(txtAmount, "This field can not contain a number higher than 1000!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtAmount, null);
            }
        }

        private void cmbRequisitionedBy_Validating(object sender, CancelEventArgs e)
        {
            if (cmbRequisitionedBy.SelectedValue.Equals(0))
            {
                errorProvider.SetError(cmbRequisitionedBy, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbRequisitionedBy, null);
            }
        }
    }
}
