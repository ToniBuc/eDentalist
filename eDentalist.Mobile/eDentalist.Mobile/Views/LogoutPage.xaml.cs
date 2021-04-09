using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eDentalist.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogoutPage : ContentPage
    {
        public LogoutPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            APIService.User = null;
            APIService.UserID = 0;
            APIService.Role = "";
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }
    }
}