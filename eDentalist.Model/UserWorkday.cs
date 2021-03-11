using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model
{
    public class UserWorkday
    {
        public int UserWorkdayID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public string UserFullName { get; set; }
        public string UserRole { get; set; }
        public int WorkdayID { get; set; }
        public Workday Workday { get; set; }
        public DateTime Date { get; set; }
        public int ShiftID { get; set; }
        public Shift Shift { get; set; }
        public int ShiftNumber { get; set; }
    }
}
