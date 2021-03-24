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
    public class PatientAnamnesesViewModel : BaseViewModel
    {
        private readonly APIService _anamnesisService = new APIService("Anamnesis");

        public PatientAnamnesesViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Anamnesis> AnamnesisList { get; set; } = new ObservableCollection<Anamnesis>();
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
            var request = new AnamnesisSearchRequest()
            {
                PatientID = APIService.UserID
            };

            var list = await _anamnesisService.Get<IEnumerable<Anamnesis>>(request);

            AnamnesisList.Clear();

            foreach (var x in list)
            {
                AnamnesisList.Add(x);
            }
        }
    }
}
