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
                patientAnamnesesButton.IsVisible = false;
            }
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        private async void OpenSchedule_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StaffWorkdaysPage());
        }
        private async void OpenAnamneses_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PatientAnamnesesPage());
        }
    }
}