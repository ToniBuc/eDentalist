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

namespace eDentalist.WinUI.Procedure
{
    public partial class frmProcedure : Form
    {
        private readonly APIService _apiService = new APIService("Procedure");
        private int? _id = null;
        public frmProcedure(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (APIService.Role == "Administrator")
            {
                if (this.ValidateChildren())
                {
                    var request = new ProcedureUpsertRequest()
                    {
                        Name = txtProcedureName.Text,
                        Price = decimal.Parse(txtPrice.Text),
                        Duration = dtpDuration.Value.TimeOfDay.ToString(),
                        Description = rtxtDescription.Text,
                        Status = cbStatus.Checked
                    };

                    if (_id.HasValue)
                    {
                        await _apiService.Update<Model.Procedure>(_id, request);
                    }
                    else
                    {
                        await _apiService.Insert<Model.Procedure>(request);
                    }

                    MessageBox.Show("Operation successful!");
                }
            }
            else
            {
                MessageBox.Show("You do not have permission to edit procedure information!", "Authorization", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void frmProcedure_Load(object sender, EventArgs e)
        {
            dtpDuration.Format = DateTimePickerFormat.Time;
            dtpDuration.ShowUpDown = true;
            dtpDuration.Value = DateTime.Now.Date + TimeSpan.Parse("00:00:00");
            if (_id.HasValue)
            {
                var procedure = await _apiService.GetById<Model.Procedure>(_id);
                txtProcedureName.Text = procedure.Name;
                txtPrice.Text = procedure.Price.ToString();
                dtpDuration.Value = DateTime.Now.Date + TimeSpan.Parse(procedure.Duration);
                rtxtDescription.Text = procedure.Description;
                cbStatus.Checked = procedure.Status;
            }
        }

        private void txtProcedureName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProcedureName.Text))
            {
                errorProvider.SetError(txtProcedureName, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtProcedureName, null);
            }
        }

        private void txtPrice_Validating(object sender, CancelEventArgs e)
        {
            string regex = @"^[0-9]+(\,[0-9]{1,2})?$";
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                errorProvider.SetError(txtPrice, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtPrice.Text, regex))
            {
                errorProvider.SetError(txtPrice, "This field must contain a valid format for money! Example: 15 or 50,50");
                e.Cancel = true;
            }
            //else if (int.Parse(txtPrice.Text) < 0)
            //{
            //    errorProvider.SetError(txtPrice, "This field can not contain a negative number!");
            //    e.Cancel = true;
            //}
            //else if (int.Parse(txtPrice.Text) > 1000)
            //{
            //    errorProvider.SetError(txtPrice, "This field can not contain a number higher than 1000!");
            //    e.Cancel = true;
            //}
            else
            {
                errorProvider.SetError(txtPrice, null);
            }
        }
    }
}
