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

namespace eDentalist.WinUI.Material
{
    public partial class frmMaterial : Form
    {
        private readonly APIService _apiService = new APIService("Material");
        private int? _id = null;
        public frmMaterial(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new MaterialUpsertRequest()
                {
                    Name = txtMaterialName.Text,
                    Amount = int.Parse(txtAmount.Text),
                    DateAdded = dtpDateAdded.Value,
                    LastUsed = dtpDateLastUsed.Value,
                    Description = rtxtDescription.Text
                };

                if (_id.HasValue)
                {
                    await _apiService.Update<Model.Material>(_id, request);
                }
                else
                {
                    await _apiService.Insert<Model.Material>(request);
                }

                MessageBox.Show("Operation successful!");
            }
        }

        private async void frmMaterial_Load(object sender, EventArgs e)
        {
            dtpDateAdded.Format = DateTimePickerFormat.Custom;
            dtpDateAdded.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dtpDateLastUsed.Format = DateTimePickerFormat.Custom;
            dtpDateLastUsed.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            if (_id.HasValue)
            {
                var material = await _apiService.GetById<Model.Material>(_id);

                txtMaterialName.Text = material.Name;
                txtAmount.Text = material.Amount.ToString();
                dtpDateAdded.Value = material.DateAdded;
                dtpDateLastUsed.Value = material.LastUsed;
                rtxtDescription.Text = material.Description;
            }
        }

        private void txtMaterialName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaterialName.Text))
            {
                errorProvider.SetError(txtMaterialName, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtMaterialName, null);
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
