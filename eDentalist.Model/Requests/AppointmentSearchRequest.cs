using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class AppointmentSearchRequest
    {
        public string Name { get; set; }
        public int? WorkdayID { get; set; }
        public int? DentistID { get; set; }
    }
}
