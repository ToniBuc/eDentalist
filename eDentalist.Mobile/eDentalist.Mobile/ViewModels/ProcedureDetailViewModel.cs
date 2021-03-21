using eDentalist.Model;
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
        public int ? ProcedureID { get; set; }
        public ProcedureDetailViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        //public ObservableCollection<Procedure> Procedure { get; set; } = new ObservableCollection<Procedure>();
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

        public async Task Init()
        {
            //var proc = await _procedureService.Get<IEnumerable<Model.Procedure>>(null);
            Procedure = await _procedureService.GetById<Model.Procedure>(ProcedureID);

            if (Procedure != null)
            {
                Name = Procedure.Name;
                Description = Procedure.Description;
            }
        }
    }
}
