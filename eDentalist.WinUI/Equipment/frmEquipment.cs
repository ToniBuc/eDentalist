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

namespace eDentalist.WinUI.Equipment
{
    public partial class frmEquipment : Form
    {
        private readonly APIService _apiService = new APIService("Equipment");
        private readonly APIService _typeService = new APIService("EquipmentType");
        private int? _id = null;
        public frmEquipment(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new EquipmentUpsertRequest()
                {
                    Name = txtEquipmentName.Text,
                    Amount = int.Parse(txtAmount.Text),
                    DateAdded = dtpDateAdded.Value,
                    LastUsed = dtpDateLastUsed.Value,
                    Description = rtxtDescription.Text,
                    Condition = cbCondition.Checked
                };

                var type = cmbEquipmentType.SelectedValue;
                if (int.TryParse(type.ToString(), out int typeId))
                {
                    request.EquipmentTypeID = typeId;
                }

                if (_id.HasValue)
                {
                    await _apiService.Update<Model.Equipment>(_id, request);
                }
                else
                {
                    await _apiService.Insert<Model.Equipment>(request);
                }

                MessageBox.Show("Operation successful!");
            }
        }

        private async Task LoadEquipmentType()
        {
            var result = await _typeService.Get<List<Model.EquipmentType>>(null);
            result.Insert(0, new Model.EquipmentType());
            cmbEquipmentType.DisplayMember = "Name";
            cmbEquipmentType.ValueMember = "EquipmentTypeID";
            cmbEquipmentType.DataSource = result;
        }

        private async void frmEquipment_Load(object sender, EventArgs e)
        {
            await LoadEquipmentType();
            dtpDateAdded.Format = DateTimePickerFormat.Custom;
            dtpDateAdded.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpDateLastUsed.Format = DateTimePickerFormat.Custom;
            dtpDateLastUsed.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            if (_id.HasValue)
            {
                var equipment = await _apiService.GetById<Model.Equipment>(_id);
                txtEquipmentName.Text = equipment.Name;
                txtAmount.Text = equipment.Amount.ToString();
                dtpDateAdded.Value = equipment.DateAdded;
                dtpDateLastUsed.Value = equipment.LastUsed;
                rtxtDescription.Text = equipment.Description;
                cbCondition.Checked = equipment.Condition;
                cmbEquipmentType.SelectedItem = equipment.EquipmentTypeID;
                cmbEquipmentType.SelectedText = equipment.EquipmentTypeName;
                cmbEquipmentType.SelectedValue = equipment.EquipmentTypeID;
            }
        }

        private void txtEquipmentName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEquipmentName.Text))
            {
                errorProvider.SetError(txtEquipmentName, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEquipmentName, null);
            }
        }

        private void cmbEquipmentType_Validating(object sender, CancelEventArgs e)
        {
            if (cmbEquipmentType.SelectedValue.Equals(0))
            {
                errorProvider.SetError(cmbEquipmentType, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbEquipmentType, null);
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
    }
}
