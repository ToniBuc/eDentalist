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
    public partial class ProcedureDetailPage : ContentPage
    {
        private ProcedureDetailViewModel model = null;
        public ProcedureDetailPage(int? id)
        {
            InitializeComponent();
            BindingContext = model = new ProcedureDetailViewModel()
            {
                ProcedureID = id
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}