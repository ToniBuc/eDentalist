using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDentalist.WebAPI.Database
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public DateTime Date { get; set; }
        //public DateTime From { get; set; }
        //public DateTime To { get; set; }
        public TimeSpan From { get; set; }
        public TimeSpan To { get; set; }
        public int DentistID { get; set; }
        public User Dentist { get; set; }
        //public int UserWorkdayID { get; set; }
        //public UserWorkday UserWorkday { get; set; }
        public int PatientID { get; set; }
        public User Patient { get; set; }
        public int ProcedureID { get; set; }
        public Procedure Procedure { get; set; }
        public int AppointmentStatusID { get; set; }
        public AppointmentStatus AppointmentStatus { get; set; }
    }
}
