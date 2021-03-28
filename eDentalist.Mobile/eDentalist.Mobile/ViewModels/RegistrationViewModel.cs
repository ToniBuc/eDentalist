using eDentalist.Mobile.Views;
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
    public class RegistrationViewModel : BaseViewModel
    {
        private readonly APIService _userService = new APIService("User/Register");

        public RegistrationViewModel()
        {
            RegisterCommand = new Command(async () => await Register());
            ToLoginCommand = new Command(() => ToLogin());
        }

        public ICommand RegisterCommand { get; set; }
        public ICommand ToLoginCommand { get; set; }

        #region Initialization
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }

        private string _jmbg;
        public string JMBG
        {
            get { return _jmbg; }
            set { SetProperty(ref _jmbg, value); }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { SetProperty(ref _phoneNumber, value); }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set { SetProperty(ref _address, value); }
        }
        private string _role;
        public string Role
        {
            get { return _role; }
            set { SetProperty(ref _role, value); }
        }
        private string _username;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        private string _passwordConfirmation;
        public string PasswordConfirmation
        {
            get { return _passwordConfirmation; }
            set { SetProperty(ref _passwordConfirmation, value); }
        }
        private DateTime _dateOfBirth = DateTime.Now;
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { SetProperty(ref _dateOfBirth, value); }
        }
        #endregion

        private async Task Register()
        {

            try
            {
                var request = new UserInsertRequest()
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    JMBG = JMBG,
                    Email = Email,
                    PhoneNumber = PhoneNumber,
                    Address = Address,
                    Username = Username,
                    Password = Password,
                    PasswordConfirmation = PasswordConfirmation,
                    DateOfBirth = DateOfBirth,
                    GenderID = 0,
                    UserRoleID = 0,
                    CityID = 0
                };

                await _userService.Register<User>(request);
                await Application.Current.MainPage.DisplayAlert("Notification", "You have successfully registered your account!", "OK");
                Application.Current.MainPage = new LoginPage();
            }
            catch
            {
                await Application.Current.MainPage.DisplayAlert("Error", "There was an error during the registration process, please make sure you have entered all the required information correctly.", "OK");
            }

        }

        void ToLogin()
        {
            Application.Current.MainPage = new LoginPage();
        }
    }
}
