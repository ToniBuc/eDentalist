using eDentalist.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eDentalist.Mobile.ViewModels
{
    public class ChangePasswordViewModel : BaseViewModel
    {
        private readonly APIService _userService = new APIService("User");

        public ChangePasswordViewModel()
        {
            UpdatePasswordCommand = new Command(async () => await UpdatePassword());
        }

        public ICommand UpdatePasswordCommand { get; set; }

        #region Initialization
        private string _currentPassword = string.Empty;
        public string CurrentPassword
        {
            get { return _currentPassword; }
            set { SetProperty(ref _currentPassword, value); }
        }
        private string _newPassword = string.Empty;
        public string NewPassword
        {
            get { return _newPassword; }
            set { SetProperty(ref _newPassword, value); }
        }
        private string _newPasswordConfirmation = string.Empty;
        public string NewPasswordConfirmation
        {
            get { return _newPasswordConfirmation; }
            set { SetProperty(ref _newPasswordConfirmation, value); }
        }
        #endregion

        private async Task UpdatePassword()
        {
            if (NewPassword == NewPasswordConfirmation)
            {
                try
                {
                    var user = APIService.User;
                    var request = new UserUpdateRequest()
                    {

                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        JMBG = user.JMBG,
                        Email = user.Email,
                        PhoneNumber = user.Username,
                        Address = user.Address,
                        DateOfBirth = user.DateOfBirth,
                        CityID = user.CityID,
                        GenderID = user.GenderID,
                        UserRoleID = user.UserRoleID,
                        Username = user.Username,
                        Password = NewPassword,
                        PasswordConfirmation = NewPasswordConfirmation
                    };

                    await _userService.Update<Model.User>(APIService.UserID, request);
                    APIService.Password = NewPassword;

                    await Application.Current.MainPage.DisplayAlert("Success", "You have successfully changed your password!", "OK");
                }
                catch
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "An error occured during the update process, please check that all the entered information is correct.", "OK");
                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Your password and confirmation password do not match.", "OK");
            }
        }
    }
}
