using eDentalist.Model;
using eDentalist.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eDentalist.Mobile.ViewModels
{
    public class PatientAnamnesisViewModel : BaseViewModel
    {
        private readonly APIService _anamnesisService = new APIService("Anamnesis");
        public int? AnamnesisID { get; set; }
        public PatientAnamnesisViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public Anamnesis Anamnesis { get; set; }
        public ICommand InitCommand { get; set; }

        #region Initialization
        private DateTime _date = DateTime.Now;
        public DateTime Date
        {
            get { return _date; }
            set { SetProperty(ref _date, value); }
        }
        private string _dentistName = string.Empty;
        public string DentistName
        {
            get { return _dentistName; }
            set { SetProperty(ref _dentistName, value); }
        }
        private string _anamnesisContent = string.Empty;
        public string AnamnesisContent
        {
            get { return _anamnesisContent; }
            set { SetProperty(ref _anamnesisContent, value); }
        }
        private string _therapy = string.Empty;
        public string Therapy
        {
            get { return _therapy; }
            set { SetProperty(ref _therapy, value); }
        }
        private string _additionalNotes = string.Empty;
        public string AdditionalNotes
        {
            get { return _additionalNotes; }
            set { SetProperty(ref _additionalNotes, value); }
        }
        private string _header = string.Empty;
        public string Header
        {
            get { return _header; }
            set { SetProperty(ref _header, value); }
        }
        #endregion

        public async Task Init()
        {
            Anamnesis = await _anamnesisService.GetById<Anamnesis>(AnamnesisID);
            if (Anamnesis != null)
            {
                Date = Anamnesis.Date;
                DentistName = Anamnesis.DentistFullName;
                AnamnesisContent = Anamnesis.AnamnesisContent;
                Therapy = Anamnesis.Therapy;
                AdditionalNotes = Anamnesis.AdditionalNotes;
                Header = Anamnesis.Appointment.Procedure.Name;
            }
        }
    }
}
