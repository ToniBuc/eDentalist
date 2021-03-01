using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model
{
    public class UserWorkday
    {
        public int UserWorkdayID { get; set; }
        public int UserID { get; set; }
        public int WorkdayID { get; set; }
        public int ShiftID { get; set; }
    }
}
