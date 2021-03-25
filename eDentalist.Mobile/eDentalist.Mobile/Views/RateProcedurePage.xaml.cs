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
    public partial class RateProcedurePage : ContentPage
    {
        private RateProcedureViewModel model = null;
        public RateProcedurePage(int ? id)
        {
            InitializeComponent();
            BindingContext = model = new RateProcedureViewModel()
            {
                AppointmentID = id
            };
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            pickerRating.SelectedIndex = model.Rating - 1;
        }
    }
}