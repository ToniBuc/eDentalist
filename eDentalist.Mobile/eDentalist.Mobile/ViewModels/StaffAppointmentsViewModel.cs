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
    public class StaffAppointmentsViewModel : BaseViewModel
    {
        //private readonly APIService _userService = new APIService("User");
        private readonly APIService _appointmentService = new APIService("Appointment");

        public StaffAppointmentsViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Appointment> AppointmentList { get; set; } = new ObservableCollection<Appointment>();
        public UserWorkday UserWorkday { get; set; }

        public ICommand InitCommand { get; set; }

        #region Initialization
        private string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        #endregion

        public async Task Init()
        {
            Username = APIService.Username;
            var request = new AppointmentSearchRequest()
            {
                DentistID = APIService.UserID,
                WorkdayID = UserWorkday.WorkdayID
            };

            var list = await _appointmentService.Get<IEnumerable<Appointment>>(request);

            AppointmentList.Clear();

            foreach (var x in list)
            {
                AppointmentList.Add(x);
            }
        }
    }
}
