using eDentalist.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
            if (model.Rating == 0)
            {
                labelProc.IsVisible = true;
            }
            else if (Math.Round(model.Rating) == 1)
            {
                ratingImage.Source = ImageSource.FromFile("rating1.png");
            }
            else if (Math.Round(model.Rating) == 2)
            {
                ratingImage.Source = ImageSource.FromFile("rating2.png");
            }
            else if (Math.Round(model.Rating) == 3)
            {
                ratingImage.Source = ImageSource.FromFile("rating3.png");
            }
            else if (Math.Round(model.Rating) == 4)
            {
                ratingImage.Source = ImageSource.FromFile("rating4.png");
            }
            else if (Math.Round(model.Rating) == 5)
            {
                ratingImage.Source = ImageSource.FromFile("rating5.png");
            }

            if (model.RatingList.Count == 0)
            {
                reviewsButton.IsEnabled = false;
            }
        }
        private async void OpenReviews_Clicked(object sender, EventArgs e)
        {
            var id = model.ProcedureID;
            await Navigation.PushAsync(new ProcedureReviewsPage(id));
        }
        private async void BookAppointment_Clicked(object sender, EventArgs e)
        {
            var id = model.ProcedureID;
            await Navigation.PushAsync(new BookAppointmentPage(id));
        }
        async void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            var x = (((TappedEventArgs)e).Parameter) as int?;
            await Navigation.PushAsync(new ProcedureDetailPage(x));
        }
    }
}