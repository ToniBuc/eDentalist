using eDentalist.Model;
using eDentalist.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eDentalist.Mobile.ViewModels
{
    public class RateProcedureViewModel : BaseViewModel
    {
        private readonly APIService _ratingService = new APIService("Rating");
        private readonly APIService _appointmentService = new APIService("Appointment");
        public int? AppointmentID { get; set; }
        public RateProcedureViewModel()
        {
            InitCommand = new Command(async () => await Init());
            SubmitCommand = new Command(async () => await Submit());
        }

        public ObservableCollection<int> RatingList { get; set; } = new ObservableCollection<int>();

        public ICommand InitCommand { get; set; }
        public ICommand SubmitCommand { get; set; }

        #region Initialization
        private string _procedure = string.Empty;
        public string Procedure
        {
            get { return _procedure; }
            set { SetProperty(ref _procedure, value); }
        }

        private int _rating = 0;
        public int Rating
        {
            get { return _rating; }
            set { SetProperty(ref _rating, value); }
        }
        private string _description = string.Empty;
        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }
        #endregion

        public async Task Init()
        {
            var appointment = await _appointmentService.GetById<Appointment>(AppointmentID);

            var search = new RatingSearchRequest()
            {
                ProcedureID = appointment.ProcedureID,
                UserID = APIService.UserID
            };
            var rating = await _ratingService.Get<List<Rating>>(search);

            if (appointment != null && rating.Count == 1)
            {
                Procedure = appointment.ProcedureName;
                Description = rating[0].Comment;
                Rating = rating[0].Grade;
                for (int i = 1; i < 6; i++)
                {
                    RatingList.Add(i);
                }
            }
            else if (appointment != null && rating.Count == 0)
            {
                Procedure = appointment.ProcedureName;
                for (int i = 1; i < 6; i++)
                {
                    RatingList.Add(i);
                }
            }
        }
        public async Task Submit()
        {
            var appointment = await _appointmentService.GetById<Appointment>(AppointmentID);
            var request = new RatingUpsertRequest()
            {
                ProcedureID = appointment.ProcedureID,
                UserID = APIService.UserID,
                Date = DateTime.Now,
                Grade = Rating,
                Comment = Description
            };

            var search = new RatingSearchRequest()
            {
                ProcedureID = appointment.ProcedureID,
                UserID = APIService.UserID
            };
            var rating = await _ratingService.Get<List<Rating>>(search);

            if (request.Grade != 0)
            {
                if (rating.Count == 1)
                {
                    await _ratingService.Update<Model.Rating>(rating[0].RatingID, request);
                    await Application.Current.MainPage.DisplayAlert("Notification", "You have successfully updated your rating of this procedure!", "OK");
                }
                else
                {
                    await _ratingService.Insert<Model.Rating>(request);
                    await Application.Current.MainPage.DisplayAlert("Notification", "You have successfully given this procedure a rating!", "OK");
                }
                
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Error", "There was an error during the rating process of the procedure, please make sure you have entered all the required information correctly.", "OK");
            }
        }
    }
}
