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
    public partial class ChangePasswordPage : ContentPage
    {
        private ChangePasswordViewModel model = null;
        public ChangePasswordPage()
        {
            InitializeComponent();
            BindingContext = model = new ChangePasswordViewModel();
        }
    }
}