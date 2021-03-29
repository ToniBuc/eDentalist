using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class AnamnesisSearchRequest
    {
        //public int? AnamnesisID { get; set; }
        public int? PatientID { get; set; }
        public int ? AppointmentID { get; set; }
    }
}
