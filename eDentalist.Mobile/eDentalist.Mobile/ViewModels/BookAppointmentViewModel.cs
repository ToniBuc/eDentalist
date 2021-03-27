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
    public class BookAppointmentViewModel : BaseViewModel
    {
        private readonly APIService _appointmentService = new APIService("Appointment");
        private readonly APIService _procedureService = new APIService("Procedure");
        private readonly APIService _workdayService = new APIService("Workday");
        public BookAppointmentViewModel()
        {
            InitCommand = new Command(async () => await Init());
            SubmitCommand = new Command(async () => await Submit());
        }

        public ObservableCollection<Procedure> ProcedureList { get; set; } = new ObservableCollection<Procedure>();

        private Procedure _selectedProcedure;
        public Procedure SelectedProcedure
        {
            get { return _selectedProcedure; }
            set { SetProperty(ref _selectedProcedure, value); }
        }

        public ICommand InitCommand { get; set; }
        public ICommand SubmitCommand { get; set; }

        #region Initialization & Validation
        //initialization
        private DateTime _date = DateTime.Now;
        public DateTime Date
        {
            get { return _date; }
            set { SetProperty(ref _date, value); }
        }
        private TimeSpan _from;
        public TimeSpan From
        {
            get { return _from; }
            set { SetProperty(ref _from, value); }
        }
        private TimeSpan _to;
        public TimeSpan To
        {
            get { return _to; }
            set { SetProperty(ref _to, value); }
        }
        //validation
        bool _procedureValidation = false;
        public bool ProcedureValidation
        {
            get { return _procedureValidation; }
            set { SetProperty(ref _procedureValidation, value); }
        }
        bool _fromValidation = false;
        public bool FromValidation
        {
            get { return _fromValidation; }
            set { SetProperty(ref _fromValidation, value); }
        }
        bool _toValidation = false;
        public bool ToValidation
        {
            get { return _toValidation; }
            set { SetProperty(ref _toValidation, value); }
        }
        bool _dateValidation = false;
        public bool DateValidation
        {
            get { return _dateValidation; }
            set { SetProperty(ref _dateValidation, value); }
        }
        bool _shiftValidation = false;
        public bool ShiftValidation
        {
            get { return _shiftValidation; }
            set { SetProperty(ref _shiftValidation, value); }
        }
        #endregion

        public async Task Init()
        {
            ProcedureValidation = false;
            DateValidation = false;
            FromValidation = false;
            ToValidation = false;
            var procedureList = await _procedureService.Get<IEnumerable<Procedure>>(null);
            ProcedureList.Clear();
            foreach (var x in procedureList)
            {
                ProcedureList.Add(x);
            }
        }

        private bool ValidateForm()
        {
            TimeSpan fromShiftOne = TimeSpan.Parse("07:00:00");
            TimeSpan toShiftOne = TimeSpan.Parse("15:00:00");
            TimeSpan fromShiftTwo = TimeSpan.Parse("15:00:00");
            TimeSpan toShiftTwo = TimeSpan.Parse("23:00:00");

            ProcedureValidation = false;
            DateValidation = false;
            FromValidation = false;
            ToValidation = false;
            ShiftValidation = false;

            bool IsValidated = true;
            if (SelectedProcedure == null)
            {
                ProcedureValidation = true;
                IsValidated = false;
            }

            if (Date.Date <= DateTime.Now.Date)
            {
                DateValidation = true;
                IsValidated = false;
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////
            if (From > fromShiftOne && To > toShiftOne)
            {
                //FromValidation = true;
                //ToValidation = true;
                ShiftValidation = true;
                IsValidated = false;
            }

            if (From > fromShiftTwo && To > toShiftTwo)
            {
                FromValidation = true;
                ToValidation = true;
                IsValidated = false;
            }

            if (From < fromShiftOne)
            {
                FromValidation = true;
                IsValidated = false;
            }

            if (To > toShiftTwo)
            {
                ToValidation = true;
                IsValidated = false;
            }

            return IsValidated;
        }

        public async Task Submit()
        {
            if (ValidateForm())
            {
                var searchWorkday = new WorkdaySearchRequest()
                {
                    Date = Date
                };
                var workday = await _workdayService.Get<List<Workday>>(searchWorkday);

                if (workday.Count == 0)
                {
                    var insertWorkday = new WorkdayUpsertRequest()
                    {
                        Date = Date
                    };
                    await _workdayService.Insert<Workday>(insertWorkday);
                    workday = await _workdayService.Get<List<Workday>>(searchWorkday);
                }

                var request = new AppointmentInsertRequest()
                {
                    ProcedureID = SelectedProcedure.ProcedureID,
                    PatientID = APIService.UserID,
                    //Date = Date,
                    WorkdayID = workday[0].WorkdayID,
                    From = From.ToString(),
                    To = To.ToString()
                };

                try
                {
                    await _appointmentService.Insert<Appointment>(request);
                    await Application.Current.MainPage.DisplayAlert("Notification", "You have successfully booked an appointment! It's current status is set to pending, " +
                        "check back later to see if it's been approved or declined. Should you want to cancel, you can find your appointments under your profile page.", "OK");
                }
                catch (Exception)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "There was an error during the booking process of the appointment, please make sure you have entered all the required information correctly.", "OK");
                }
            }
        }
    }
}
