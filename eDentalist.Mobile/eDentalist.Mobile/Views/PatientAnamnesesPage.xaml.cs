using eDentalist.Mobile.ViewModels;
using eDentalist.Model;
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
    public partial class PatientAnamnesesPage : ContentPage
    {
        private PatientAnamnesesViewModel model = null;
        public PatientAnamnesesPage()
        {
            InitializeComponent();
            BindingContext = model = new PatientAnamnesesViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Anamnesis;
            var id = item.AnamnesisID;
            await Navigation.PushAsync(new PatientAnamnesisPage(id));
        }
    }
}