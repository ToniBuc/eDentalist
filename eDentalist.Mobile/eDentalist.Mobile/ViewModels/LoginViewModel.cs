using eDentalist.Mobile.Views;
using eDentalist.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eDentalist.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("User/Login");
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
            RegisterCommand = new Command(() => Register());
        }

        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }
        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;
            var login = new UserLoginRequest()
            {
                Username = APIService.Username,
                Password = APIService.Password
            };
            try
            {
                //await _service.Get<dynamic>(null);

                var userLogin = await _service.Login<Model.User>(login);

                APIService.UserID = userLogin.UserID;
                APIService.Role = userLogin.UserRole.Name;

                Application.Current.MainPage = new MainPage();
            }
            catch (Exception)
            {
                IsBusy = false;
                Username = string.Empty;
                Password = string.Empty;
                await Application.Current.MainPage.DisplayAlert("Error", "You have entered an incorrect username or password!", "OK");
            }
        }
        void Register()
        {
            Application.Current.MainPage = new RegistrationPage();
        }
    }
}
