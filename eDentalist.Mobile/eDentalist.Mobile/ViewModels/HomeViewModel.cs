using eDentalist.Model;
using eDentalist.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eDentalist.Mobile.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private readonly APIService _appointmentService = new APIService("Appointment/GetTodaysAppointment");

        public HomeViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        //public Appointment Appointment { get; set; }
        public ICommand InitCommand { get; set; }

        #region Initialization
        private string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        private string _appointmentProcedure = string.Empty;
        public string AppointmentProcedure
        {
            get { return _appointmentProcedure; }
            set { SetProperty(ref _appointmentProcedure, value); }
        }
        private string _dateTimeString = string.Empty;
        public string DateTimeString
        {
            get { return _dateTimeString; }
            set { SetProperty(ref _dateTimeString, value); }
        }
        #endregion

        public async Task Init()
        {
            Username = APIService.Username;

            var request = new AppointmentSearchRequest();
            request.Date = DateTime.Now;
            if (APIService.Role == "Patient")
            {
                
                request.PatientID = APIService.UserID;
            }
            else
            {
                request.DentistID = APIService.UserID;
            }

            var appointment = await _appointmentService.Get<List<Appointment>>(request);

            if (appointment.Count > 0)
            {
                AppointmentProcedure = appointment[0].ProcedureName;
                DateTimeString = appointment[0].DateString + " " + appointment[0].TimeframeOrDatetime;
            }
        }
    }
}
