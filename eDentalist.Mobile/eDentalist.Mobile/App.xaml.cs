using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using eDentalist.Mobile.Services;
using eDentalist.Mobile.Views;

namespace eDentalist.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
