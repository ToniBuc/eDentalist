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

namespace eDentalist.WinUI.Patient
{
    public partial class frmAnamnesis : Form
    {
        private readonly APIService _apiService = new APIService("Anamnesis");
        private readonly APIService _appointmentService = new APIService("Appointment");
        private readonly APIService _userService = new APIService("User");
        private readonly APIService _billService = new APIService("Bill");
        private int? _id = null;
        private int _appId;
        public frmAnamnesis(int appId, int ? id = null)
        {
            InitializeComponent();
            _id = id;
            _appId = appId;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                var request = new AnamnesisUpsertRequest()
                {
                    AnamnesisContent = rtxtAnamnesis.Text,
                    Therapy = rtxtTherapy.Text,
                    AdditionalNotes = rtxtAdditionalNotes.Text,
                    AppointmentID = _appId
                };

                if (_id.HasValue)
                {
                    await _apiService.Update<Model.Anamnesis>(_id, request);
                }
                else
                {
                    var anamInsert = await _apiService.Insert<Model.Anamnesis>(request);
                    if (anamInsert != null)
                    {
                        var billRequest = new BillInsertRequest()
                        {
                            AppointmentID = _appId,
                        };
                        await _billService.Insert<Model.Bill>(billRequest);
                    }
                    else
                    {
                        MessageBox.Show("Operation failed!");
                    }
                }

                MessageBox.Show("Operation successful!");
            }
        }

        private async void frmAnamnesis_Load(object sender, EventArgs e)
        {
            var appointment = await _appointmentService.GetById<Model.Appointment>(_appId);
            txtPatient.Text = appointment.PatientName;
            txtProcedure.Text = appointment.ProcedureName;
            txtDate.Text = appointment.Date.ToShortDateString();
            txtDentist.Text = appointment.DentistName;
            if (_id.HasValue)
            {
                var anamnesis = await _apiService.GetById<Model.Anamnesis>(_id);
                rtxtAnamnesis.Text = anamnesis.AnamnesisContent;
                rtxtTherapy.Text = anamnesis.Therapy;
                rtxtAdditionalNotes.Text = anamnesis.AdditionalNotes;
            }
            
        }

        private void rtxtAnamnesis_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxtAnamnesis.Text))
            {
                errorProvider.SetError(rtxtAnamnesis, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(rtxtAnamnesis, null);
            }
        }

        private void rtxtTherapy_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxtTherapy.Text))
            {
                errorProvider.SetError(rtxtTherapy, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(rtxtTherapy, null);
            }
        }
    }
}
