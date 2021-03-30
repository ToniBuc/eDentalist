using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class AppointmentSearchRequest
    {
        public string Name { get; set; } //dentist name
        public string PatientName { get; set; }
        public int? WorkdayID { get; set; }
        public int? DentistID { get; set; }
        public int? PatientID { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
    }
}
