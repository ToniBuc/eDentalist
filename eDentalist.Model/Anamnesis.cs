using System;
using System.Collections.Generic;
using System.Text;

namespace eDentalist.Model
{
    public class Anamnesis
    {
        public int AnamnesisID { get; set; }
        public string AnamnesisContent { get; set; }
        public string Therapy { get; set; }
        public string AdditionalNotes { get; set; }
        public int AppointmentID { get; set; }
    }
}
