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
    public class ProceduresViewModel
    {
        private readonly APIService _procedureService = new APIService("Procedure");
        public ProceduresViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Procedure> ProcedureList { get; set; } = new ObservableCollection<Procedure>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var list = await _procedureService.Get<IEnumerable<Model.Procedure>>(null);

            ProcedureList.Clear();
            foreach(var x in list)
            {
                ProcedureList.Add(x);
            }
        }
    }
}
