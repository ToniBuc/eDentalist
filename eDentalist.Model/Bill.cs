using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model
{
    public class Bill
    {
        public int BillID { get; set; }
        public DateTime Date { get; set; }
        public string DateString { get; set; }
        public bool IsPaid { get; set; }
        public string IsPaidString { get; set; }
        //public int UserID { get; set; }
        //public User User { get; set; }
        public int AppointmentID { get; set; }
        public Appointment Appointment { get; set; }
        public string ProcedureName { get; set; }
        public string PatientName { get; set; }
        public string DentistName { get; set; }
        public decimal PaymentAmount { get; set; }
    }
}
