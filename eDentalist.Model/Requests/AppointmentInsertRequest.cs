using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class AppointmentInsertRequest
    {
        public DateTime Date { get; set; } // pending for deletion
        public string From { get; set; }
        public string To { get; set; }
        //public int DentistID { get; set; }
        public int PatientID { get; set; }
        public int ProcedureID { get; set; }
        public int AppointmentStatusID { get; set; }
        public int WorkdayID { get; set; }
    }
}
