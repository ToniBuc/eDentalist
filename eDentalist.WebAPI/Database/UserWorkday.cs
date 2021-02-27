using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Database
{
    public class UserWorkday
    {
        public int UserWorkdayID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public int WorkdayID { get; set; }
        public Workday Workday { get; set; }
        public int ShiftID { get; set; }
        public Shift Shift { get; set; }
    }
}
