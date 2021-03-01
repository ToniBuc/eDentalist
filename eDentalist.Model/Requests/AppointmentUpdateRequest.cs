using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class AppointmentUpdateRequest
    {
        public int DentistID { get; set; }
        public int AppointmentStatusID { get; set; }
    }
}
