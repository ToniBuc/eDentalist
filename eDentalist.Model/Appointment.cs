using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int WorkdayID { get; set; }
        public Workday Workday { get; set; }
        public DateTime Date { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string FromTo { get; set; }
        public int? DentistID { get; set; }
        public User Dentist { get; set; }
        public string DentistName { get; set; }
        public int PatientID { get; set; }
        public User Patient { get; set; }
        public string PatientName { get; set; }
        public int ProcedureID { get; set; }
        public Procedure Procedure { get; set; }
        public string ProcedureName { get; set; }
        public int AppointmentStatusID { get; set; }
        public AppointmentStatus AppointmentStatus { get; set;}
        public string AppointmentStatusName { get; set; }

        //specific for mobile, used to display different things in listviews for patients and staff roles
        public string PatientOrStatus { get; set; }
        public string TimeframeOrDatetime { get; set; }
    }
}
