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
    public partial class StaffProfilePage : ContentPage
    {
        private StaffProfileViewModel model = null;
        public StaffProfilePage()
        {
            InitializeComponent();
            BindingContext = model = new StaffProfileViewModel();
            if (APIService.Role == "Patient")
            {
                roleEntry.IsVisible = false;
                roleLabel.IsVisible = false;
                staffScheduleButton.IsVisible = false;
            }
            if (APIService.Role != "Patient")
            {
                patientAppointmentsButton.IsVisible = false;
                patientAnamnesesButton.IsVisible = false;
                patientBillsButton.IsVisible = false;
            }
            
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            if (profileImage.Source == null)
            {
                profileImage.Source = ImageSource.FromFile("logo.png");
            }
        }
        private async void OpenSchedule_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StaffWorkdaysPage());
        }
        private async void OpenAnamneses_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PatientAnamnesesPage());
        }
        private async void OpenAppointments_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StaffAppointmentsPage(null));
        }
        private async void OpenBills_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BillsPage());
        }
    }
}