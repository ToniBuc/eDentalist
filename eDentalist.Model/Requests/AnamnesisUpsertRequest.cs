using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model.Requests
{
    public class AnamnesisUpsertRequest
    {
        public string AnamnesisContent { get; set; }
        public string Therapy { get; set; }
        public string AdditionalNotes { get; set; }
        public int AppointmentID { get; set; }
    }
}
