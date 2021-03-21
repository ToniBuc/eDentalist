using eDentalist.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eDentalist.Mobile.ViewModels
{
    public class StaffProfileViewModel : BaseViewModel
    {
        private readonly APIService _userService = new APIService("User");
        public StaffProfileViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }

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
        private string _city = string.Empty;
        public string City
        {
            get { return _city; }
            set { SetProperty(ref _city, value); }
        }
        private string _role = string.Empty;
        public string Role
        {
            get { return _role; }
            set { SetProperty(ref _role, value); }
        }
        private string _gender = string.Empty;
        public string Gender
        {
            get { return _gender; }
            set { SetProperty(ref _gender, value); }
        }
        private string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        private string _dateOfBirth = string.Empty;
        public string DateOfBirth
        {
            get { return _dateOfBirth; }
            set { SetProperty(ref _dateOfBirth, value); }
        }
        #endregion

        public async Task Init()
        {
            var user = await _userService.GetById<Model.User>(APIService.UserID);

            var dateString = user.DateOfBirth.ToShortDateString();
            if (user != null)
            {
                FirstName = user.FirstName;
                LastName = user.LastName;
                JMBG = user.JMBG;
                Email = user.Email;
                PhoneNumber = user.PhoneNumber;
                Address = user.Address;
                City = user.City.Name;
                Role = APIService.Role;
                Gender = user.Gender.Name;
                Username = user.Username;
                DateOfBirth = user.DateOfBirth.ToShortDateString();
            }
        }
    }
}
