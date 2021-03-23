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
    public partial class StaffAppointmentsPage : ContentPage
    {
        private StaffAppointmentsViewModel model = null;
        public StaffAppointmentsPage(UserWorkday userWorkday)
        {
            InitializeComponent();
            BindingContext = model = new StaffAppointmentsViewModel()
            {
                UserWorkday = userWorkday
            };
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}