using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class UserWorkdayUpsertRequest
    {
        public int UserID { get; set; }
        //public int WorkdayID { get; set; }
        public DateTime Date { get; set; }
        public int ShiftID { get; set; }
    }
}
