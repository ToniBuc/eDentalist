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
    public class StaffWorkdaysViewModel : BaseViewModel
    {
        private readonly APIService _userWorkdayService = new APIService("UserWorkday");

        public StaffWorkdaysViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<UserWorkday> UserWorkdayList { get; set; } = new ObservableCollection<UserWorkday>();

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
            var request = new UserWorkdaySearchRequest()
            {
                UserID = APIService.UserID,
                Date = DateTime.Now
            };

            var list = await _userWorkdayService.Get<IEnumerable<UserWorkday>>(request);

            UserWorkdayList.Clear();

            foreach (var x in list)
            {
                UserWorkdayList.Add(x);
            }
        }
    }
}
