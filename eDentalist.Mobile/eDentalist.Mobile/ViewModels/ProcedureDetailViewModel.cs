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
    public class ProcedureDetailViewModel : BaseViewModel
    {
        private readonly APIService _procedureService = new APIService("Procedure");
        private readonly APIService _recommendedService = new APIService("Procedure/RecommendedProcedures");
        private readonly APIService _ratingService = new APIService("Rating");
        public int ? ProcedureID { get; set; }
        public ProcedureDetailViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Procedure> RecommendedProcedureList { get; set; } = new ObservableCollection<Procedure>();
        public List<Rating> RatingList { get; set; } = new List<Rating>();
        public Procedure Procedure { get; set; }
        public ICommand InitCommand { get; set; }

        private string _name = string.Empty;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
        private string _description = string.Empty;
        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }
        private float _rating = 0;
        public float Rating
        {
            get { return _rating; }
            set { SetProperty(ref _rating, value); }
        }

        public async Task Init()
        {
            Procedure = await _procedureService.GetById<Model.Procedure>(ProcedureID);
            var search = new RatingSearchRequest()
            {
                ProcedureID = ProcedureID
            };

            RatingList = await _ratingService.Get<List<Rating>>(search);
            if (RatingList.Count > 0)
            {
                float listCount = RatingList.Count;
                float listSum = new int();
                foreach (var x in RatingList)
                {
                    listSum += x.Grade;
                }

                Rating = listSum / listCount;
            }

            if (Procedure != null)
            {
                Name = Procedure.Name;
                Description = Procedure.Description;
            }

            var list = await _recommendedService.GetById<IEnumerable<Procedure>>(ProcedureID);

            RecommendedProcedureList.Clear();
            foreach(var x in list)
            {
                RecommendedProcedureList.Add(x);
            }
        }
    }
}
