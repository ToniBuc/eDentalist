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
    public class ProcedureReviewsViewModel : BaseViewModel
    {
        private readonly APIService _ratingService = new APIService("Rating");
        private readonly APIService _procedureService = new APIService("Procedure");
        public int? ProcedureID { get; set; }
        public ProcedureReviewsViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Rating> RatingList { get; set; } = new ObservableCollection<Rating>();
        public Procedure Procedure { get; set; }
        public ICommand InitCommand { get; set; }

        private string _procedureName = string.Empty;
        public string ProcedureName
        {
            get { return _procedureName; }
            set { SetProperty(ref _procedureName, value); }
        }

        public async Task Init()
        {
            Procedure = await _procedureService.GetById<Model.Procedure>(ProcedureID);
            ProcedureName = Procedure.Name;
            var search = new RatingSearchRequest()
            {
                ProcedureID = ProcedureID
            };

            var ratingList = await _ratingService.Get<List<Rating>>(search);
            if (RatingList.Count == 0)
            {
                foreach (var x in ratingList)
                {
                    RatingList.Add(x);
                }
            }
        }
    }
}
