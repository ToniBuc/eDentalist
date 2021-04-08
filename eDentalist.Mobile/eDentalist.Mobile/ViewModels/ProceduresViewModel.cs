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
    public class ProceduresViewModel : BaseViewModel
    {
        private readonly APIService _procedureService = new APIService("Procedure");
        public ProceduresViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        private string _searchText = null;
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                SetProperty(ref _searchText, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }

        }

        public ObservableCollection<Procedure> ProcedureList { get; set; } = new ObservableCollection<Procedure>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var search = new ProcedureSearchRequest()
            {
                Status = true
            };
            var list = await _procedureService.Get<IEnumerable<Model.Procedure>>(search);

            ProcedureList.Clear();
            if (_searchText != null)
            {
                var normalizedQuery = _searchText?.ToLower() ?? "";
                foreach (var x in list)
                {
                    if (x.Name.ToLowerInvariant().Contains(normalizedQuery))
                    {
                        ProcedureList.Add(x);
                    }
                }
            }
            else
            {
                foreach (var x in list)
                {
                    ProcedureList.Add(x);
                }
            }
        }
    }
}
