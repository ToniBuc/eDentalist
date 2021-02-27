using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Database
{
    public class Workday
    {
        public int WorkdayID { get; set; }
        public DateTime Date { get; set; }
        //public int ShiftID { get; set; }
        //public Shift Shift { get; set; }
    }
}
