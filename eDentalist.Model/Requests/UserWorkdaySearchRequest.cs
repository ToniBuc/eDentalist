using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class UserWorkdaySearchRequest
    {
        //public int? UserWorkdayID { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public int? UserID { get; set; }
    }
}
