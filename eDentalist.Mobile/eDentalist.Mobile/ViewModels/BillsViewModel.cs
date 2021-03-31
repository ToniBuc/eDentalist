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
    public class BillsViewModel : BaseViewModel
    {
        private readonly APIService _billService = new APIService("Bill");

        public BillsViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Bill> BillList { get; set; } = new ObservableCollection<Bill>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var request = new BillSearchRequest()
            {
                PatientID = APIService.UserID
            };

            var list = await _billService.Get<IEnumerable<Bill>>(request);

            BillList.Clear();

            foreach (var x in list)
            {
                BillList.Add(x);
            }
        }
    }
}
