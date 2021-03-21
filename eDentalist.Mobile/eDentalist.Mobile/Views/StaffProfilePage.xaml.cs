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
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}