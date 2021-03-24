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
    public partial class PatientAnamnesisPage : ContentPage
    {
        private PatientAnamnesisViewModel model = null;
        public PatientAnamnesisPage(int ? id)
        {
            InitializeComponent();
            BindingContext = model = new PatientAnamnesisViewModel()
            {
                AnamnesisID = id
            };
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}