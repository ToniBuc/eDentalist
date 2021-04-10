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
    public partial class ProceduresPage : ContentPage
    {
        private ProceduresViewModel model = null;
        public ProceduresPage()
        {
            InitializeComponent();
            BindingContext = model = new ProceduresViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            Logo.Source = ImageSource.FromFile("logo.png");
        }
        async void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            var x = (((TappedEventArgs)e).Parameter) as int?;
            await Navigation.PushAsync(new ProcedureDetailPage(x));
        }
    }
}