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
    public class StaffProfileViewModel : BaseViewModel
    {
        private readonly APIService _userService = new APIService("User");
        private readonly APIService _genderService = new APIService("Gender");
        private readonly APIService _cityService = new APIService("City");
        private readonly APIService _userRoleService = new APIService("UserRole");
        public StaffProfileViewModel()
        {
            InitCommand = new Command(async () => await Init());
            SaveCommand = new Command(async () => await Save());
        }

        public ObservableCollection<Gender> GenderList { get; set; } = new ObservableCollection<Gender>();
        public ObservableCollection<City> CityList { get; set; } = new ObservableCollection<City>();

        private City _selectedCity;
        public City SelectedCity
        {
            get { return _selectedCity; }
            set { SetProperty(ref _selectedCity, value); }
        }

        private Gender _selectedGender;
        public Gender SelectedGender
        {
            get { return _selectedGender; }
            set { SetProperty(ref _selectedGender, value); }
        }
        public ICommand InitCommand { get; set; }
        public ICommand SaveCommand { get; set; }

        #region Profile Initialization
        private string _firstName = string.Empty;
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }

        private string _lastName = string.Empty;
        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }

        private string _jmbg = string.Empty;
        public string JMBG
        {
            get { return _jmbg; }
            set { SetProperty(ref _jmbg, value); }
        }

        private string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        private string _phoneNumber = string.Empty;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { SetProperty(ref _phoneNumber, value); }
        }

        private string _address = string.Empty;
        public string Address
        {
            get { return _address; }
            set { SetProperty(ref _address, value); }
        }
        private string _role = string.Empty;
        public string Role
        {
            get { return _role; }
            set { SetProperty(ref _role, value); }
        }
        private string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        private DateTime _dateOfBirth = DateTime.Now;
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { SetProperty(ref _dateOfBirth, value); }
        }
        #endregion

        public async Task Init()
        {
            var user = await _userService.GetById<Model.User>(APIService.UserID);

            var genderList = await _genderService.Get<List<Gender>>(null);
            if (GenderList.Count == 0)
            {
                foreach (var x in genderList)
                {
                    GenderList.Add(x);
                    if (user.Gender.Name == x.Name)
                    {
                        SelectedGender = x;
                    }

                }
            }
            //if (GenderList.Count > 0 && genderList.Count > 0)
            //{
            //    GenderList.Clear();
            //    foreach (var x in genderList)
            //    {
            //        GenderList.Add(x);
            //    }
            //}

            var cityList = await _cityService.Get<List<City>>(null);
            if (CityList.Count == 0)
            {
                
                foreach (var x in cityList)
                {
                    CityList.Add(x);
                    if (user.City.Name == x.Name)
                    {
                        SelectedCity = x;
                    }
                }
            }
            //if (CityList.Count > 0 && cityList.Count > 0)
            //{
            //    CityList.Clear();
            //    foreach (var x in cityList)
            //    {
            //        CityList.Add(x);
            //    }
            //}

            if (user != null)
            {
                FirstName = user.FirstName;
                LastName = user.LastName;
                JMBG = user.JMBG;
                Email = user.Email;
                PhoneNumber = user.PhoneNumber;
                Address = user.Address;
                Role = APIService.Role;
                Username = user.Username;
                DateOfBirth = user.DateOfBirth;
            }
        }

        public async Task Save()
        {
            var request = new UserUpdateRequest()
            {
                FirstName = FirstName,
                LastName = LastName,
                JMBG = JMBG,
                Email = Email,
                PhoneNumber = PhoneNumber,
                Address = Address,
                DateOfBirth = DateOfBirth,
                CityID = SelectedCity.CityID,
                GenderID = SelectedGender.GenderID,
                Username = Username
            };

            var userRoleList = await _userRoleService.Get<List<UserRole>>(null);
            int userRoleId = 0;
            foreach (var x in userRoleList)
            {
                if (x.Name == APIService.Role)
                {
                    userRoleId = x.UserRoleID;
                }
            }

            request.UserRoleID = userRoleId;

            try
            {
                await _userService.Update<Model.User>(APIService.UserID, request);
                await Application.Current.MainPage.DisplayAlert("Notification", "You have successfully updated your personal information!", "OK");
            }
            catch(Exception)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "There was an error during the updating process of your personal information, please make sure you have entered all the required information correctly.", "OK");
            }
        }
    }
}
