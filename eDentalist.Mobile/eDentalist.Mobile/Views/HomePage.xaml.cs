using eDentalist.Mobile.ViewModels;
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
    public partial class HomePage : ContentPage
    {
        private HomeViewModel model = null;
        public HomePage()
        {
            InitializeComponent();
            BindingContext = model = new HomeViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            Logo.Source = ImageSource.FromFile("logo.png");
            if (APIService.Role == "Patient")
            {
                if (!string.IsNullOrEmpty(model.AppointmentProcedure))
                {
                    appointmentLabel.Text = "You have an appointment scheduled for today!";
                }
                else
                {
                    appointmentLabel.Text = "You do not have an appointment scheduled for today.";
                    procedureLabel.IsVisible = false;
                    datetimeLabel.IsVisible = false;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(model.AppointmentProcedure))
                {
                    appointmentLabel.Text = "Your next appointment with a patient is:";
                }
                else
                {
                    appointmentLabel.Text = "You have no appointments with patients left for today.";
                    procedureLabel.IsVisible = false;
                    datetimeLabel.IsVisible = false;
                }
            }
        }
    }
}